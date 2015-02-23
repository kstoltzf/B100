Option Strict On
Option Explicit On

Public Class Form1

    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        Close()
    End Sub

    Private Sub BtnPlayVideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlayVideo.Click
        MyMediaPlayer.stretchToFit = True
        MyMediaPlayer.URL = TextboxSource.Text

    End Sub

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Open File Dialog"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Windows video/audio files (*.avi;*.wmv;*.wma;*.swf;*.mp3)|*.avi;*.wmv;*.wma;*.swf;*.mp3"

        fdlg.RestoreDirectory = True  'Restore the current directory to InitialDirectory

        If fdlg.ShowDialog() = DialogResult.OK Then
            TextboxSource.Text = fdlg.FileName  'Copy the filepath from the filedialog into the textbox
        End If

    End Sub
End Class
