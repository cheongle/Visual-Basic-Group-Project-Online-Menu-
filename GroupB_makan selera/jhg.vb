Public Class FormDrink
    Public drink(6) As Integer
    Public drinkprice() As Double = {2, 1.5, 1.5, 2, 1.8, 2}
    Public total As Double

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If drink(1) >= 0 And drink(1) < 10 Then
            drink(1) += 1
            d2.Text = drink(1)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If drink(2) >= 0 And drink(2) < 10 Then
            drink(2) += 1
            d3.Text = drink(2)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If drink(3) >= 0 And drink(3) < 10 Then
            drink(3) += 1
            d4.Text = drink(3)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If drink(4) >= 0 And drink(4) < 10 Then
            drink(4) += 1
            d5.Text = drink(4)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If drink(5) >= 0 And drink(5) < 10 Then
            drink(5) += 1
            d6.Text = drink(5)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If drink(0) >= 0 And drink(0) <= 10 Then
            If drink(0) = 0 Then
                d1.Text = 0
            Else
                drink(0) -= 1
                d1.Text = drink(0)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If drink(1) >= 0 And drink(1) <= 10 Then
            If drink(1) = 0 Then
                d2.Text = 0
            Else
                drink(1) -= 1
                d2.Text = drink(1)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If drink(2) >= 0 And drink(2) <= 10 Then
            If drink(2) = 0 Then
                d3.Text = 0
            Else
                drink(2) -= 1
                d3.Text = drink(2)
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If drink(3) >= 0 And drink(3) <= 10 Then
            If drink(3) = 0 Then
                d4.Text = 0
            Else
                drink(3) -= 1
                d4.Text = drink(3)
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If drink(4) >= 0 And drink(4) <= 10 Then
            If drink(4) = 0 Then
                d5.Text = 0
            Else
                drink(4) -= 1
                d5.Text = drink(4)
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If drink(5) >= 0 And drink(5) <= 10 Then
            If drink(5) = 0 Then
                d6.Text = 0
            Else
                drink(5) -= 1
                d6.Text = drink(5)
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim totaldrink, totalfood As Integer
        For i As Integer = 0 To 5
            totaldrink += drink(i)
            totalfood += Formfood.food(i)
        Next
        If totaldrink = 0 And totalfood = 0 Then
            MsgBox("Please add somthing into cart first!")
        Else
            Me.Hide()
            checkout.Show()
        End If

    End Sub

    Private Sub FormDrink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Me.Hide()
        Formfood.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        loginRegister.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If drink(0) >= 0 And drink(0) < 10 Then
            drink(0) += 1
            d1.Text = drink(0)
        End If
    End Sub
End Class
