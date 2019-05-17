Public Class Generator
    Private pattern As String = ""

    Private Sub Lowercase_Click(sender As Object, e As EventArgs) Handles Lowercase.Click
        pattern = "?l"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub Uppercase_Click(sender As Object, e As EventArgs) Handles Uppercase.Click
        pattern = "?u"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles Numbers.Click
        pattern = "?d"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub Symbols_Click(sender As Object, e As EventArgs) Handles Symbols.Click
        pattern = "?s"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub NumbersLowers_Click(sender As Object, e As EventArgs) Handles NumbersLowers.Click
        pattern = "?h"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub NumbersUppers_Click(sender As Object, e As EventArgs) Handles NumbersUppers.Click
        pattern = "?H"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub NumSymLowUp_Click(sender As Object, e As EventArgs) Handles NumSymLowUp.Click
        pattern = "?a"
        VascoForce.AddToPattern(pattern)
    End Sub

    Private Sub hex_Click(sender As Object, e As EventArgs) Handles hex.Click
        pattern = "?b"
        VascoForce.AddToPattern(pattern)
    End Sub
End Class