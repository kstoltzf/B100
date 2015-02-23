<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnPlayVideo = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.LabelSource = New System.Windows.Forms.Label()
        Me.TextboxSource = New System.Windows.Forms.TextBox()
        Me.MyMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.MyMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(478, 48)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 0
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnPlayVideo
        '
        Me.BtnPlayVideo.Location = New System.Drawing.Point(478, 141)
        Me.BtnPlayVideo.Name = "BtnPlayVideo"
        Me.BtnPlayVideo.Size = New System.Drawing.Size(75, 23)
        Me.BtnPlayVideo.TabIndex = 1
        Me.BtnPlayVideo.Text = "Play Video"
        Me.BtnPlayVideo.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(478, 246)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuit.TabIndex = 2
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'LabelSource
        '
        Me.LabelSource.AutoSize = True
        Me.LabelSource.Location = New System.Drawing.Point(26, 25)
        Me.LabelSource.Name = "LabelSource"
        Me.LabelSource.Size = New System.Drawing.Size(103, 13)
        Me.LabelSource.TabIndex = 3
        Me.LabelSource.Text = "Source (File or URL)"
        '
        'TextboxSource
        '
        Me.TextboxSource.Location = New System.Drawing.Point(29, 51)
        Me.TextboxSource.Name = "TextboxSource"
        Me.TextboxSource.Size = New System.Drawing.Size(368, 20)
        Me.TextboxSource.TabIndex = 4
        '
        'MyMediaPlayer
        '
        Me.MyMediaPlayer.Enabled = True
        Me.MyMediaPlayer.Location = New System.Drawing.Point(29, 77)
        Me.MyMediaPlayer.Name = "MyMediaPlayer"
        Me.MyMediaPlayer.OcxState = CType(resources.GetObject("MyMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MyMediaPlayer.Size = New System.Drawing.Size(368, 219)
        Me.MyMediaPlayer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 308)
        Me.Controls.Add(Me.MyMediaPlayer)
        Me.Controls.Add(Me.TextboxSource)
        Me.Controls.Add(Me.LabelSource)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnPlayVideo)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Name = "Form1"
        Me.Text = "My Video Player"
        CType(Me.MyMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnPlayVideo As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents LabelSource As System.Windows.Forms.Label
    Friend WithEvents TextboxSource As System.Windows.Forms.TextBox
    Friend WithEvents MyMediaPlayer As AxWMPLib.AxWindowsMediaPlayer

End Class
