<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VascoForce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VascoForce))
        Me.Crack = New System.Windows.Forms.Button()
        Me.lblAlgorithms = New System.Windows.Forms.Label()
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAtkSpeed = New System.Windows.Forms.ComboBox()
        Me.cpattern = New System.Windows.Forms.Label()
        Me.coutput = New System.Windows.Forms.Label()
        Me.cLenght = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cLenghtTitle = New System.Windows.Forms.Label()
        Me.bGenerator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Crack
        '
        Me.Crack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crack.Location = New System.Drawing.Point(82, 199)
        Me.Crack.Name = "Crack"
        Me.Crack.Size = New System.Drawing.Size(70, 23)
        Me.Crack.TabIndex = 3
        Me.Crack.Text = "Crack"
        Me.Crack.UseVisualStyleBackColor = True
        '
        'lblAlgorithms
        '
        Me.lblAlgorithms.AutoSize = True
        Me.lblAlgorithms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlgorithms.Location = New System.Drawing.Point(49, 37)
        Me.lblAlgorithms.Name = "lblAlgorithms"
        Me.lblAlgorithms.Size = New System.Drawing.Size(62, 15)
        Me.lblAlgorithms.TabIndex = 100
        Me.lblAlgorithms.Text = "Algorithm:"
        '
        'cmbAlgorithm
        '
        Me.cmbAlgorithm.FormattingEnabled = True
        Me.cmbAlgorithm.Items.AddRange(New Object() {"SHA1", "MD5"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(118, 36)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(61, 21)
        Me.cmbAlgorithm.TabIndex = 0
        Me.cmbAlgorithm.Text = "SHA1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Atk speed:"
        '
        'cmbAtkSpeed
        '
        Me.cmbAtkSpeed.FormattingEnabled = True
        Me.cmbAtkSpeed.Items.AddRange(New Object() {"Light", "Normal", "High", "Rush"})
        Me.cmbAtkSpeed.Location = New System.Drawing.Point(118, 73)
        Me.cmbAtkSpeed.Name = "cmbAtkSpeed"
        Me.cmbAtkSpeed.Size = New System.Drawing.Size(61, 21)
        Me.cmbAtkSpeed.TabIndex = 1
        Me.cmbAtkSpeed.Text = "Normal"
        '
        'cpattern
        '
        Me.cpattern.Location = New System.Drawing.Point(26, 172)
        Me.cpattern.Name = "cpattern"
        Me.cpattern.Size = New System.Drawing.Size(185, 16)
        Me.cpattern.TabIndex = 104
        Me.cpattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'coutput
        '
        Me.coutput.Location = New System.Drawing.Point(13, 236)
        Me.coutput.Name = "coutput"
        Me.coutput.Size = New System.Drawing.Size(207, 16)
        Me.coutput.TabIndex = 106
        Me.coutput.Text = "Bruteforce pattern will be shown here."
        Me.coutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cLenght
        '
        Me.cLenght.Location = New System.Drawing.Point(186, 157)
        Me.cLenght.Name = "cLenght"
        Me.cLenght.Size = New System.Drawing.Size(22, 16)
        Me.cLenght.TabIndex = 105
        Me.cLenght.Text = "0"
        Me.cLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Mask:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cLenghtTitle
        '
        Me.cLenghtTitle.Location = New System.Drawing.Point(147, 156)
        Me.cLenghtTitle.Name = "cLenghtTitle"
        Me.cLenghtTitle.Size = New System.Drawing.Size(47, 16)
        Me.cLenghtTitle.TabIndex = 103
        Me.cLenghtTitle.Text = "Lenght:"
        Me.cLenghtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bGenerator
        '
        Me.bGenerator.Location = New System.Drawing.Point(69, 117)
        Me.bGenerator.Name = "bGenerator"
        Me.bGenerator.Size = New System.Drawing.Size(98, 23)
        Me.bGenerator.TabIndex = 2
        Me.bGenerator.Text = "Mask Generator"
        Me.bGenerator.UseVisualStyleBackColor = True
        '
        'VascoForce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 281)
        Me.Controls.Add(Me.bGenerator)
        Me.Controls.Add(Me.cLenghtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cLenght)
        Me.Controls.Add(Me.cpattern)
        Me.Controls.Add(Me.cmbAtkSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlgorithm)
        Me.Controls.Add(Me.lblAlgorithms)
        Me.Controls.Add(Me.coutput)
        Me.Controls.Add(Me.Crack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(250, 320)
        Me.MinimumSize = New System.Drawing.Size(250, 320)
        Me.Name = "VascoForce"
        Me.Text = "VascoForce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Crack As Button
    Friend WithEvents lblAlgorithms As Label
    Friend WithEvents cmbAlgorithm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAtkSpeed As ComboBox
    Friend WithEvents cpattern As Label
    Friend WithEvents coutput As Label
    Friend WithEvents cLenght As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cLenghtTitle As Label
    Friend WithEvents bGenerator As Button
End Class
