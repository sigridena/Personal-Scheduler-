Imports MySql.Data.MySqlClient

Public Class schedulerclass
    Public dbConn As MySqlConnection
    Public sqlcommand As MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As DataTable
    Public dr As MySqlDataReader
    Dim strConn = "server=localhost; user id=root; database=personal_scheduler; SslMode=none"
    Public Sub db_Connection()
        Try
            dbConn = New MySqlConnection(strConn)
            dbConn.Open()
            'MessageBox.Show("Connected Successfully", "Personal Scheduler", MessageBoxButtons.OK,
            'MessageBoxIcon.Information)
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error 101: DBConnection()" & ex.Message, "Personal Scheduler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)


        Try
            dbConn = New MySqlConnection(strConn)
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            DG.DataSource = dt
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error 101: DisplayRecords()" & ex.Message, "Personal Scheduler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SQLManager(ByVal SQL As String, ByVal msg As String)
        Try
            dbConn.Open()
            sqlcommand = New MySqlCommand(SQL, dbConn)
            With sqlcommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

            End With
            dbConn.Close()
            '  MessageBox.Show("Records Successfully" & msg, "KTV SYSTEM", MessageBoxButtons.OK,
            '  MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error 101: SQLMANAGER()" & ex.Message, "Personal Scheduler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function loadtoCombobox(ByVal SQL As String) As DataTable
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error 101: loadtoComboBox()" & ex.Message, "Personal Scheduler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return dt


    End Function
End Class
