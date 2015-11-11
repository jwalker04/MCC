Imports MCC.MCC_DEPTTableAdapters

Public Class frmInventory

    'Global Variables 
    Private ItemName As String
    Private ItemCollection As New Dictionary(Of String, String)

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MCC_DEPT.ITEM' table. You can move, or remove it, as needed.
        Me.ITEMTableAdapter.Fill(Me.MCC_DEPT.ITEM)

        ITEMTableAdapter.Fill(MCC_DEPT.ITEM)

        'Populate combo box
        FillComboBox()

    End Sub

    'Add Button Event
    'Creates a dictionary and adds it to the DB via Table Adaptor
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim ItemAdapter As New MCC_DEPTTableAdapters.ITEMTableAdapter
        Dim strElement As KeyValuePair(Of String, String) 'single element of a dictionary
        Dim intResult As Integer

        Call CreateItemCollectionInsert()

        'Loop through the dictionary
        For Each strElement In ItemCollection

            'If element of dictionary is empty then prompt for input from user and exit event
            If strElement.Value = String.Empty Then
                MessageBox.Show(strElement.Key & " is empty, fill it in and try again.")
                RemoveItemCollection()
                Exit Sub
            End If
        Next

        'Reserve name to add to combo box if insert is success
        ItemName = txtName.Text

        'Call insert method and return result of attempt
        intResult = ItemAdapter.InsertItem(txtName.Text, txtPrice.Text, txtQuantity.Text)

        'Check the insertion result (Fail = 0, Success = 1)
        If intResult = 0 Then
            MessageBox.Show("The Insert failed")
            Exit Sub
        Else

            MessageBox.Show("The Insert was successful")

            'Add the name of new Item to combo box if insert was successful
            cboName.Items.Add(ItemName)
        End If



    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim ItemAdapter As New MCC_DEPTTableAdapters.ITEMTableAdapter
        Dim strCheck As KeyValuePair(Of String, String) 'single element of a dictionary
        Dim intUpdate As Integer

        Call CreateItemCollectionInsert()

        'loop through the dictionary
        For Each strCheck In ItemCollection
            If strCheck.Value = String.Empty Then
                MessageBox.Show(strCheck.Key & " is empty, fill it in and try again.")
                RemoveItemCollection()
                Exit Sub
            End If
        Next

        'Reserve name for validation
        ItemName = txtName.Text

        intUpdate = ItemAdapter.UpdateItem(txtName.Text, txtPrice.Text, txtQuantity.Text, txtID.Text)

        'Check the insertion result
        If intUpdate = 0 Then
            MessageBox.Show("The Insert failed")
            Exit Sub
        Else
            MessageBox.Show("The Insert was successful")
        End If

        'insertion was successful
        cboName.Items.Add(ItemName) ' for validation

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim ItemAdapter As New MCC_DEPTTableAdapters.ITEMTableAdapter
        Dim dlgResult As DialogResult
        Dim intDelete As Integer

        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("ID Field is empty fill the text box and try again.")
            Exit Sub
        End If

        dlgResult = MessageBox.Show("Are you certain to delete this record?", "Delete", MessageBoxButtons.YesNo)

        If dlgResult = System.Windows.Forms.DialogResult.Yes Then
            intDelete = ITEMTableAdapter.DeleteItem(txtID.Text)

            If intDelete = 1 Then
                MessageBox.Show("Item deleted")
            Else
                MessageBox.Show("Item failed to delete")
                Exit Sub
            End If
        End If

        'Clear the Combobox
        cboName.Items.Clear()
        'Repopulate Combobox
        FillComboBox()

    End Sub

    'Method Name: LINQtoDATASet
    'Purpose: Using LINQ to data set technology to intergrate and improve data query
    'Parameters: None
    'Return: None
    'Change Log: MJ 9/25/15

    Private Sub LINQtoDATASet()

        'call the built -in fill method to get data'
        ITEMTableAdapter.Fill(MCC_DEPT.ITEM)
        'Build your query to get what you need
        Dim itemInfo = From ii In MCC_DEPT.ITEM
                       Where ii.Field(Of String)("ITEM_NAME").Equals(cboName.Text)
                       Select ii
        'execute the query
        For Each fRow In itemInfo
            txtID.Text = fRow.ITEM_ID
            txtName.Text = fRow.ITEM_NAME
            txtPrice.Text = fRow.ITEM_PRICE
            txtQuantity.Text = fRow.ITEM_QUANTITY

        Next
    End Sub

    'Method to fill combobox 
    Private Sub FillComboBox()

        Dim itemInfo = From ii In MCC_DEPT.ITEM
                       Select ii
        For Each fRow In itemInfo
            cboName.Items.Add(fRow.ITEM_NAME)
        Next
    End Sub

    Private Sub CreateItemCollection()
        ItemCollection.Add("ITEM_ID", txtID.Text)
        ItemCollection.Add("ITEM_NAME", txtName.Text)
        ItemCollection.Add("ITEM_PRICE", txtPrice.Text)
        ItemCollection.Add("ITEM_QUANTITY", txtQuantity.Text)
    End Sub

    'New Coillection when adding an item
    'Purposfully left out ID because it is auto-generated by the DB
    Private Sub CreateItemCollectionInsert()
        ItemCollection.Add("ITEM_NAME", txtName.Text)
        ItemCollection.Add("ITEM_PRICE", txtPrice.Text)
        ItemCollection.Add("ITEM_QUANTITY", txtQuantity.Text)
    End Sub

    Private Sub RemoveItemCollection()
        ItemCollection.Remove("ITEM_ID")
        ItemCollection.Remove("ITEM_NAME")
        ItemCollection.Remove("ITEM_PRICE")
        ItemCollection.Remove("ITEM_QUANTITY")
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim ItemAdapter As New MCC_DEPTTableAdapters.ITEMTableAdapter
        LINQtoDATASet()

        ItemAdapter.ClearBeforeFill() = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub


End Class