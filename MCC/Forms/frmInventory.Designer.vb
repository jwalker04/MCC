<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.MCC_DEPT = New MCC.MCC_DEPT()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.ITEMTableAdapter = New MCC.MCC_DEPTTableAdapters.ITEMTableAdapter()
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(288, 78)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(288, 107)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 136)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(109, 220)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Item Quantity:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(109, 104)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(109, 130)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 10
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(109, 156)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtQuantity.TabIndex = 11
        '
        'cboName
        '
        Me.cboName.DisplayMember = "ITEM_ID"
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(109, 27)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(121, 21)
        Me.cboName.TabIndex = 12
        Me.cboName.ValueMember = "ITEM_ID"
        '
        'MCC_DEPT
        '
        Me.MCC_DEPT.DataSetName = "MCC_DEPT"
        Me.MCC_DEPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(288, 25)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 13
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 15
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(35, 81)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(61, 13)
        Me.lblItemName.TabIndex = 14
        Me.lblItemName.Text = "Item Name:"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(288, 220)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 16
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'ITEMTableAdapter
        '
        Me.ITEMTableAdapter.ClearBeforeFill = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 283)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        CType(Me.MCC_DEPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents MCC_DEPT As MCC_DEPT
    Friend WithEvents ITEMTableAdapter As MCC_DEPTTableAdapters.ITEMTableAdapter
End Class
