<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.addtowishbtn = New System.Windows.Forms.Button()
        Me.newwish_tb = New System.Windows.Forms.TextBox()
        Me.newwish_lb = New System.Windows.Forms.Label()
        Me.selectwishcombo = New System.Windows.Forms.ComboBox()
        Me.selwish_lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addtowishbtn
        '
        Me.addtowishbtn.Location = New System.Drawing.Point(298, 52)
        Me.addtowishbtn.Name = "addtowishbtn"
        Me.addtowishbtn.Size = New System.Drawing.Size(91, 23)
        Me.addtowishbtn.TabIndex = 0
        Me.addtowishbtn.Text = "Add to Wishlist"
        Me.addtowishbtn.UseVisualStyleBackColor = True
        '
        'newwish_tb
        '
        Me.newwish_tb.Location = New System.Drawing.Point(82, 38)
        Me.newwish_tb.Name = "newwish_tb"
        Me.newwish_tb.Size = New System.Drawing.Size(210, 20)
        Me.newwish_tb.TabIndex = 1
        '
        'newwish_lb
        '
        Me.newwish_lb.AutoSize = True
        Me.newwish_lb.Location = New System.Drawing.Point(8, 41)
        Me.newwish_lb.Name = "newwish_lb"
        Me.newwish_lb.Size = New System.Drawing.Size(68, 13)
        Me.newwish_lb.TabIndex = 2
        Me.newwish_lb.Text = "New Wishlist"
        '
        'selectwishcombo
        '
        Me.selectwishcombo.FormattingEnabled = True
        Me.selectwishcombo.Location = New System.Drawing.Point(82, 74)
        Me.selectwishcombo.Name = "selectwishcombo"
        Me.selectwishcombo.Size = New System.Drawing.Size(210, 21)
        Me.selectwishcombo.TabIndex = 3
        '
        'selwish_lb
        '
        Me.selwish_lb.AutoSize = True
        Me.selwish_lb.Location = New System.Drawing.Point(0, 77)
        Me.selwish_lb.Name = "selwish_lb"
        Me.selwish_lb.Size = New System.Drawing.Size(76, 13)
        Me.selwish_lb.TabIndex = 4
        Me.selwish_lb.Text = "Select Wishlist"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 126)
        Me.Controls.Add(Me.selwish_lb)
        Me.Controls.Add(Me.selectwishcombo)
        Me.Controls.Add(Me.newwish_lb)
        Me.Controls.Add(Me.newwish_tb)
        Me.Controls.Add(Me.addtowishbtn)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addtowishbtn As System.Windows.Forms.Button
    Friend WithEvents newwish_tb As System.Windows.Forms.TextBox
    Friend WithEvents newwish_lb As System.Windows.Forms.Label
    Friend WithEvents selectwishcombo As System.Windows.Forms.ComboBox
    Friend WithEvents selwish_lb As System.Windows.Forms.Label
End Class
