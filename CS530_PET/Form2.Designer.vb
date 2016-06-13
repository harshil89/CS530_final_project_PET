<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.fname_tb = New System.Windows.Forms.TextBox()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lname_tb = New System.Windows.Forms.TextBox()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.passbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(174, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Register"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Username*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Password*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Email*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "First_Name*"
        '
        'password_tb
        '
        Me.password_tb.Location = New System.Drawing.Point(97, 133)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(190, 20)
        Me.password_tb.TabIndex = 4
        '
        'username_tb
        '
        Me.username_tb.Location = New System.Drawing.Point(97, 107)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(293, 20)
        Me.username_tb.TabIndex = 3
        '
        'fname_tb
        '
        Me.fname_tb.Location = New System.Drawing.Point(97, 55)
        Me.fname_tb.Name = "fname_tb"
        Me.fname_tb.Size = New System.Drawing.Size(293, 20)
        Me.fname_tb.TabIndex = 1
        '
        'regbtn
        '
        Me.regbtn.Location = New System.Drawing.Point(200, 200)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(87, 21)
        Me.regbtn.TabIndex = 7
        Me.regbtn.Text = "Register"
        Me.regbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(303, 200)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(87, 21)
        Me.cancelbtn.TabIndex = 25
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Last_Name*"
        '
        'lname_tb
        '
        Me.lname_tb.Location = New System.Drawing.Point(97, 81)
        Me.lname_tb.Name = "lname_tb"
        Me.lname_tb.Size = New System.Drawing.Size(293, 20)
        Me.lname_tb.TabIndex = 2
        '
        'email_tb
        '
        Me.email_tb.Location = New System.Drawing.Point(97, 159)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(293, 20)
        Me.email_tb.TabIndex = 6
        '
        'passbtn
        '
        Me.passbtn.Location = New System.Drawing.Point(293, 132)
        Me.passbtn.Name = "passbtn"
        Me.passbtn.Size = New System.Drawing.Size(101, 21)
        Me.passbtn.TabIndex = 5
        Me.passbtn.Text = "Show Password"
        Me.passbtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 268)
        Me.Controls.Add(Me.passbtn)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lname_tb)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.fname_tb)
        Me.Controls.Add(Me.regbtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents fname_tb As System.Windows.Forms.TextBox
    Friend WithEvents regbtn As System.Windows.Forms.Button
    Friend WithEvents cancelbtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lname_tb As System.Windows.Forms.TextBox
    Friend WithEvents email_tb As System.Windows.Forms.TextBox
    Friend WithEvents passbtn As System.Windows.Forms.Button
End Class
