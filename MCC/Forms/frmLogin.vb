Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' declare 2 objects
        'Dim LoginAdapter As New MCC_DEPTDataSetTableAdapters.LOGINTableAdapter
        Dim LoginAdapter As New MCC_DEPTTableAdapters.LOGINTableAdapter

        ' clean up the Login table before filling up
        LoginAdapter.ClearBeforeFill = True
        ' call the method we modified to pass user input
        LoginAdapter.FillByUserNamePassword(MCC_DEPT.LOGIN, txtUserName.Text, txtPassword.Text)

        ' check if input match our data
        If MCC_DEPT.LOGIN.Count = 0 Then
            MessageBox.Show("No Matching data found.", "Login Failure")
            Exit Sub
        End If
        selForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class