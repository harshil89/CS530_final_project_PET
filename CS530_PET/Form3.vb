Imports MySql.Data.MySqlClient

Public Class Form3

    ' add to wishlist button click event to add the media title to wishlist
    Private Sub addtowishbtn_Click(sender As System.Object, e As System.EventArgs) Handles addtowishbtn.Click
        Dim result As Integer
        Dim result1 As Integer
        Dim sqlQuery As String
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        If selectwishcombo.SelectedIndex <= -1 And newwish_tb.Text.Length = 0 Then
            MsgBox("either select or enter name for the wishlist")
        ElseIf newwish_tb.Text.Length > 0 Then
            Try
                Form1.con.Open()
                sqlQuery = "INSERT INTO wishlist ( `user_id`, `wishlist_name`) VALUES"
                sqlQuery &= "('" & Form1.global_user_id & "','" & newwish_tb.Text & "')"
                With Form1.cmd
                    .Connection = Form1.con
                    .CommandText = sqlQuery
                End With
                result = Form1.cmd.ExecuteNonQuery
                If result > 0 Then
                    sqlQuery = "select wishlist_id from wishlist where wishlist_name = '" & newwish_tb.Text & "' and user_id ='" & Form1.global_user_id & "'"
                    Form1.cmd = New MySqlCommand(sqlQuery, Form1.con)
                    Form1.da.SelectCommand = Form1.cmd
                    Form1.da.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        'MsgBox("Welcome " & dt.Rows(0).Item(1))
                        sqlQuery = "INSERT INTO movies_wishlist ( `wishlist_id`, `movie_id`) VALUES"
                        sqlQuery &= "('" & dt.Rows(0).Item("wishlist_id") & "','" & Form1.global_movie_id & "')"
                        Form1.cmd = New MySqlCommand(sqlQuery, Form1.con)
                        result1 = Form1.cmd.ExecuteNonQuery
                        If (result1 > 0) Then
                            Form1.load_combobox(Form1.global_user_id)
                            Form1.init_login_screen()
                            Me.Close()
                        End If
                    End If
                Else
                    MsgBox("entry failed")
                End If
                Form1.con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Form1.con.Close()
            End Try
        ElseIf selectwishcombo.SelectedIndex > -1 Then
            Try
                Form1.con.Open()
                sqlQuery = "select wishlist_id from wishlist where wishlist_name = '" & selectwishcombo.Text & "' and user_id ='" & Form1.global_user_id & "'"
                Form1.cmd = New MySqlCommand(sqlQuery, Form1.con)
                Form1.da.SelectCommand = Form1.cmd
                Form1.da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    'MsgBox("Welcome " & dt.Rows(0).Item(1))
                    sqlQuery = "INSERT INTO movies_wishlist ( `wishlist_id`, `movie_id`) VALUES"
                    sqlQuery &= "('" & dt.Rows(0).Item("wishlist_id") & "','" & Form1.global_movie_id & "')"
                    Form1.cmd = New MySqlCommand(sqlQuery, Form1.con)
                    result1 = Form1.cmd.ExecuteNonQuery
                    If (result1 > 0) Then
                        Form1.load_combobox(Form1.global_user_id)
                        Form1.init_login_screen()
                        Me.Close()
                    End If
                End If
                Form1.con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Form1.con.Close()
            End Try
        End If
    End Sub

    'init conbobox with loggedin users existing wishlist
    Public Sub load_combobox()
        Dim query As String
        Dim temp_table As New DataTable
        Try
            If (Form1.con.State <> ConnectionState.Open) Then
                Form1.con.Open()
            End If
            query = "SELECT * FROM moviedb.wishlist where user_id = '" & Form1.global_user_id & "'"
            Form1.cmd = New MySqlCommand(query, Form1.con)
            Form1.da.SelectCommand = Form1.cmd
            Form1.da.Fill(temp_table)
            If (temp_table.Rows.Count > 0) Then
                With selectwishcombo
                    .Name = "combo1"
                    .DisplayMember = "wishlist_name"
                    .ValueMember = "wishlist_id"
                    .DataSource = temp_table
                    .SelectedIndex = -1
                    Me.Controls.Add(selectwishcombo)
                    .Enabled = True
                End With
            Else
                'MsgBox("no title found")
            End If
            Form1.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Form1.con.Close()
        End Try
    End Sub

    'init window screen 
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_combobox()
    End Sub
End Class