<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.user_tb = New System.Windows.Forms.TextBox()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.userStatusLabel = New System.Windows.Forms.Label()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.wishlistcombo = New System.Windows.Forms.ComboBox()
        Me.viewhistbtn = New System.Windows.Forms.Button()
        Me.title_lb = New System.Windows.Forms.Label()
        Me.year_lb = New System.Windows.Forms.Label()
        Me.language_lb = New System.Windows.Forms.Label()
        Me.runtime_lb = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.wishlistbtn = New System.Windows.Forms.Button()
        Me.addhistbtn = New System.Windows.Forms.Button()
        Me.returnbtn = New System.Windows.Forms.Button()
        Me.wishlist_lb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.loadwishbtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user_tb
        '
        Me.user_tb.Location = New System.Drawing.Point(363, 22)
        Me.user_tb.Name = "user_tb"
        Me.user_tb.Size = New System.Drawing.Size(100, 20)
        Me.user_tb.TabIndex = 0
        '
        'password_tb
        '
        Me.password_tb.Location = New System.Drawing.Point(469, 22)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tb.Size = New System.Drawing.Size(100, 20)
        Me.password_tb.TabIndex = 1
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(575, 20)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'regbtn
        '
        Me.regbtn.Location = New System.Drawing.Point(656, 20)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(75, 23)
        Me.regbtn.TabIndex = 3
        Me.regbtn.Text = "Register"
        Me.regbtn.UseVisualStyleBackColor = True
        '
        'username_tb
        '
        Me.username_tb.Location = New System.Drawing.Point(10, 10)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(100, 20)
        Me.username_tb.TabIndex = 0
        '
        'userStatusLabel
        '
        Me.userStatusLabel.AutoSize = True
        Me.userStatusLabel.Location = New System.Drawing.Point(520, 25)
        Me.userStatusLabel.Name = "userStatusLabel"
        Me.userStatusLabel.Size = New System.Drawing.Size(49, 13)
        Me.userStatusLabel.TabIndex = 4
        Me.userStatusLabel.Text = "welcome"
        '
        'logoutbtn
        '
        Me.logoutbtn.Location = New System.Drawing.Point(650, 20)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(75, 23)
        Me.logoutbtn.TabIndex = 5
        Me.logoutbtn.Text = "Log Out"
        Me.logoutbtn.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(360, 4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 6
        Me.Username.Text = "Username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(466, 4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(53, 13)
        Me.password.TabIndex = 7
        Me.password.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search"
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(162, 20)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 9
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'search_tb
        '
        Me.search_tb.Location = New System.Drawing.Point(15, 22)
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(141, 20)
        Me.search_tb.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(719, 296)
        Me.DataGridView1.TabIndex = 11
        '
        'wishlistcombo
        '
        Me.wishlistcombo.FormattingEnabled = True
        Me.wishlistcombo.Location = New System.Drawing.Point(363, 77)
        Me.wishlistcombo.Name = "wishlistcombo"
        Me.wishlistcombo.Size = New System.Drawing.Size(180, 21)
        Me.wishlistcombo.TabIndex = 12
        '
        'viewhistbtn
        '
        Me.viewhistbtn.Location = New System.Drawing.Point(656, 75)
        Me.viewhistbtn.Name = "viewhistbtn"
        Me.viewhistbtn.Size = New System.Drawing.Size(75, 23)
        Me.viewhistbtn.TabIndex = 13
        Me.viewhistbtn.Text = "View History"
        Me.viewhistbtn.UseVisualStyleBackColor = True
        '
        'title_lb
        '
        Me.title_lb.AutoSize = True
        Me.title_lb.Location = New System.Drawing.Point(159, 146)
        Me.title_lb.Name = "title_lb"
        Me.title_lb.Size = New System.Drawing.Size(27, 13)
        Me.title_lb.TabIndex = 14
        Me.title_lb.Text = "Title"
        '
        'year_lb
        '
        Me.year_lb.AutoSize = True
        Me.year_lb.Location = New System.Drawing.Point(159, 171)
        Me.year_lb.Name = "year_lb"
        Me.year_lb.Size = New System.Drawing.Size(29, 13)
        Me.year_lb.TabIndex = 15
        Me.year_lb.Text = "Year"
        '
        'language_lb
        '
        Me.language_lb.AutoSize = True
        Me.language_lb.Location = New System.Drawing.Point(159, 195)
        Me.language_lb.Name = "language_lb"
        Me.language_lb.Size = New System.Drawing.Size(55, 13)
        Me.language_lb.TabIndex = 16
        Me.language_lb.Text = "Language"
        '
        'runtime_lb
        '
        Me.runtime_lb.AutoSize = True
        Me.runtime_lb.Location = New System.Drawing.Point(159, 221)
        Me.runtime_lb.Name = "runtime_lb"
        Me.runtime_lb.Size = New System.Drawing.Size(41, 13)
        Me.runtime_lb.TabIndex = 17
        Me.runtime_lb.Text = "runtime"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 245)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(719, 169)
        Me.DataGridView2.TabIndex = 18
        '
        'wishlistbtn
        '
        Me.wishlistbtn.Location = New System.Drawing.Point(523, 75)
        Me.wishlistbtn.Name = "wishlistbtn"
        Me.wishlistbtn.Size = New System.Drawing.Size(99, 23)
        Me.wishlistbtn.TabIndex = 19
        Me.wishlistbtn.Text = "Add to Wishlist"
        Me.wishlistbtn.UseVisualStyleBackColor = True
        '
        'addhistbtn
        '
        Me.addhistbtn.Location = New System.Drawing.Point(632, 75)
        Me.addhistbtn.Name = "addhistbtn"
        Me.addhistbtn.Size = New System.Drawing.Size(99, 23)
        Me.addhistbtn.TabIndex = 20
        Me.addhistbtn.Text = "Add To History"
        Me.addhistbtn.UseVisualStyleBackColor = True
        '
        'returnbtn
        '
        Me.returnbtn.Location = New System.Drawing.Point(407, 75)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(99, 23)
        Me.returnbtn.TabIndex = 21
        Me.returnbtn.Text = "Return"
        Me.returnbtn.UseVisualStyleBackColor = True
        '
        'wishlist_lb
        '
        Me.wishlist_lb.AutoSize = True
        Me.wishlist_lb.Location = New System.Drawing.Point(360, 61)
        Me.wishlist_lb.Name = "wishlist_lb"
        Me.wishlist_lb.Size = New System.Drawing.Size(71, 13)
        Me.wishlist_lb.TabIndex = 22
        Me.wishlist_lb.Text = "select wishlist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "runtime :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Language :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Year :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Title :"
        '
        'loadwishbtn
        '
        Me.loadwishbtn.Location = New System.Drawing.Point(561, 75)
        Me.loadwishbtn.Name = "loadwishbtn"
        Me.loadwishbtn.Size = New System.Drawing.Size(75, 23)
        Me.loadwishbtn.TabIndex = 27
        Me.loadwishbtn.Text = "Load wishlist"
        Me.loadwishbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Location = New System.Drawing.Point(260, 20)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 28
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 426)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.loadwishbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.wishlist_lb)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.addhistbtn)
        Me.Controls.Add(Me.wishlistbtn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.runtime_lb)
        Me.Controls.Add(Me.language_lb)
        Me.Controls.Add(Me.year_lb)
        Me.Controls.Add(Me.title_lb)
        Me.Controls.Add(Me.viewhistbtn)
        Me.Controls.Add(Me.wishlistcombo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.search_tb)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.userStatusLabel)
        Me.Controls.Add(Me.regbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.user_tb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user_tb As System.Windows.Forms.TextBox
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents loginbtn As System.Windows.Forms.Button
    Friend WithEvents regbtn As System.Windows.Forms.Button
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents userStatusLabel As System.Windows.Forms.Label
    Friend WithEvents logoutbtn As System.Windows.Forms.Button
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchbtn As System.Windows.Forms.Button
    Friend WithEvents search_tb As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents wishlistcombo As System.Windows.Forms.ComboBox
    Friend WithEvents viewhistbtn As System.Windows.Forms.Button
    Friend WithEvents title_lb As System.Windows.Forms.Label
    Friend WithEvents year_lb As System.Windows.Forms.Label
    Friend WithEvents language_lb As System.Windows.Forms.Label
    Friend WithEvents runtime_lb As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents wishlistbtn As System.Windows.Forms.Button
    Friend WithEvents addhistbtn As System.Windows.Forms.Button
    Friend WithEvents returnbtn As System.Windows.Forms.Button
    Friend WithEvents wishlist_lb As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents loadwishbtn As System.Windows.Forms.Button
    Friend WithEvents refreshbtn As System.Windows.Forms.Button

End Class
