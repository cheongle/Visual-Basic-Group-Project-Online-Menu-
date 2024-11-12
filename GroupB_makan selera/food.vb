Public Class Formfood
    Public food(6) As Integer
    Public foodprice() As Double = {6.5, 6.0, 6.0, 5.0, 6.5, 6.5}
    Public Total As Double
    Private Sub Formfood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If food(0) >= 0 And food(0) <= 10 Then
            If food(0) = 0 Then
                f1.Text = 0
            Else
                food(0) -= 1
                f1.Text = food(0)
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If food(1) >= 0 And food(1) < 10 Then
            food(1) += 1
            f2.Text = food(1)
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        If food(2) >= 0 And food(2) < 10 Then
            food(2) += 1
            f3.Text = food(2)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If food(3) >= 0 And food(3) < 10 Then
            food(3) += 1
            f4.Text = food(3)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        If food(4) >= 0 And food(4) < 10 Then
            food(4) += 1
            f5.Text = food(4)
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        If food(5) >= 0 And food(5) < 10 Then
            food(5) += 1
            f6.Text = food(5)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If food(1) >= 0 And food(1) <= 10 Then
            If food(1) = 0 Then
                f2.Text = 0
            Else
                food(1) -= 1
                f2.Text = food(1)
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If food(2) >= 0 And food(2) <= 10 Then
            If food(2) = 0 Then
                f3.Text = 0
            Else
                food(2) -= 1
                f3.Text = food(2)
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If food(3) >= 0 And food(3) <= 10 Then
            If food(3) = 0 Then
                f4.Text = 0
            Else
                food(3) -= 1
                f4.Text = food(3)
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If food(4) >= 0 And food(4) <= 10 Then
            If food(4) = 0 Then
                f5.Text = 0
            Else
                food(4) -= 1
                f5.Text = food(4)
            End If
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If food(5) >= 0 And food(5) <= 10 Then
            If food(5) = 0 Then
                f6.Text = 0
            Else
                food(5) -= 1
                f6.Text = food(5)
            End If
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim totaldrink, totalfood As Integer
        For i As Integer = 0 To 5
            totaldrink += FormDrink.drink(i)
            totalfood += food(i)
        Next
        If totaldrink = 0 And totalfood = 0 Then
            MsgBox("Please add somthing into cart first!")
        Else
            Me.Hide()
            checkout.Show()
        End If

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Me.Hide()
        loginRegister.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

        Me.Hide()
        FormDrink.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If food(0) >= 0 And food(0) < 10 Then
            food(0) += 1
            f1.Text = food(0)
        End If


    End Sub
End Class
