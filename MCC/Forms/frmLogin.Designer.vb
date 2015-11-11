<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MCC_DEPT = New MCC.MCC_DEPT()
        Me.LOGINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOGINTableAdapter = New MCC.MCC_DEPTTableAdapters.LOGINTableAdapter()
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(56, 118)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(53, 58)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(56, 84)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LOGINBindingSource, "USERNAME", True))
        Me.txtUserName.Location = New System.Drawing.Point(118, 55)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LOGINBindingSource, "USER_PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(118, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(138, 117)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MCC_DEPT
        '
        Me.MCC_DEPT.DataSetName = "MCC_DEPT"
        Me.MCC_DEPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LOGINBindingSource
        '
        Me.LOGINBindingSource.DataMember = "LOGIN"
        Me.LOGINBindingSource.DataSource = Me.MCC_DEPT
        '
        'LOGINTableAdapter
        '
        Me.LOGINTableAdapter.ClearBeforeFill = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 189)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents MCC_DEPT As MCC_DEPT
    Friend WithEvents LOGINBindingSource As BindingSource
    Friend WithEvents LOGINTableAdapter As MCC_DEPTTableAdapters.LOGINTableAdapter
End Class
