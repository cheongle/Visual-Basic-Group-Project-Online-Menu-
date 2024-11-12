Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Text
Public Class reset
    Dim filelocation As String = "C:\Users\limbe\Downloads\VB PROJECT\GroupB_makan selera\account.txt"
    Private Sub reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        loginRegister.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text As New StringBuilder
        Dim line, username, b As String, username1 = TextBox1.Text, pass As String = TextBox2.Text, reset As Boolean = False
        If CheckBox1.Checked = False Then
            MsgBox("Please check the checkbox above!")
        ElseIf pass = "" Then
            MsgBox("Password cannot be empty!")
        ElseIf CheckBox1.Checked = True And Not (pass = "") Then
            Using reader As New StreamReader(filelocation)
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    b = line.IndexOf(" ")
                    username = line.Substring(0, b)
                    If Not (username = username1) Then
                        text.AppendLine(line)
                    ElseIf username = username1 Then
                        reset = True
                        Dim userpass As String = username1 + " " + pass
                        text.AppendLine(userpass)
                    End If
                End While
                If reader.EndOfStream And reset = False Then
                    MsgBox("Username not found!")
                End If
            End Using
        End If

        If reset = True Then
            reset1(text)
        End If
    End Sub

    Sub reset1(a As StringBuilder)
        File.WriteAllText(filelocation, String.Empty)
        File.AppendAllText(filelocation, a.ToString())
        MessageBox.Show("Reset succesfully!")
        Me.Hide()
        loginRegister.Show()
    End Sub
End Class