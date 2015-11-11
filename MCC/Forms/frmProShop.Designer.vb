<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProShop
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
        Me.CboDiscountLevel = New System.Windows.Forms.ComboBox()
        Me.LblDiscount = New System.Windows.Forms.Label()
        Me.RbNonmember = New System.Windows.Forms.RadioButton()
        Me.RbMember = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbItems = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbTransaction = New System.Windows.Forms.GroupBox()
        Me.BtnSell = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblTax = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboDiscountLevel
        '
        Me.CboDiscountLevel.FormattingEnabled = True
        Me.CboDiscountLevel.Location = New System.Drawing.Point(479, 289)
        Me.CboDiscountLevel.Name = "CboDiscountLevel"
        Me.CboDiscountLevel.Size = New System.Drawing.Size(75, 21)
        Me.CboDiscountLevel.TabIndex = 28
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(476, 272)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(78, 13)
        Me.LblDiscount.TabIndex = 27
        Me.LblDiscount.Text = "Discount Level"
        '
        'RbNonmember
        '
        Me.RbNonmember.AutoSize = True
        Me.RbNonmember.Location = New System.Drawing.Point(384, 290)
        Me.RbNonmember.Name = "RbNonmember"
        Me.RbNonmember.Size = New System.Drawing.Size(86, 17)
        Me.RbNonmember.TabIndex = 25
        Me.RbNonmember.TabStop = True
        Me.RbNonmember.Text = "Non-Member"
        Me.RbNonmember.UseVisualStyleBackColor = True
        '
        'RbMember
        '
        Me.RbMember.AutoSize = True
        Me.RbMember.Location = New System.Drawing.Point(384, 270)
        Me.RbMember.Name = "RbMember"
        Me.RbMember.Size = New System.Drawing.Size(63, 17)
        Me.RbMember.TabIndex = 26
        Me.RbMember.TabStop = True
        Me.RbMember.Text = "Member"
        Me.RbMember.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(384, 350)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown1.TabIndex = 24
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(626, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(652, 349)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(20, 20)
        Me.BtnAdd.TabIndex = 23
        Me.BtnAdd.Text = "-"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(439, 350)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(181, 20)
        Me.TextBox7.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Lookup Item"
        '
        'LbItems
        '
        Me.LbItems.FormattingEnabled = True
        Me.LbItems.Location = New System.Drawing.Point(12, 12)
        Me.LbItems.Name = "LbItems"
        Me.LbItems.Size = New System.Drawing.Size(660, 225)
        Me.LbItems.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Qty"
        '
        'GbTransaction
        '
        Me.GbTransaction.Controls.Add(Me.BtnSell)
        Me.GbTransaction.Controls.Add(Me.TextBox3)
        Me.GbTransaction.Controls.Add(Me.LblSubtotal)
        Me.GbTransaction.Controls.Add(Me.TextBox2)
        Me.GbTransaction.Controls.Add(Me.BtnClear)
        Me.GbTransaction.Controls.Add(Me.BtnMenu)
        Me.GbTransaction.Controls.Add(Me.LblTotal)
        Me.GbTransaction.Controls.Add(Me.TextBox1)
        Me.GbTransaction.Controls.Add(Me.LblTax)
        Me.GbTransaction.Location = New System.Drawing.Point(8, 254)
        Me.GbTransaction.Name = "GbTransaction"
        Me.GbTransaction.Size = New System.Drawing.Size(344, 122)
        Me.GbTransaction.TabIndex = 18
        Me.GbTransaction.TabStop = False
        Me.GbTransaction.Text = "Transaction"
        '
        'BtnSell
        '
        Me.BtnSell.Location = New System.Drawing.Point(238, 16)
        Me.BtnSell.Name = "BtnSell"
        Me.BtnSell.Size = New System.Drawing.Size(100, 100)
        Me.BtnSell.TabIndex = 0
        Me.BtnSell.Text = "Sell"
        Me.BtnSell.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(67, 20)
        Me.TextBox3.TabIndex = 10
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Location = New System.Drawing.Point(4, 80)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.LblSubtotal.TabIndex = 5
        Me.LblSubtotal.Text = "Subtotal"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(67, 20)
        Me.TextBox2.TabIndex = 9
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(77, 19)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(50, 50)
        Me.BtnClear.TabIndex = 1
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(7, 19)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(50, 50)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(147, 80)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 4
        Me.LblTotal.Text = "Total"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 8
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Location = New System.Drawing.Point(74, 80)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(25, 13)
        Me.LblTax.TabIndex = 3
        Me.LblTax.Text = "Tax"
        '
        'frmProShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 388)
        Me.Controls.Add(Me.CboDiscountLevel)
        Me.Controls.Add(Me.LblDiscount)
        Me.Controls.Add(Me.RbNonmember)
        Me.Controls.Add(Me.RbMember)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GbTransaction)
        Me.Name = "frmProShop"
        Me.Text = "frmProShop"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbTransaction.ResumeLayout(False)
        Me.GbTransaction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboDiscountLevel As ComboBox
    Friend WithEvents LblDiscount As Label
    Friend WithEvents RbNonmember As RadioButton
    Friend WithEvents RbMember As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LbItems As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GbTransaction As GroupBox
    Friend WithEvents BtnSell As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblTax As Label
End Class
