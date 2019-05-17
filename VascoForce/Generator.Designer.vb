<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generator
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generator))
        Me.hex = New System.Windows.Forms.Button()
        Me.NumSymLowUp = New System.Windows.Forms.Button()
        Me.NumbersUppers = New System.Windows.Forms.Button()
        Me.NumbersLowers = New System.Windows.Forms.Button()
        Me.Symbols = New System.Windows.Forms.Button()
        Me.Numbers = New System.Windows.Forms.Button()
        Me.Lowercase = New System.Windows.Forms.Button()
        Me.Uppercase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hex
        '
        Me.hex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hex.Image = Global.VascoForce.My.Resources.Resources.hex
        Me.hex.Location = New System.Drawing.Point(303, 88)
        Me.hex.Name = "hex"
        Me.hex.Size = New System.Drawing.Size(91, 62)
        Me.hex.TabIndex = 7
        Me.hex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.hex.UseVisualStyleBackColor = True
        '
        'NumSymLowUp
        '
        Me.NumSymLowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumSymLowUp.Image = CType(resources.GetObject("NumSymLowUp.Image"), System.Drawing.Image)
        Me.NumSymLowUp.Location = New System.Drawing.Point(206, 88)
        Me.NumSymLowUp.Name = "NumSymLowUp"
        Me.NumSymLowUp.Size = New System.Drawing.Size(91, 62)
        Me.NumSymLowUp.TabIndex = 6
        Me.NumSymLowUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NumSymLowUp.UseVisualStyleBackColor = True
        '
        'NumbersUppers
        '
        Me.NumbersUppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumbersUppers.Image = Global.VascoForce.My.Resources.Resources.numbersuppers
        Me.NumbersUppers.Location = New System.Drawing.Point(109, 88)
        Me.NumbersUppers.Name = "NumbersUppers"
        Me.NumbersUppers.Size = New System.Drawing.Size(91, 62)
        Me.NumbersUppers.TabIndex = 5
        Me.NumbersUppers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NumbersUppers.UseVisualStyleBackColor = True
        '
        'NumbersLowers
        '
        Me.NumbersLowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumbersLowers.Image = Global.VascoForce.My.Resources.Resources.numberslowers
        Me.NumbersLowers.Location = New System.Drawing.Point(12, 88)
        Me.NumbersLowers.Name = "NumbersLowers"
        Me.NumbersLowers.Size = New System.Drawing.Size(91, 62)
        Me.NumbersLowers.TabIndex = 4
        Me.NumbersLowers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NumbersLowers.UseVisualStyleBackColor = True
        '
        'Symbols
        '
        Me.Symbols.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Symbols.Image = Global.VascoForce.My.Resources.Resources.symbols
        Me.Symbols.Location = New System.Drawing.Point(303, 20)
        Me.Symbols.Name = "Symbols"
        Me.Symbols.Size = New System.Drawing.Size(91, 62)
        Me.Symbols.TabIndex = 3
        Me.Symbols.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Symbols.UseVisualStyleBackColor = True
        '
        'Numbers
        '
        Me.Numbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numbers.Image = Global.VascoForce.My.Resources.Resources.numbers
        Me.Numbers.Location = New System.Drawing.Point(206, 20)
        Me.Numbers.Name = "Numbers"
        Me.Numbers.Size = New System.Drawing.Size(91, 62)
        Me.Numbers.TabIndex = 2
        Me.Numbers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Numbers.UseVisualStyleBackColor = True
        '
        'Lowercase
        '
        Me.Lowercase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lowercase.Image = Global.VascoForce.My.Resources.Resources.lowercase
        Me.Lowercase.Location = New System.Drawing.Point(12, 20)
        Me.Lowercase.Name = "Lowercase"
        Me.Lowercase.Size = New System.Drawing.Size(91, 62)
        Me.Lowercase.TabIndex = 0
        Me.Lowercase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Lowercase.UseVisualStyleBackColor = True
        '
        'Uppercase
        '
        Me.Uppercase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uppercase.Image = Global.VascoForce.My.Resources.Resources.uppercase
        Me.Uppercase.Location = New System.Drawing.Point(109, 20)
        Me.Uppercase.Name = "Uppercase"
        Me.Uppercase.Size = New System.Drawing.Size(91, 62)
        Me.Uppercase.TabIndex = 1
        Me.Uppercase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Uppercase.UseVisualStyleBackColor = True
        '
        'Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 170)
        Me.Controls.Add(Me.hex)
        Me.Controls.Add(Me.NumSymLowUp)
        Me.Controls.Add(Me.NumbersUppers)
        Me.Controls.Add(Me.NumbersLowers)
        Me.Controls.Add(Me.Symbols)
        Me.Controls.Add(Me.Numbers)
        Me.Controls.Add(Me.Lowercase)
        Me.Controls.Add(Me.Uppercase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(423, 209)
        Me.MinimumSize = New System.Drawing.Size(423, 209)
        Me.Name = "Generator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Uppercase As Button
    Friend WithEvents Lowercase As Button
    Friend WithEvents Numbers As Button
    Friend WithEvents Symbols As Button
    Friend WithEvents NumbersLowers As Button
    Friend WithEvents NumbersUppers As Button
    Friend WithEvents NumSymLowUp As Button
    Friend WithEvents hex As Button
End Class
