Imports System.Text
Imports System.IO
Imports System.Collections.Concurrent
Imports System.Security.Cryptography
Imports System.ComponentModel

Public Class loginRegister
    Dim count As Integer = 0
    Dim filelocation As String = "C:\Users\limbe\Downloads\VB PROJECT\GroupB_makan selera\account.txt"
    Private Sub loginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file() As String = IO.File.ReadAllLines("C:\Users\limbe\Downloads\VB PROJECT\GroupB_makan selera\account.txt")
        Dim pass As String = TextBox1.Text + " " + TextBox2.Text

        If file.Contains(pass) Then
            MsgBox("Login Succesfully!")
            Formfood.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login error!  " + (2 - count).ToString() + " attempts left")
            count += 1
            If count > 3 Then
                MessageBox.Show("Number of attempts exceeded. Please wait 1 minutes!")
                Button1.Hide()
                Timer3.Interval = 5000
                Timer3.Start()

            End If
        End If



    End Sub

    Private Function Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Button1.Show()
        count = 0
        Timer3.Stop()
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        FormStart.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        reset.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pass As String, username1 As String = TextBox3.Text
        pass = TextBox3.Text + " " + TextBox4.Text
        Dim line, username, b As String, save As Boolean = False
        If CheckBox1.Checked = False Then
            MsgBox("Please check the checkbox above!")
        ElseIf CheckBox1.Checked = True Then
            Using reader As New StreamReader(filelocation)
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    b = line.IndexOf(" ")
                    username = line.Substring(0, b)
                    If Not (username = username1) Then
                        save = True
                    ElseIf username = username1 Then
                        MsgBox("Username already taken!")
                        save = False
                        Exit While
                        End If
                End While
            End Using
        End If

        If save = True Then
            save1(pass)
        End If


    End Sub
    Sub save1(pass As String)
        Dim text As New StringBuilder
        text.AppendLine(pass)
        File.AppendAllText(filelocation, text.ToString())
        MessageBox.Show("Register succesfully!")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class