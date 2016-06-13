Imports MySql.Data.MySqlClient

Public Class Form1
    'db connection string 
    Public con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=admin; database=moviedb")
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim sqlQuery As String
    Dim result As Integer
    Public global_user_id As Integer = 0
    Public global_movie_id As Integer = 0

    'login event load personal profile accordingly
    Private Sub loginbtn_Click(sender As System.Object, e As System.EventArgs) Handles loginbtn.Click
        sqlQuery = "SELECT * FROM moviedb.users WHERE username = '" & user_tb.Text & "' AND BINARY password = '" & password_tb.Text & "'"
        'MsgBox(sqlQuery)
        login(sqlQuery)

    End Sub

    'register new user using form 2
    Private Sub regbtn_Click(sender As System.Object, e As System.EventArgs) Handles regbtn.Click
        Form2.Show()
    End Sub

    'load init form for the PET application
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Personal Entertainment Tracker - PET"
        userStatusLabel.Visible = False
        logoutbtn.Visible = False
        logout_screen()
        load_db()
        returnbtn.Visible = False
    End Sub

    'logout user and load generic form for the application
    Private Sub logoutbtn_Click(sender As System.Object, e As System.EventArgs) Handles logoutbtn.Click
        global_user_id = 0
        loginbtn.Visible = True
        regbtn.Visible = True
        user_tb.Visible = True
        password_tb.Visible = True
        password.Visible = True
        Username.Visible = True
        user_tb.Text = Nothing
        password_tb.Text = Nothing
        logoutbtn.Visible = False
        userStatusLabel.Visible = False
        dt.Clear()
        logout_screen()
        load_db()
    End Sub

    'datagridview select option to view detail page for the selected title
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim movie_id As Integer
        Dim media_type As String
        title_lb.Visible = True
        year_lb.Visible = True
        runtime_lb.Visible = True
        language_lb.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        returnbtn.Visible = True
        If global_user_id = 0 Then
            addhistbtn.Visible = False
            wishlistbtn.Visible = False
        Else
            addhistbtn.Visible = True
            wishlistbtn.Visible = True
        End If
        If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
        Else
            movie_id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            title_lb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            year_lb.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            language_lb.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            runtime_lb.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            media_type = DataGridView1.Rows(e.RowIndex).Cells(5).Value

            If media_type = "movie" Then
                DataGridView2.Visible = False
            ElseIf media_type = "tv show" Then
                DataGridView2.Visible = True
                load_series(movie_id)
            End If
            global_movie_id = movie_id
        End If
        DataGridView1.Visible = False
        wishlistcombo.Visible = False
        wishlist_lb.Visible = False
        viewhistbtn.Visible = False
        loadwishbtn.Visible = False
    End Sub

    'search title event
    Public Sub search_title(ByVal search_title As String)
        Dim query As String
        Dim temp_table As New DataTable
        Try
            con.Open()
            query = "SELECT * FROM moviedb.movies WHERE title LIKE '%" & search_title & "%'"
            cmd = New MySqlCommand(query, con)
            da.SelectCommand = cmd
            da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                'MsgBox("Welcome " & dt.Rows(0).Item(1))
                DataGridView1.DataSource = temp_table
                DataGridView1.Columns(0).Visible = False
            Else
                MsgBox("no title found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    'if user select tv show from the grid view 1 load seasons list in gridview 2
    Public Sub load_series(ByVal movie_id As Integer)
        Dim query As String
        Dim temp_table As New DataTable
        Try
            con.Open()
            query = "SELECT season AS Season, episode_num AS Episode_Number, name_of_episode AS Episode_Title FROM moviedb.series"
            query &= " WHERE movie_id = " & movie_id & " ORDER BY season ASC, episode_num ASC"
            cmd = New MySqlCommand(query, con)
            da.SelectCommand = cmd
            da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                'MsgBox("Welcome " & dt.Rows(0).Item(1))
                DataGridView2.DataSource = temp_table
            Else
                MsgBox("no title found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    'search button event
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles searchbtn.Click
        If search_tb.Text = "" Then
            MsgBox("please enter the title to search")
        Else
            search_title(search_tb.Text)
        End If
    End Sub

    'register function to create new user 
    Public Sub register(ByVal sqlQuery As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sqlQuery
            End With
            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("User has been registered.")
                Form2.Close()
            Else
                MsgBox("Failed to register the user.")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    ' function to login user 
    Public Sub login(ByVal sqlQuery As String)
        Try
            con.Open()
            cmd = New MySqlCommand(sqlQuery, con)
            da.SelectCommand = cmd
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                'MsgBox("Welcome " & dt.Rows(0).Item(1))
                userStatusLabel.Text = "Welcome, " & dt.Rows(0).Item(1)
                global_user_id = dt.Rows(0).Item(0)
                init_login_screen()
                load_combobox(dt.Rows(0).Item(0))
                loginbtn.Visible = False
                regbtn.Visible = False
                user_tb.Visible = False
                password_tb.Visible = False
                Username.Visible = False
                password.Visible = False
                userStatusLabel.Visible = True
                logoutbtn.Visible = True
            Else
                MsgBox("Account does not exist.")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    'load all the tiltes from movies db
    Private Sub load_db()
        Dim query As String
        Dim temp_table As New DataTable
        Try
            con.Open()
            query = "SELECT * FROM moviedb.movies"
            cmd = New MySqlCommand(query, con)
            da.SelectCommand = cmd
            da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                'MsgBox("Welcome " & dt.Rows(0).Item(1))
                DataGridView1.DataSource = temp_table
                DataGridView1.Columns(0).Visible = False
            Else
                MsgBox("no title found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    ' load combobox with user's wishlist names
    Public Sub load_combobox(ByVal global_user_id As Integer)
        Dim query As String
        Dim temp_table As New DataTable
        Try
            If (con.State <> ConnectionState.Open) Then
                con.Open()
            End If
            query = "SELECT * FROM moviedb.wishlist where user_id = '" & global_user_id & "'"
            cmd = New MySqlCommand(query, con)
            da.SelectCommand = cmd
            da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                With wishlistcombo
                    .Name = "combo1"
                    .DisplayMember = "wishlist_name"
                    .ValueMember = "wishlist_id"
                    .DataSource = temp_table
                    .SelectedIndex = -1
                    Me.Controls.Add(wishlistcombo)
                    .Enabled = True
                End With
            Else
                'MsgBox("no title found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'setup login screen function to set screen once user login
    Public Sub init_login_screen()
        If global_user_id = 0 Then
            title_lb.Visible = False
            year_lb.Visible = False
            language_lb.Visible = False
            runtime_lb.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            returnbtn.Visible = False
            DataGridView2.Visible = False
            wishlistbtn.Visible = False
            addhistbtn.Visible = False
            DataGridView1.Visible = True
            wishlistcombo.Visible = False
            wishlist_lb.Visible = False
            viewhistbtn.Visible = False
            loadwishbtn.Visible = False
        Else
            title_lb.Visible = False
            year_lb.Visible = False
            language_lb.Visible = False
            runtime_lb.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            returnbtn.Visible = False
            DataGridView2.Visible = False
            wishlistbtn.Visible = False
            addhistbtn.Visible = False
            DataGridView1.Visible = True
            wishlistcombo.Visible = True
            wishlist_lb.Visible = True
            viewhistbtn.Visible = True
            loadwishbtn.Visible = True
        End If

    End Sub

    'function when user movie between movies and detail screen and load screen accordingluy
    Public Sub movie_series_screen()
        If global_user_id = 0 Then
            title_lb.Visible = True
            year_lb.Visible = True
            language_lb.Visible = True
            runtime_lb.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            DataGridView2.Visible = True
            wishlistbtn.Visible = False
            addhistbtn.Visible = False
            DataGridView1.Visible = False
            wishlistcombo.Visible = False
            wishlist_lb.Visible = False
            viewhistbtn.Visible = False
            loadwishbtn.Visible = False
        Else
            title_lb.Visible = True
            year_lb.Visible = True
            language_lb.Visible = True
            runtime_lb.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            DataGridView2.Visible = True
            wishlistbtn.Visible = True
            addhistbtn.Visible = True
            DataGridView1.Visible = False
            wishlistcombo.Visible = False
            wishlist_lb.Visible = False
            viewhistbtn.Visible = False
            loadwishbtn.Visible = False
        End If

    End Sub

    'function to load screen once user logout
    Public Sub logout_screen()
        title_lb.Visible = False
        year_lb.Visible = False
        language_lb.Visible = False
        runtime_lb.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        DataGridView2.Visible = False
        wishlistbtn.Visible = False
        addhistbtn.Visible = False
        DataGridView1.Visible = True
        wishlistcombo.Visible = False
        wishlist_lb.Visible = False
        viewhistbtn.Visible = False
        loadwishbtn.Visible = False
    End Sub

    'return button to return to main user screen
    Private Sub returnbtn_Click(sender As System.Object, e As System.EventArgs) Handles returnbtn.Click
        init_login_screen()
    End Sub

    'load selected wishlist from drop down menu
    Private Sub loadwishbtn_Click(sender As System.Object, e As System.EventArgs) Handles loadwishbtn.Click

        If wishlistcombo.SelectedIndex > -1 Then

            Dim query As String
            Dim temp_table As New DataTable
            Try
                If (con.State <> ConnectionState.Open) Then
                    con.Open()
                End If
                query = "SELECT m.movie_id, m.title, m.year, m.language, m.runtime, m.type FROM moviedb.movies m, moviedb.movies_wishlist mw WHERE m.movie_id = mw.movie_id and mw.wishlist_id = " & wishlistcombo.SelectedValue
                cmd = New MySqlCommand(query, con)
                da.SelectCommand = cmd
                da.Fill(temp_table)
                If (temp_table.Rows.Count > 0) Then
                    'MsgBox("Welcome " & dt.Rows(0).Item(1))
                    DataGridView1.DataSource = temp_table
                    DataGridView1.Columns(0).Visible = False
                Else
                    'MsgBox("no title found")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    'load grid view 1 with all available titles
    Private Sub refreshbtn_Click(sender As System.Object, e As System.EventArgs) Handles refreshbtn.Click
        load_db()
    End Sub

    'view history button event
    'load grid view 1 with users viewing history
    Private Sub viewhistbtn_Click(sender As System.Object, e As System.EventArgs) Handles viewhistbtn.Click
        Dim query As String
        Dim temp_table As New DataTable
        Try
            If (con.State <> ConnectionState.Open) Then
                con.Open()
            End If
            query = "select m.*, hs.year as watched_in_year from movies m, history_list hs where m.movie_id = hs.movie_id and hs.user_id = " & global_user_id & " ORDER BY hs.year desc"
            cmd = New MySqlCommand(query, con)
            da.SelectCommand = cmd
            da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                'MsgBox("Welcome " & dt.Rows(0).Item(1))
                DataGridView1.DataSource = temp_table
                DataGridView1.Columns(0).Visible = False
            Else
                'MsgBox("no title found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'add to wishlist button event load form 3 to add title to desired wishlist
    Private Sub wishlistbtn_Click(sender As System.Object, e As System.EventArgs) Handles wishlistbtn.Click
        Form3.Show()
    End Sub

    'add to history button event add title to user's viewing history
    Private Sub addhistbtn_Click(sender As System.Object, e As System.EventArgs) Handles addhistbtn.Click
        sqlQuery = "INSERT INTO history_list ( `movie_id`, `year`, `user_id`) VALUES"
        sqlQuery &= "('" & global_movie_id & "','" & Date.Now.Year & "','" & global_user_id & "')"
        new_db_entry(sqlQuery)
    End Sub

    ' add to db event will take sql statement as argument
    Public Sub new_db_entry(ByVal SQLQuery As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = SQLQuery
            End With
            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("added to history")
                Form2.Close()
            Else
                MsgBox("already in the list.")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Already in the list.")
            con.Close()
        End Try
    End Sub

End Class

