/**
 * Author......: See docs/credits.txt
 * License.....: MIT
 */

//#define NEW_SIMD_CODE

#include "inc_vendor.cl"
#include "inc_hash_constants.h"
#include "inc_hash_functions.cl"
#include "inc_types.cl"
#include "inc_common.cl"
#include "inc_scalar.cl"
#include "inc_hash_sha1.cl"
#include "inc_hash_sha256.cl"

#if   VECT_SIZE == 1
#define uint_to_hex_lower8_le(i) (u32x) (l_bin2asc[(i)])
#elif VECT_SIZE == 2
#define uint_to_hex_lower8_le(i) (u32x) (l_bin2asc[(i).s0], l_bin2asc[(i).s1])
#elif VECT_SIZE == 4
#define uint_to_hex_lower8_le(i) (u32x) (l_bin2asc[(i).s0], l_bin2asc[(i).s1], l_bin2asc[(i).s2], l_bin2asc[(i).s3])
#elif VECT_SIZE == 8
#define uint_to_hex_lower8_le(i) (u32x) (l_bin2asc[(i).s0], l_bin2asc[(i).s1], l_bin2asc[(i).s2], l_bin2asc[(i).s3], l_bin2asc[(i).s4], l_bin2asc[(i).s5], l_bin2asc[(i).s6], l_bin2asc[(i).s7])
#elif VECT_SIZE == 16
#define uint_to_hex_lower8_le(i) (u32x) (l_bin2asc[(i).s0], l_bin2asc[(i).s1], l_bin2asc[(i).s2], l_bin2asc[(i).s3], l_bin2asc[(i).s4], l_bin2asc[(i).s5], l_bin2asc[(i).s6], l_bin2asc[(i).s7], l_bin2asc[(i).s8], l_bin2asc[(i).s9], l_bin2asc[(i).sa], l_bin2asc[(i).sb], l_bin2asc[(i).sc], l_bin2asc[(i).sd], l_bin2asc[(i).se], l_bin2asc[(i).sf])
#endif

__kernel void m12600_mxx (__global pw_t *pws, __global const kernel_rule_t *rules_buf, __global const pw_t *combs_buf, __global const bf_t *bfs_buf, __global void *tmps, __global void *hooks, __global const u32 *bitmaps_buf_s1_a, __global const u32 *bitmaps_buf_s1_b, __global const u32 *bitmaps_buf_s1_c, __global const u32 *bitmaps_buf_s1_d, __global const u32 *bitmaps_buf_s2_a, __global const u32 *bitmaps_buf_s2_b, __global const u32 *bitmaps_buf_s2_c, __global const u32 *bitmaps_buf_s2_d, __global plain_t *plains_buf, __global const digest_t *digests_buf, __global u32 *hashes_shown, __global const salt_t *salt_bufs, __global const void *esalt_bufs, __global u32 *d_return_buf, __global u32 *d_scryptV0_buf, __global u32 *d_scryptV1_buf, __global u32 *d_scryptV2_buf, __global u32 *d_scryptV3_buf, const u32 bitmap_mask, const u32 bitmap_shift1, const u32 bitmap_shift2, const u32 salt_pos, const u32 loop_pos, const u32 loop_cnt, const u32 il_cnt, const u32 digests_cnt, const u32 digests_offset, const u32 combs_mode, const u64 gid_max)
{
  /**
   * modifier
   */

  const u64 gid = get_global_id (0);
  const u64 lid = get_local_id (0);
  const u64 lsz = get_local_size (0);

  /**
   * bin2asc table
   */

  __local u32 l_bin2asc[256];

  for (MAYBE_VOLATILE u32 i = lid; i < 256; i += lsz)
  {
    const u32 i0 = (i >> 0) & 15;
    const u32 i1 = (i >> 4) & 15;

    l_bin2asc[i] = ((i0 < 10) ? '0' + i0 : 'A' - 10 + i0) << 0
                 | ((i1 < 10) ? '0' + i1 : 'A' - 10 + i1) << 8;
  }

  barrier (CLK_LOCAL_MEM_FENCE);

  if (gid >= gid_max) return;

  /**
   * salt
   */

  u32 pc256[8];

  pc256[0] = salt_bufs[salt_pos].salt_buf_pc[0];
  pc256[1] = salt_bufs[salt_pos].salt_buf_pc[1];
  pc256[2] = salt_bufs[salt_pos].salt_buf_pc[2];
  pc256[3] = salt_bufs[salt_pos].salt_buf_pc[3];
  pc256[4] = salt_bufs[salt_pos].salt_buf_pc[4];
  pc256[5] = salt_bufs[salt_pos].salt_buf_pc[5];
  pc256[6] = salt_bufs[salt_pos].salt_buf_pc[6];
  pc256[7] = salt_bufs[salt_pos].salt_buf_pc[7];

  /**
   * base
   */

  sha1_ctx_t ctx0;

  sha1_init (&ctx0);

  sha1_update_global_swap (&ctx0, pws[gid].i, pws[gid].pw_len);

  /**
   * loop
   */

  for (u32 il_pos = 0; il_pos < il_cnt; il_pos++)
  {
    sha1_ctx_t ctx1 = ctx0;

    sha1_update_global_swap (&ctx1, combs_buf[il_pos].i, combs_buf[il_pos].pw_len);

    sha1_final (&ctx1);

    const u32 a = ctx1.h[0];
    const u32 b = ctx1.h[1];
    const u32 c = ctx1.h[2];
    const u32 d = ctx1.h[3];
    const u32 e = ctx1.h[4];

    sha256_ctx_t ctx;

    ctx.h[0] = pc256[0];
    ctx.h[1] = pc256[1];
    ctx.h[2] = pc256[2];
    ctx.h[3] = pc256[3];
    ctx.h[4] = pc256[4];
    ctx.h[5] = pc256[5];
    ctx.h[6] = pc256[6];
    ctx.h[7] = pc256[7];

    ctx.len = 64;

    ctx.w0[0] = uint_to_hex_lower8_le ((a >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((a >> 24) & 255) << 16;
    ctx.w0[1] = uint_to_hex_lower8_le ((a >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((a >>  8) & 255) << 16;
    ctx.w0[2] = uint_to_hex_lower8_le ((b >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((b >> 24) & 255) << 16;
    ctx.w0[3] = uint_to_hex_lower8_le ((b >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((b >>  8) & 255) << 16;
    ctx.w1[0] = uint_to_hex_lower8_le ((c >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((c >> 24) & 255) << 16;
    ctx.w1[1] = uint_to_hex_lower8_le ((c >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((c >>  8) & 255) << 16;
    ctx.w1[2] = uint_to_hex_lower8_le ((d >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((d >> 24) & 255) << 16;
    ctx.w1[3] = uint_to_hex_lower8_le ((d >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((d >>  8) & 255) << 16;
    ctx.w2[0] = uint_to_hex_lower8_le ((e >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((e >> 24) & 255) << 16;
    ctx.w2[1] = uint_to_hex_lower8_le ((e >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((e >>  8) & 255) << 16;
    ctx.w2[2] = 0;
    ctx.w2[3] = 0;
    ctx.w3[0] = 0;
    ctx.w3[1] = 0;
    ctx.w3[2] = 0;
    ctx.w3[3] = 0;

    ctx.len += 40;

    sha256_final (&ctx);

    ctx.h[0] -= pc256[0];
    ctx.h[1] -= pc256[1];
    ctx.h[2] -= pc256[2];
    ctx.h[3] -= pc256[3];
    ctx.h[4] -= pc256[4];
    ctx.h[5] -= pc256[5];
    ctx.h[6] -= pc256[6];
    ctx.h[7] -= pc256[7];

    const u32 r0 = ctx.h[DGST_R0];
    const u32 r1 = ctx.h[DGST_R1];
    const u32 r2 = ctx.h[DGST_R2];
    const u32 r3 = ctx.h[DGST_R3];

    COMPARE_M_SCALAR (r0, r1, r2, r3);
  }
}

__kernel void m12600_sxx (__global pw_t *pws, __global const kernel_rule_t *rules_buf, __global const pw_t *combs_buf, __global const bf_t *bfs_buf, __global void *tmps, __global void *hooks, __global const u32 *bitmaps_buf_s1_a, __global const u32 *bitmaps_buf_s1_b, __global const u32 *bitmaps_buf_s1_c, __global const u32 *bitmaps_buf_s1_d, __global const u32 *bitmaps_buf_s2_a, __global const u32 *bitmaps_buf_s2_b, __global const u32 *bitmaps_buf_s2_c, __global const u32 *bitmaps_buf_s2_d, __global plain_t *plains_buf, __global const digest_t *digests_buf, __global u32 *hashes_shown, __global const salt_t *salt_bufs, __global const void *esalt_bufs, __global u32 *d_return_buf, __global u32 *d_scryptV0_buf, __global u32 *d_scryptV1_buf, __global u32 *d_scryptV2_buf, __global u32 *d_scryptV3_buf, const u32 bitmap_mask, const u32 bitmap_shift1, const u32 bitmap_shift2, const u32 salt_pos, const u32 loop_pos, const u32 loop_cnt, const u32 il_cnt, const u32 digests_cnt, const u32 digests_offset, const u32 combs_mode, const u64 gid_max)
{
  /**
   * modifier
   */

  const u64 gid = get_global_id (0);
  const u64 lid = get_local_id (0);
  const u64 lsz = get_local_size (0);

  /**
   * bin2asc table
   */

  __local u32 l_bin2asc[256];

  for (MAYBE_VOLATILE u32 i = lid; i < 256; i += lsz)
  {
    const u32 i0 = (i >> 0) & 15;
    const u32 i1 = (i >> 4) & 15;

    l_bin2asc[i] = ((i0 < 10) ? '0' + i0 : 'A' - 10 + i0) << 0
                 | ((i1 < 10) ? '0' + i1 : 'A' - 10 + i1) << 8;
  }

  barrier (CLK_LOCAL_MEM_FENCE);

  if (gid >= gid_max) return;

  /**
   * digest
   */

  const u32 search[4] =
  {
    digests_buf[digests_offset].digest_buf[DGST_R0],
    digests_buf[digests_offset].digest_buf[DGST_R1],
    digests_buf[digests_offset].digest_buf[DGST_R2],
    digests_buf[digests_offset].digest_buf[DGST_R3]
  };

  /**
   * salt
   */

  u32 pc256[8];

  pc256[0] = salt_bufs[salt_pos].salt_buf_pc[0];
  pc256[1] = salt_bufs[salt_pos].salt_buf_pc[1];
  pc256[2] = salt_bufs[salt_pos].salt_buf_pc[2];
  pc256[3] = salt_bufs[salt_pos].salt_buf_pc[3];
  pc256[4] = salt_bufs[salt_pos].salt_buf_pc[4];
  pc256[5] = salt_bufs[salt_pos].salt_buf_pc[5];
  pc256[6] = salt_bufs[salt_pos].salt_buf_pc[6];
  pc256[7] = salt_bufs[salt_pos].salt_buf_pc[7];

  /**
   * base
   */

  sha1_ctx_t ctx0;

  sha1_init (&ctx0);

  sha1_update_global_swap (&ctx0, pws[gid].i, pws[gid].pw_len);

  /**
   * loop
   */

  for (u32 il_pos = 0; il_pos < il_cnt; il_pos++)
  {
    sha1_ctx_t ctx1 = ctx0;

    sha1_update_global_swap (&ctx1, combs_buf[il_pos].i, combs_buf[il_pos].pw_len);

    sha1_final (&ctx1);

    const u32 a = ctx1.h[0];
    const u32 b = ctx1.h[1];
    const u32 c = ctx1.h[2];
    const u32 d = ctx1.h[3];
    const u32 e = ctx1.h[4];

    sha256_ctx_t ctx;

    ctx.h[0] = pc256[0];
    ctx.h[1] = pc256[1];
    ctx.h[2] = pc256[2];
    ctx.h[3] = pc256[3];
    ctx.h[4] = pc256[4];
    ctx.h[5] = pc256[5];
    ctx.h[6] = pc256[6];
    ctx.h[7] = pc256[7];

    ctx.len = 64;

    ctx.w0[0] = uint_to_hex_lower8_le ((a >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((a >> 24) & 255) << 16;
    ctx.w0[1] = uint_to_hex_lower8_le ((a >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((a >>  8) & 255) << 16;
    ctx.w0[2] = uint_to_hex_lower8_le ((b >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((b >> 24) & 255) << 16;
    ctx.w0[3] = uint_to_hex_lower8_le ((b >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((b >>  8) & 255) << 16;
    ctx.w1[0] = uint_to_hex_lower8_le ((c >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((c >> 24) & 255) << 16;
    ctx.w1[1] = uint_to_hex_lower8_le ((c >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((c >>  8) & 255) << 16;
    ctx.w1[2] = uint_to_hex_lower8_le ((d >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((d >> 24) & 255) << 16;
    ctx.w1[3] = uint_to_hex_lower8_le ((d >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((d >>  8) & 255) << 16;
    ctx.w2[0] = uint_to_hex_lower8_le ((e >> 16) & 255) <<  0
              | uint_to_hex_lower8_le ((e >> 24) & 255) << 16;
    ctx.w2[1] = uint_to_hex_lower8_le ((e >>  0) & 255) <<  0
              | uint_to_hex_lower8_le ((e >>  8) & 255) << 16;
    ctx.w2[2] = 0;
    ctx.w2[3] = 0;
    ctx.w3[0] = 0;
    ctx.w3[1] = 0;
    ctx.w3[2] = 0;
    ctx.w3[3] = 0;

    ctx.len += 40;

    sha256_final (&ctx);

    ctx.h[0] -= pc256[0];
    ctx.h[1] -= pc256[1];
    ctx.h[2] -= pc256[2];
    ctx.h[3] -= pc256[3];
    ctx.h[4] -= pc256[4];
    ctx.h[5] -= pc256[5];
    ctx.h[6] -= pc256[6];
    ctx.h[7] -= pc256[7];

    const u32 r0 = ctx.h[DGST_R0];
    const u32 r1 = ctx.h[DGST_R1];
    const u32 r2 = ctx.h[DGST_R2];
    const u32 r3 = ctx.h[DGST_R3];

    COMPARE_S_SCALAR (r0, r1, r2, r3);
  }
}
