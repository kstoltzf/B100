Option Strict On
Option Explicit On
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Dim totalCents, dollars, quarters, dimes, nickels, pennies As Integer
        totalCents = CInt(TextBox1.Text)

        dollars = totalCents \ 100
        quarters = (totalCents Mod 100) \ 25
        dimes = (totalCents Mod 25) \ 10
        nickels = ((totalCents Mod 25) Mod 10) \ 5
        pennies = totalCents Mod 5

        Label7.Text = CStr(dollars)
        Label8.Text = CStr(quarters)
        Label9.Text = CStr(dimes)
        Label10.Text = CStr(nickels)
        Label11.Text = CStr(pennies)

    End Sub
End Class
