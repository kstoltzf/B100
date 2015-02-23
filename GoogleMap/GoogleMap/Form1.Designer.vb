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
        Me.ButtonMap = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelLat = New System.Windows.Forms.Label()
        Me.LabelLong = New System.Windows.Forms.Label()
        Me.TextBoxLatitude = New System.Windows.Forms.TextBox()
        Me.TextBoxLongitude = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'ButtonMap
        '
        Me.ButtonMap.Location = New System.Drawing.Point(615, 43)
        Me.ButtonMap.Name = "ButtonMap"
        Me.ButtonMap.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMap.TabIndex = 0
        Me.ButtonMap.Text = "Show Map"
        Me.ButtonMap.UseVisualStyleBackColor = True
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(788, 44)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuit.TabIndex = 1
        Me.ButtonQuit.Text = "Quit"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(354, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(216, 20)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Text = "Interacting with Google Maps"
        '
        'LabelLat
        '
        Me.LabelLat.AutoSize = True
        Me.LabelLat.Location = New System.Drawing.Point(0, 49)
        Me.LabelLat.Name = "LabelLat"
        Me.LabelLat.Size = New System.Drawing.Size(48, 13)
        Me.LabelLat.TabIndex = 3
        Me.LabelLat.Text = "Latitude:"
        '
        'LabelLong
        '
        Me.LabelLong.AutoSize = True
        Me.LabelLong.Location = New System.Drawing.Point(263, 49)
        Me.LabelLong.Name = "LabelLong"
        Me.LabelLong.Size = New System.Drawing.Size(57, 13)
        Me.LabelLong.TabIndex = 4
        Me.LabelLong.Text = "Longitude:"
        '
        'TextBoxLatitude
        '
        Me.TextBoxLatitude.Location = New System.Drawing.Point(54, 45)
        Me.TextBoxLatitude.Name = "TextBoxLatitude"
        Me.TextBoxLatitude.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLatitude.TabIndex = 5
        '
        'TextBoxLongitude
        '
        Me.TextBoxLongitude.Location = New System.Drawing.Point(326, 46)
        Me.TextBoxLongitude.Name = "TextBoxLongitude"
        Me.TextBoxLongitude.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLongitude.TabIndex = 6
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 92)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(892, 402)
        Me.WebBrowser1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 506)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.TextBoxLongitude)
        Me.Controls.Add(Me.TextBoxLatitude)
        Me.Controls.Add(Me.LabelLong)
        Me.Controls.Add(Me.LabelLat)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.ButtonMap)
        Me.Name = "Form1"
        Me.Text = "Google Map"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonMap As System.Windows.Forms.Button
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelLat As System.Windows.Forms.Label
    Friend WithEvents LabelLong As System.Windows.Forms.Label
    Friend WithEvents TextBoxLatitude As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLongitude As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
