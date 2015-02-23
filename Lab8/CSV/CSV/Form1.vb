Option Explicit On
Option Strict On
Imports System.IO  'Import the IO package so that we can do file I/O
Public Class Form1

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddContact.Click
        If TextBoxName.Text = "" Then
            MessageBox.Show("You must enter a name!", "Enter Name")
            TextBoxName.Focus()  'Put the focus (the cursor) in the Name Textbox
        ElseIf TextBoxPhone.Text = "" Then
            MessageBox.Show("You must enter a phone number!", "Enter Phone")
            TextBoxPhone.Focus()  'Put the focus (the cursor) in the Phone Textbox
        ElseIf TextBoxEmail.Text = "" Then
            MessageBox.Show("You must enter an email!", "Enter Email")
            TextBoxEmail.Focus()  'Put the focus (the cursor) in the Email Textbox
        Else
            Dim strNewLine As String

            'Concatenate the content of the three strings together and put it in a new string
            strNewLine = TextBoxName.Text.Trim & "," & TextBoxPhone.Text.Trim & "," & TextBoxEmail.Text.Trim
            Const append As Boolean = True

            'Open the file for writing (specifically for "Append" which means we are writing to the end of the file)
            Dim OutputFile As New StreamWriter("Contacts.txt", append)
            OutputFile.WriteLine(strNewLine)
            OutputFile.Close()

            TextBoxName.Clear()  'Clear the Textboxes after the writing
            TextBoxPhone.Clear()
            TextBoxEmail.Clear()
            TextBoxName.Focus()  'Put the focus (the cursor) in the Name Textbox

        End If
    End Sub

    Private Sub BtnViewContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewContacts.Click
        Try
            'Open the contacts.txt file for reading
            Dim InputFile As StreamReader = New StreamReader("Contacts.txt")
            Dim fmtStr As String = "{0, -20}{1, 15}{2, 25}"

            ListBoxShowContacts.Items.Clear()
            ListBoxShowContacts.Items.Add(String.Format(fmtStr, "Name", "Phone", "Email"))

            Dim strNewLine As String
            Dim strValues() As String  'array of strings

            Do Until InputFile.Peek() = -1
                strNewLine = InputFile.ReadLine()  'Read a line from the contacts.txt file
                'Split the input line into multiple strings
                'using the "," as the delimiter character
                strValues = Split(strNewLine, ",")
                ListBoxShowContacts.Items.Add(String.Format(fmtStr, strValues))  'Add the line to the ListBox
            Loop
            InputFile.Close()
        Catch
            MessageBox.Show("File could not be opened/found!", "I/O Error")
        End Try
    End Sub
End Class
