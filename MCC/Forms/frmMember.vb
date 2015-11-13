Imports MCC.MCC_DEPTTableAdapters

Public Class frmMember
    Private MemberID As Integer
    Private MemberCollection As New Dictionary(Of String, String)

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MCC_DEPT.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.MCC_DEPT.MEMBER)

        'load all items on the combo box
        cboName.Items.Add("Bill Murray")
        cboName.Items.Add("Happy Gilmore")
        cboName.Items.Add("Bagger Vance")
        cboName.Items.Add("Shooter McGaven")
        cboName.Items.Add("Bob Barker")

        cboName.SelectedIndex = 0

        cboMethod.Items.Add("TableAdapter Method")
        cboMethod.Items.Add("LINQ & DataSet Method")
        cboMethod.Items.Add("TableAdapter Insert")
        cboMethod.Items.Add("TableAdapter DbDirect Method")
        cboMethod.Items.Add("TableAdapter.Update Method")
        cboMethod.Items.Add("TableAdapter Delete")
        cboMethod.SelectedIndex = 0

    End Sub

    ' Method Name:  LINQtoDataSet
    ' Purpose:      Using LINQ to DataSet technology to integrate and improve data query
    ' Parameters:   None
    ' Return:       None
    ' Change log:   K. Rashford 10/28/2015

    Private Sub LINQtoDataSet()
        'call the built-in method to get data
        MEMBERTableAdapter.Fill(MCC_DEPT.MEMBER)

        Dim MemberInfo = From mi In MCC_DEPT.MEMBER
                         Where mi.Field(Of String)("Name").Equals(cboName.Text)
                         Select mi
        'execute the query
        For Each mRow In MemberInfo
            TxtBoxID.Text = mRow.MEMBER_ID
            TxtBoxName.Text = mRow.MEMBER_NAME
            RichTxtBoxAddress.Text = mRow.MEMBER_ADDRESS
            TxtBoxEmail.Text = mRow.MEMBER_EMAIL
            TxtBoxPhoneNum.Text = mRow.MEMBER_PHONE
            TxtMemberCredit.Text = mRow.MEMBER_PROSHOP
            TxtBoxHandicap.Text = mRow.MEMBER_HANDICAP
        Next

    End Sub


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        'declare tableAdapter obj
        Dim MemberAdapter As New MCC_DEPTTableAdapters.MEMBERTableAdapter

        'the LINQ method is selected
        If cboMethod.Text = "LINQ & DataSet Method" Then
            LINQtoDataSet()
        Else
            MemberAdapter.ClearBeforeFill() = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim MemberAdapter As New MCC_DEPTTableAdapters.MEMBERTableAdapter
        Dim strCheck As KeyValuePair(Of String, String) 'single element of a dictionary
        Dim intInsert As Integer

        Call CreateMemberCollection()

        'loop through the dictionary
        For Each strCheck In MemberCollection
            If strCheck.Value = String.Empty Then
                MessageBox.Show(strCheck.Key & " is empty, continue?")
                RemoveMemberCollection()
                Exit Sub
            End If
        Next

        ' reserve the faculty name for validation
        Name = TxtBoxID.Text

        If cboMethod.Text = "TableAdapter Insert" Then
            'call the insert method
            intInsert = MemberAdapter.InsertMember(TxtBoxID.Text, TxtBoxName.Text, RichTxtBoxAddress.Text,
                                                     TxtBoxEmail.Text, TxtBoxPhoneNum.Text, TxtMemberCredit.Text, TxtBoxHandicap.Text)
        End If

        'check the insertion result
        If intInsert = 0 Then
            MessageBox.Show("The Insertion Failed")
            BtnAdd.Enabled = True
            Exit Sub
        End If

        'insertion was successful
        cboName.Items.Add(MemberID) ' for validation
        'disable the Insert button to disallow inserting the same data twice
        BtnAdd.Enabled = False

    End Sub

    Private Sub CreateMemberCollection()
        MemberCollection.Add("Member_ID", TxtBoxID.Text)
        MemberCollection.Add("Name", TxtBoxName.Text)
        MemberCollection.Add("Address", RichTxtBoxAddress.Text)
        MemberCollection.Add("Email", TxtBoxEmail.Text)
        MemberCollection.Add("Phone", TxtBoxPhoneNum.Text)
        MemberCollection.Add("Pro_Shop_Credit", TxtBoxPhoneNum.Text)
        MemberCollection.Add("Handicap", TxtBoxHandicap.Text)


    End Sub

    Private Sub RemoveMemberCollection()
        MemberCollection.Add("Member_ID", TxtBoxID.Text)
        MemberCollection.Add("Name", TxtBoxName.Text)
        MemberCollection.Add("Address", RichTxtBoxAddress.Text)
        MemberCollection.Add("Email", TxtBoxEmail.Text)
        MemberCollection.Add("Phone", TxtBoxPhoneNum.Text)
        MemberCollection.Add("Pro_Shop_Credit", TxtBoxPhoneNum.Text)
        MemberCollection.Add("Handicap", TxtBoxHandicap.Text)

    End Sub

    Private Sub BtnSelect_Click_1(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim MemberAdapter As New MCC_DEPTTableAdapters.MEMBERTableAdapter


        'the LINQ method is selected
        If cboMethod.Text = "LINQ & DataSet Method" Then
            LINQtoDataSet()
        Else
            MEMBERTableAdapter.ClearBeforeFill() = True

        End If

        MemberAdapter.ClearBeforeFill = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'create a tableAdapter object
        Dim MemberAdapter As New MCC_DEPTTableAdapters.MEMBERTableAdapter
        'create some variables
        Dim intUpdate As Integer

        If cboMethod.Text = "TableAdapter DbDirect Method" Then
            intUpdate = MemberAdapter.UpdateMember(TxtBoxName.Text, RichTxtBoxAddress.Text, TxtBoxEmail.Text, TxtBoxPhoneNum.Text,
                                                       TxtMemberCredit.Text, TxtBoxHandicap.Text, TxtBoxID.Text)
        Else
            'for another method

        End If
        ' reserve the updated faculty name
        cboName.Items.Add(TxtBoxName.Text)
        'check if update is successful
        If intUpdate = 0 Then
            MessageBox.Show("Faculty Table Update Failed!")
            Exit Sub
        Else
            MessageBox.Show("Faculty Table Updated!")
        End If
    End Sub

    'updateFacultyRow Method
    Private Function UpdateMemberRow(ByRef mRow As MCC_DEPT.MEMBERRow) As MCC_DEPT.MEMBERRow
        mRow.MEMBER_NAME = TxtBoxName.Text
        mRow.MEMBER_ADDRESS = RichTxtBoxAddress.Text
        mRow.MEMBER_EMAIL = TxtBoxEmail.Text
        mRow.MEMBER_PHONE = TxtBoxPhoneNum.Text
        mRow.MEMBER_PROSHOP = TxtMemberCredit.Text
        mRow.MEMBER_HANDICAP = TxtBoxHandicap.Text
        Return mRow
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim MemberAdapter As New MCC_DEPTTableAdapters.MEMBERTableAdapter
        Dim dlgResult As DialogResult
        Dim intDelete As Integer

        dlgResult = MessageBox.Show("Are you certain to delete this record?", "Delete", MessageBoxButtons.YesNo)

        If dlgResult = System.Windows.Forms.DialogResult.Yes Then
            If cboMethod.Text = "TableAdapter Delete" Then
                intDelete = MemberAdapter.DeleteMember(cboName.Text)

                If intDelete = 1 Then
                    MessageBox.Show("The member record has been deleted")
                Else
                    MessageBox.Show("Member Table Deleting failed")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Have you selected a Delete Method?")
            End If
        End If
    End Sub
End Class