Imports System.IO
Imports System.Threading

Public Class VascoForce
    Private dircmd As String = Directory.GetCurrentDirectory().ToString()
    Private dirhashcat As String = dircmd + "\hashcat"
    Private algorithm As String = "" 'Done
    Private atkspeed As String = "" 'Done
    Private atklength As Integer
    Private pattern As String = ""
    Private cmd As String = "" 'Done

    Private Sub Crack_Click(sender As Object, e As EventArgs) Handles Crack.Click
        algorithm = cmbAlgorithm.Text
        Select Case algorithm
            Case "SHA1"
                algorithm = "100"
            Case "MD5"
                algorithm = "0"
            Case Else
                coutput.Text = "ERROR: select an algorithm!"
                Exit Sub
        End Select

        atkspeed = cmbAtkSpeed.Text
        Select Case atkspeed
            Case "Light"
                atkspeed = "1"
            Case "Normal"
                atkspeed = "2"
            Case "High"
                atkspeed = "3"
            Case "Rush"
                atkspeed = "4"
            Case Else
                coutput.Text = "ERROR: select attack speed!"
                Exit Sub
        End Select

        If pattern = "" Then
            coutput.Text = "ERROR: pattern can't be empty!"
            Exit Sub
        End If

        cmd = "/k cd hashcat & " + "hashcat64 -m " + algorithm + " -a 3 -O -w " + atkspeed + " " + dircmd + "\hash.txt " + pattern

        Process.Start("cmd", cmd)

        atklength = 0
        pattern = ""
        cpattern.Text = ""
        cLenght.Text = "0"
        coutput.Text = "Bruteforce pattern will be shown here."
    End Sub

    Public Sub AddToPattern(ByVal key As String)
        If atklength >= 16 Then
            coutput.Text = "ERROR: pattern length limit!"
            Exit Sub
        End If

        pattern += key
        atklength += 1

        cpattern.Text = pattern
        cLenght.Text = atklength
    End Sub

    Private Sub Generator_Click(sender As Object, e As EventArgs) Handles bGenerator.Click
        Generator.Show()
    End Sub
End Class
