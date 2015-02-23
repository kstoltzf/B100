Option Explicit On
Option Strict On

Public Class Form1

    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        Close()
    End Sub

    Private Sub ButtonMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMap.Click
        Dim queryAddress As String

        queryAddress = "http://maps.google.com/maps?q="

        If TextBoxLatitude.Text <> String.Empty Then
            queryAddress = queryAddress & TextBoxLatitude.Text & ","
        End If

        If TextBoxLongitude.Text <> String.Empty Then
            queryAddress = queryAddress & TextBoxLongitude.Text
        End If

        MessageBox.Show(queryAddress)
        WebBrowser1.Navigate(queryAddress)

    End Sub
End Class
