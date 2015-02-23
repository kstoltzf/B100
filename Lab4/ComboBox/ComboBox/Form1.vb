Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowSelection.Click
        ListBoxOutput.ClearSelected()  'Clear any selections from the ListBox
        ListBoxOutput.Items.Clear()    'Clear any items that may be in the Ouput ListBox

        'Get the ComboBox selections and add them to the Output ListBox
        Dim selectedItem As String
        If ComboBoxMake.SelectedIndex <> -1 Then
            selectedItem = CStr(ComboBoxMake.SelectedItem())
            ListBoxOutput.Items.Add(selectedItem)  'Add the Make to the Output ListBox
        End If

        If ComboBoxModel.SelectedIndex <> -1 Then
            selectedItem = CStr(ComboBoxModel.SelectedItem())
            ListBoxOutput.Items.Add(selectedItem)  'Add the Model to the Output ListBox
        End If

        If ComboBoxColor.SelectedIndex <> -1 Then
            selectedItem = CStr(ComboBoxColor.SelectedItem())
            ListBoxOutput.Items.Add(selectedItem)  'Add the Color to the Output ListBox
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize the text property of the three Combo Boxes to a NULL string
        ComboBoxMake.Text = ""
        ComboBoxModel.Text = ""
        ComboBoxColor.Text = ""

        'Add a number of cars to the "Make" ComboBox.
        ComboBoxMake.Items.Add("GMC")
        ComboBoxMake.Items.Add("Toyota")
        ComboBoxMake.Items.Add("Buick")
        ComboBoxMake.Items.Add("Kia")

    End Sub

    Private Sub ComboBoxMake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMake.SelectedIndexChanged
        ComboBoxModel.Text = ""                           'Initialize the text property to a NULL string
        ComboBoxModel.Items.Clear()                       'Clear all the items int the Model ComboBox collection
        ComboBoxColor.Text = ""      'Initialize the text property to a NULL string
        ComboBoxColor.Items.Clear()  'Clear all the items in the Color ComboBox collection

        Dim selectedItem As String
        selectedItem = CStr(ComboBoxMake.SelectedItem())  'Return the selected item from the ComboBox

        If selectedItem = "GMC" Then
            ComboBoxModel.Items.Add("Envoy")
            ComboBoxModel.Items.Add("Acadia")
            ComboBoxModel.Items.Add("Canyon")
            ComboBoxModel.Items.Add("Terrain")
            ComboBoxModel.Items.Add("Yukon")
        ElseIf selectedItem = "Toyota" Then
            ComboBoxModel.Items.Add("Camry")
            ComboBoxModel.Items.Add("Avalon")
            ComboBoxModel.Items.Add("4Runner")
        Else
            ComboBoxModel.Items.Add("Not Available")
        End If

    End Sub

    Private Sub ComboBoxColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxColor.SelectedIndexChanged
        
    End Sub

    Private Sub ComboBoxModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxModel.SelectedIndexChanged
        ComboBoxColor.Text = ""      'Initialize the text property to a NULL string
        ComboBoxColor.Items.Clear()  'Clear all the items in the Color ComboBox collection

        Dim selectedItem As String
        selectedItem = CStr(ComboBoxModel.SelectedItem())  'Return the selected item from the ComboBox

        If selectedItem = "Envoy" Then
            ComboBoxColor.Items.Add("Black")
            ComboBoxColor.Items.Add("Blue")
            ComboBoxColor.Items.Add("Red")
        ElseIf selectedItem = "Acadia" Then
            ComboBoxColor.Items.Add("White")
            ComboBoxColor.Items.Add("Black")
            ComboBoxColor.Items.Add("Red")
        ElseIf selectedItem = "Camry" Then
            ComboBoxColor.Items.Add("White")
            ComboBoxColor.Items.Add("Beige")
            ComboBoxColor.Items.Add("Silver")
        Else
            ComboBoxColor.Items.Add("Not Available")
        End If

    End Sub
End Class
