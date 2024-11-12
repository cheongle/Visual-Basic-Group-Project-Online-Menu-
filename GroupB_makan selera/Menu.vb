Option Explicit On
Imports System.Text
Imports System.IO
Public Class checkout
    Dim f() As String = {"Nasi Goreng", "Nasi Ayam", "Nasi Lemak", "Mee Goreng", "Char Kuey Tiaw", "Laksa"}
    Dim d() As String = {"Teh Ais", "Teh O Ais", "Kopi", "Milo Ais", "Limau Ais", "Coca Cola"}
    Private totalbefore, totalafter As Double
    Dim day As Integer
    Dim filelocation2 As String = "C:\Users\limbe\Downloads\VB PROJECT\GroupB_makan selera\order.txt"



    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t(12) As String
        Dim j As Integer = 0
        For i As Integer = 0 To 5
            If Formfood.food(i) > 0 Then
                Formfood.Total += Formfood.food(i) * Formfood.foodprice(i)
                t(j) = (j + 1).ToString() + ") " + f(i) + " * " + Formfood.food(i).ToString() + "/RM " + Formfood.foodprice(i).ToString() + " each"
                j += 1
            End If
        Next
        For i As Integer = 0 To 5
            If FormDrink.drink(i) > 0 Then
                FormDrink.total += FormDrink.drink(i) * FormDrink.drinkprice(i)
                t(j) = (j + 1).ToString() + ") " + d(i) + " * " + FormDrink.drink(i).ToString() + "/RM " + FormDrink.drinkprice(i).ToString() + " each"
                j += 1
            End If

        Next
        totalbefore = Formfood.Total + FormDrink.total
        ListBox1.Items.Clear()
        For a As Integer = 0 To j - 1
            ListBox1.Items.Add(t(a).ToString())
        Next
        Label1.Text = "SUBTOTAL: RM " + totalbefore.ToString()
        getDayofWeek()
        If day = 7 Then
            MsgBox("Today is SUNDAY! Enjoy 5% off now!")
            Label2.Text = "Sunday discount available"
            totalafter = totalbefore - ((totalbefore * 5) / 100)
        Else
            MsgBox("Enjoy 5% discount only on SUNDAY")
            Label2.Text = "Sunday discount not available"
            totalafter = totalbefore
        End If
        Label3.Text = "Grand Total: RM " + totalafter.ToString()
    End Sub

    Sub getDayofWeek()
        Dim dayofWeek As DayOfWeek = DateTime.Now.DayOfWeek
        day = dayofWeek
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Payment.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim order As New StringBuilder
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox(("Basic details cannot be EMPTY!"))
            Exit Sub
        End If
        Dim cardnumber, cardname, expirydate, CVV As String
        If (Payment.SelectedItem.ToString() = "Card") Then
            cardnumber = InputBox("Insert Card Number:")
            cardname = InputBox("Insert Card Holder Name:")
            expirydate = InputBox("Insert Card Expirydate:")
            CVV = InputBox("Insert Card Security Code:")

            order.AppendLine("Name: " + TextBox1.Text)
            order.AppendLine("Phone No: " + TextBox2.Text)
            order.AppendLine("Email: " + TextBox3.Text)
            order.AppendLine("AddressLine: " + TextBox4.Text)
            order.AppendLine("City: " + TextBox5.Text)
            order.AppendLine("State: " + TextBox6.Text)
            order.AppendLine("Postcode: " + TextBox7.Text)
            order.AppendLine("Card Number: " + cardnumber)
            order.AppendLine("Card Holder Name: " + cardname)
            order.AppendLine("PaymentMethod: Card")
            order.AppendLine("")
            File.AppendAllText(filelocation2, order.ToString())
            MsgBox("Order placed!")


        ElseIf (Payment.SelectedItem.ToString() = "E-wallet") Then
            QRCODE.Show()
        ElseIf (Payment.SelectedItem.ToString() = "Cash") Then
            order.AppendLine("Name: " + TextBox1.Text)
            order.AppendLine("Phone No: " + TextBox2.Text)
            order.AppendLine("Email: " + TextBox3.Text)
            order.AppendLine("AddressLine: " + TextBox4.Text)
            order.AppendLine("City: " + TextBox5.Text)
            order.AppendLine("State: " + TextBox6.Text)
            order.AppendLine("Postcode: " + TextBox7.Text)
            order.AppendLine("PaymentMethod: Cash")
            order.AppendLine("")
            File.AppendAllText(filelocation2, order.ToString())
            MsgBox("Order placed!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Formfood.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class