Imports System.Text
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class QRCODE
    Dim filelocation2 As String = "C:\Users\limbe\Downloads\VB PROJECT\GroupB_makan selera\order.txt"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim order As New StringBuilder
        order.AppendLine("Name: " + checkout.TextBox1.Text)
        order.AppendLine("Phone No: " + checkout.TextBox2.Text)
        order.AppendLine("Email: " + checkout.TextBox3.Text)
        order.AppendLine("AddressLine: " + checkout.TextBox4.Text)
        order.AppendLine("City: " + checkout.TextBox5.Text)
        order.AppendLine("State: " + checkout.TextBox6.Text)
        order.AppendLine("Postcode: " + checkout.TextBox7.Text)
        order.AppendLine("PaymentMethod: E-wallet")
        order.AppendLine("")
        File.AppendAllText(filelocation2, order.ToString())
        MsgBox("Order placed!")
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancel As String = MsgBox("Are you sure to cancel the payment?", vbOKCancel)
        If cancel = vbOK Then
            Me.Hide()
            checkout.Show()
        End If

    End Sub
End Class