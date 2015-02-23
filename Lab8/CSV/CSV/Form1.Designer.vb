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
        Me.BtnAddContact = New System.Windows.Forms.Button()
        Me.BtnViewContacts = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPhoneNumber = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ListBoxShowContacts = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Location = New System.Drawing.Point(387, 209)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(90, 23)
        Me.BtnAddContact.TabIndex = 0
        Me.BtnAddContact.Text = "Add Contact"
        Me.BtnAddContact.UseVisualStyleBackColor = True
        '
        'BtnViewContacts
        '
        Me.BtnViewContacts.Location = New System.Drawing.Point(387, 274)
        Me.BtnViewContacts.Name = "BtnViewContacts"
        Me.BtnViewContacts.Size = New System.Drawing.Size(90, 23)
        Me.BtnViewContacts.TabIndex = 1
        Me.BtnViewContacts.Text = "View Contacts"
        Me.BtnViewContacts.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(387, 333)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(90, 23)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(19, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(443, 26)
        Me.LblTitle.TabIndex = 3
        Me.LblTitle.Text = "Storing Data in a Comma Separated File"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(140, 64)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(35, 13)
        Me.LblName.TabIndex = 4
        Me.LblName.Text = "Name"
        '
        'LblPhoneNumber
        '
        Me.LblPhoneNumber.AutoSize = True
        Me.LblPhoneNumber.Location = New System.Drawing.Point(140, 106)
        Me.LblPhoneNumber.Name = "LblPhoneNumber"
        Me.LblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.LblPhoneNumber.TabIndex = 5
        Me.LblPhoneNumber.Text = "Phone Number"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(140, 147)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "Email"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(273, 61)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Location = New System.Drawing.Point(273, 106)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPhone.TabIndex = 8
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(273, 147)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmail.TabIndex = 9
        '
        'ListBoxShowContacts
        '
        Me.ListBoxShowContacts.FormattingEnabled = True
        Me.ListBoxShowContacts.Location = New System.Drawing.Point(24, 209)
        Me.ListBoxShowContacts.Name = "ListBoxShowContacts"
        Me.ListBoxShowContacts.Size = New System.Drawing.Size(349, 147)
        Me.ListBoxShowContacts.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 384)
        Me.Controls.Add(Me.ListBoxShowContacts)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxPhone)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblPhoneNumber)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnViewContacts)
        Me.Controls.Add(Me.BtnAddContact)
        Me.Name = "Form1"
        Me.Text = "CSV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddContact As System.Windows.Forms.Button
    Friend WithEvents BtnViewContacts As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPhone As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxShowContacts As System.Windows.Forms.ListBox

End Class
