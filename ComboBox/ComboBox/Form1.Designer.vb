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
        Me.BtnShowSelection = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.ComboBoxMake = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.ListBoxOutput = New System.Windows.Forms.ListBox()
        Me.LabelComboBox = New System.Windows.Forms.Label()
        Me.LabelListBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnShowSelection
        '
        Me.BtnShowSelection.Location = New System.Drawing.Point(12, 201)
        Me.BtnShowSelection.Name = "BtnShowSelection"
        Me.BtnShowSelection.Size = New System.Drawing.Size(121, 23)
        Me.BtnShowSelection.TabIndex = 0
        Me.BtnShowSelection.Text = "Show Selections ->"
        Me.BtnShowSelection.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(332, 189)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 46)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ComboBoxMake
        '
        Me.ComboBoxMake.FormattingEnabled = True
        Me.ComboBoxMake.Location = New System.Drawing.Point(12, 40)
        Me.ComboBoxMake.Name = "ComboBoxMake"
        Me.ComboBoxMake.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMake.TabIndex = 2
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(12, 78)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxModel.TabIndex = 3
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Location = New System.Drawing.Point(12, 115)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxColor.TabIndex = 4
        '
        'ListBoxOutput
        '
        Me.ListBoxOutput.FormattingEnabled = True
        Me.ListBoxOutput.Location = New System.Drawing.Point(177, 168)
        Me.ListBoxOutput.Name = "ListBoxOutput"
        Me.ListBoxOutput.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxOutput.TabIndex = 5
        '
        'LabelComboBox
        '
        Me.LabelComboBox.AutoSize = True
        Me.LabelComboBox.Location = New System.Drawing.Point(31, 24)
        Me.LabelComboBox.Name = "LabelComboBox"
        Me.LabelComboBox.Size = New System.Drawing.Size(102, 13)
        Me.LabelComboBox.TabIndex = 6
        Me.LabelComboBox.Text = "ComboBox Controls:"
        '
        'LabelListBox
        '
        Me.LabelListBox.AutoSize = True
        Me.LabelListBox.Location = New System.Drawing.Point(207, 152)
        Me.LabelListBox.Name = "LabelListBox"
        Me.LabelListBox.Size = New System.Drawing.Size(90, 13)
        Me.LabelListBox.TabIndex = 7
        Me.LabelListBox.Text = "A ListBox Control:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 275)
        Me.Controls.Add(Me.LabelListBox)
        Me.Controls.Add(Me.LabelComboBox)
        Me.Controls.Add(Me.ListBoxOutput)
        Me.Controls.Add(Me.ComboBoxColor)
        Me.Controls.Add(Me.ComboBoxModel)
        Me.Controls.Add(Me.ComboBoxMake)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnShowSelection)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnShowSelection As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents ComboBoxMake As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModel As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxColor As System.Windows.Forms.ComboBox
    Friend WithEvents ListBoxOutput As System.Windows.Forms.ListBox
    Friend WithEvents LabelComboBox As System.Windows.Forms.Label
    Friend WithEvents LabelListBox As System.Windows.Forms.Label

End Class
