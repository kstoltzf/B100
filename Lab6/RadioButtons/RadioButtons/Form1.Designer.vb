Option Strict On
Option Explicit On

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
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelGroupBox = New System.Windows.Forms.Label()
        Me.LabelPictureBox = New System.Windows.Forms.Label()
        Me.GroupBoxCars = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.GroupBoxCars.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(64, 18)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(484, 31)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Welcome to MobiGreen Car Dealership"
        '
        'LabelGroupBox
        '
        Me.LabelGroupBox.AutoSize = True
        Me.LabelGroupBox.Location = New System.Drawing.Point(67, 108)
        Me.LabelGroupBox.Name = "LabelGroupBox"
        Me.LabelGroupBox.Size = New System.Drawing.Size(148, 13)
        Me.LabelGroupBox.TabIndex = 1
        Me.LabelGroupBox.Text = "Group Box and Radio Buttons"
        '
        'LabelPictureBox
        '
        Me.LabelPictureBox.AutoSize = True
        Me.LabelPictureBox.Location = New System.Drawing.Point(355, 108)
        Me.LabelPictureBox.Name = "LabelPictureBox"
        Me.LabelPictureBox.Size = New System.Drawing.Size(61, 13)
        Me.LabelPictureBox.TabIndex = 2
        Me.LabelPictureBox.Text = "Picture Box"
        '
        'GroupBoxCars
        '
        Me.GroupBoxCars.Controls.Add(Me.RadioButton3)
        Me.GroupBoxCars.Controls.Add(Me.RadioButton2)
        Me.GroupBoxCars.Controls.Add(Me.RadioButton1)
        Me.GroupBoxCars.Location = New System.Drawing.Point(70, 164)
        Me.GroupBoxCars.Name = "GroupBoxCars"
        Me.GroupBoxCars.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxCars.TabIndex = 3
        Me.GroupBoxCars.TabStop = False
        Me.GroupBoxCars.Text = "Cars"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(53, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3rd Car"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(53, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2nd Car"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(53, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1st Car"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(358, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 221)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(70, 322)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(200, 23)
        Me.ButtonQuit.TabIndex = 5
        Me.ButtonQuit.Text = "Quit"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 357)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBoxCars)
        Me.Controls.Add(Me.LabelPictureBox)
        Me.Controls.Add(Me.LabelGroupBox)
        Me.Controls.Add(Me.LabelTitle)
        Me.Name = "Form1"
        Me.Text = "ReaLemon Dealership"
        Me.GroupBoxCars.ResumeLayout(False)
        Me.GroupBoxCars.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelGroupBox As System.Windows.Forms.Label
    Friend WithEvents LabelPictureBox As System.Windows.Forms.Label
    Friend WithEvents GroupBoxCars As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button

    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        Close()
    End Sub
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("O:\B100\Cars\LeafEC.jpg")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("O:\B100\Cars\TeslaEC.jpg")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("O:\B100\Cars\VoltEC.jpg")
    End Sub
End Class
