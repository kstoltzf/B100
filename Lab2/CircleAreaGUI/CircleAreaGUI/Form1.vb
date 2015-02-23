Option Explicit On
Option Strict On

Public Class Form1

    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Dim radius, area, circumference As Double
        Const PI = 3.14159

        radius = CDbl(TextBox1.Text)

        area = PI * radius * radius
        circumference = 2 * PI * radius

        Label5.Text = CStr(area)
        Label6.Text = CStr(circumference)

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class
