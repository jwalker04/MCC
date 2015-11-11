<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisc
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPromo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(200, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "More Utiliities"
        '
        'btnPromo
        '
        Me.btnPromo.Location = New System.Drawing.Point(27, 108)
        Me.btnPromo.Name = "btnPromo"
        Me.btnPromo.Size = New System.Drawing.Size(99, 55)
        Me.btnPromo.TabIndex = 2
        Me.btnPromo.Text = "Promo Messages"
        Me.btnPromo.UseVisualStyleBackColor = True
        '
        'frmMisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 436)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnPromo)
        Me.Name = "frmMisc"
        Me.Text = "frmMisc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPromo As Button
End Class
