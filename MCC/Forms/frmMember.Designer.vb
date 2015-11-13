<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.RichTxtBoxAddress = New System.Windows.Forms.RichTextBox()
        Me.TxtBoxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMethod = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtBoxHandicap = New System.Windows.Forms.TextBox()
        Me.TxtMemberCredit = New System.Windows.Forms.TextBox()
        Me.TxtBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.lblMemberHandicap = New System.Windows.Forms.Label()
        Me.LblMemberCredit = New System.Windows.Forms.Label()
        Me.lblMemberPhone = New System.Windows.Forms.Label()
        Me.LblMemberEmail = New System.Windows.Forms.Label()
        Me.lblMemberAdress = New System.Windows.Forms.Label()
        Me.TxtBoxID = New System.Windows.Forms.TextBox()
        Me.LblMemberName = New System.Windows.Forms.Label()
        Me.MCC_DEPT = New MCC.MCC_DEPT()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERTableAdapter = New MCC.MCC_DEPTTableAdapters.MEMBERTableAdapter()
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(400, 126)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 49)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(308, 126)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(59, 49)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'RichTxtBoxAddress
        '
        Me.RichTxtBoxAddress.Location = New System.Drawing.Point(115, 102)
        Me.RichTxtBoxAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTxtBoxAddress.Name = "RichTxtBoxAddress"
        Me.RichTxtBoxAddress.Size = New System.Drawing.Size(101, 32)
        Me.RichTxtBoxAddress.TabIndex = 46
        Me.RichTxtBoxAddress.Text = ""
        '
        'TxtBoxName
        '
        Me.TxtBoxName.Location = New System.Drawing.Point(308, 73)
        Me.TxtBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxName.Name = "TxtBoxName"
        Me.TxtBoxName.Size = New System.Drawing.Size(88, 20)
        Me.TxtBoxName.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Name:"
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(234, 180)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(56, 47)
        Me.BtnSelect.TabIndex = 43
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Query Method"
        '
        'cboMethod
        '
        Me.cboMethod.FormattingEnabled = True
        Me.cboMethod.Location = New System.Drawing.Point(308, 38)
        Me.cboMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.Size = New System.Drawing.Size(160, 21)
        Me.cboMethod.TabIndex = 41
        '
        'cboName
        '
        Me.cboName.DataSource = Me.MEMBERBindingSource
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(117, 38)
        Me.cboName.Margin = New System.Windows.Forms.Padding(2)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(99, 21)
        Me.cboName.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Member ID:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(234, 126)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(56, 49)
        Me.BtnAdd.TabIndex = 38
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(241, 313)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 25)
        Me.BtnExit.TabIndex = 37
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtBoxHandicap
        '
        Me.TxtBoxHandicap.Location = New System.Drawing.Point(117, 250)
        Me.TxtBoxHandicap.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxHandicap.Name = "TxtBoxHandicap"
        Me.TxtBoxHandicap.Size = New System.Drawing.Size(99, 20)
        Me.TxtBoxHandicap.TabIndex = 36
        '
        'TxtMemberCredit
        '
        Me.TxtMemberCredit.Location = New System.Drawing.Point(117, 214)
        Me.TxtMemberCredit.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMemberCredit.Name = "TxtMemberCredit"
        Me.TxtMemberCredit.Size = New System.Drawing.Size(99, 20)
        Me.TxtMemberCredit.TabIndex = 35
        '
        'TxtBoxPhoneNum
        '
        Me.TxtBoxPhoneNum.Location = New System.Drawing.Point(117, 180)
        Me.TxtBoxPhoneNum.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxPhoneNum.Name = "TxtBoxPhoneNum"
        Me.TxtBoxPhoneNum.Size = New System.Drawing.Size(99, 20)
        Me.TxtBoxPhoneNum.TabIndex = 34
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(117, 150)
        Me.TxtBoxEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(99, 20)
        Me.TxtBoxEmail.TabIndex = 33
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Location = New System.Drawing.Point(117, 314)
        Me.BtnMainMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(68, 24)
        Me.BtnMainMenu.TabIndex = 32
        Me.BtnMainMenu.Text = "&Main Menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'lblMemberHandicap
        '
        Me.lblMemberHandicap.AutoSize = True
        Me.lblMemberHandicap.Location = New System.Drawing.Point(29, 254)
        Me.lblMemberHandicap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemberHandicap.Name = "lblMemberHandicap"
        Me.lblMemberHandicap.Size = New System.Drawing.Size(56, 13)
        Me.lblMemberHandicap.TabIndex = 31
        Me.lblMemberHandicap.Text = "Handicap:"
        '
        'LblMemberCredit
        '
        Me.LblMemberCredit.AutoSize = True
        Me.LblMemberCredit.Location = New System.Drawing.Point(29, 219)
        Me.LblMemberCredit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMemberCredit.Name = "LblMemberCredit"
        Me.LblMemberCredit.Size = New System.Drawing.Size(84, 13)
        Me.LblMemberCredit.TabIndex = 30
        Me.LblMemberCredit.Text = "Pro Shop Credit:"
        '
        'lblMemberPhone
        '
        Me.lblMemberPhone.AutoSize = True
        Me.lblMemberPhone.Location = New System.Drawing.Point(29, 184)
        Me.lblMemberPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemberPhone.Name = "lblMemberPhone"
        Me.lblMemberPhone.Size = New System.Drawing.Size(81, 13)
        Me.lblMemberPhone.TabIndex = 29
        Me.lblMemberPhone.Text = "Phone Number:"
        '
        'LblMemberEmail
        '
        Me.LblMemberEmail.AutoSize = True
        Me.LblMemberEmail.Location = New System.Drawing.Point(29, 161)
        Me.LblMemberEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMemberEmail.Name = "LblMemberEmail"
        Me.LblMemberEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblMemberEmail.TabIndex = 28
        Me.LblMemberEmail.Text = "Email"
        '
        'lblMemberAdress
        '
        Me.lblMemberAdress.AutoSize = True
        Me.lblMemberAdress.Location = New System.Drawing.Point(29, 109)
        Me.lblMemberAdress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemberAdress.Name = "lblMemberAdress"
        Me.lblMemberAdress.Size = New System.Drawing.Size(48, 13)
        Me.lblMemberAdress.TabIndex = 27
        Me.lblMemberAdress.Text = "Address:"
        '
        'TxtBoxID
        '
        Me.TxtBoxID.Location = New System.Drawing.Point(117, 69)
        Me.TxtBoxID.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxID.Name = "TxtBoxID"
        Me.TxtBoxID.Size = New System.Drawing.Size(99, 20)
        Me.TxtBoxID.TabIndex = 26
        '
        'LblMemberName
        '
        Me.LblMemberName.AutoSize = True
        Me.LblMemberName.Location = New System.Drawing.Point(29, 43)
        Me.LblMemberName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMemberName.Name = "LblMemberName"
        Me.LblMemberName.Size = New System.Drawing.Size(79, 13)
        Me.LblMemberName.TabIndex = 25
        Me.LblMemberName.Text = "Member Name:"
        '
        'MCC_DEPT
        '
        Me.MCC_DEPT.DataSetName = "MCC_DEPT"
        Me.MCC_DEPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.MCC_DEPT
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 376)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.RichTxtBoxAddress)
        Me.Controls.Add(Me.TxtBoxName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMethod)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtBoxHandicap)
        Me.Controls.Add(Me.TxtMemberCredit)
        Me.Controls.Add(Me.TxtBoxPhoneNum)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Controls.Add(Me.lblMemberHandicap)
        Me.Controls.Add(Me.LblMemberCredit)
        Me.Controls.Add(Me.lblMemberPhone)
        Me.Controls.Add(Me.LblMemberEmail)
        Me.Controls.Add(Me.lblMemberAdress)
        Me.Controls.Add(Me.TxtBoxID)
        Me.Controls.Add(Me.LblMemberName)
        Me.Name = "frmMember"
        Me.Text = "frmMember"
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents RichTxtBoxAddress As RichTextBox
    Friend WithEvents TxtBoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSelect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMethod As ComboBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtBoxHandicap As TextBox
    Friend WithEvents TxtMemberCredit As TextBox
    Friend WithEvents TxtBoxPhoneNum As TextBox
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents lblMemberHandicap As Label
    Friend WithEvents LblMemberCredit As Label
    Friend WithEvents lblMemberPhone As Label
    Friend WithEvents LblMemberEmail As Label
    Friend WithEvents lblMemberAdress As Label
    Friend WithEvents TxtBoxID As TextBox
    Friend WithEvents LblMemberName As Label
    Friend WithEvents MCC_DEPT As MCC_DEPT
    Friend WithEvents MEMBERBindingSource As BindingSource
    Friend WithEvents MEMBERTableAdapter As MCC_DEPTTableAdapters.MEMBERTableAdapter
End Class
