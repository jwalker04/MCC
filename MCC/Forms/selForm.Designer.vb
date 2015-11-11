<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selForm
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(197, 226)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 0
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Location = New System.Drawing.Point(45, 41)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(75, 23)
        Me.btnItems.TabIndex = 1
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'selForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnLogOut)
        Me.Name = "selForm"
        Me.Text = "selForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnItems As Button
End Class
