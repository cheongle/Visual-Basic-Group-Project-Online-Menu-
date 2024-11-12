Public Class FormStart
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        loginRegister.Show()
        Me.Hide()
    End Sub
End Class
