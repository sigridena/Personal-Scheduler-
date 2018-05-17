Imports MetroFramework
Imports MySql.Data.MySqlClient
Public Class Form1
    Public PS As schedulerclass
    Dim strQuery As String = ""
    Dim dateSelected As String
    Public MysqlConn As MySqlConnection
    Public cmd As MySqlCommand

    Public locationSelect As String
    Public descSelect As String
    Public dateSelect As String
    Public startSelect As String
    Public endSelect As String


    Private Sub cboAllDay_CheckedChanged(sender As Object, e As EventArgs) Handles cboAllDay.CheckedChanged
        If cboAllDay.Checked = True Then
            DTPStart.Enabled = False
            DTPEnd.Enabled = False
        Else
            DTPStart.Enabled = True
            DTPEnd.Enabled = True
        End If
    End Sub

    Private Sub MonthCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateSelected
        dateSelected = MonthCalendar.SelectionRange.Start.Month.ToString & "-" & MonthCalendar.SelectionRange.Start.Day.ToString & "-" & MonthCalendar.SelectionRange.Start.Year.ToString
        AppointPanel.Enabled = True
        lblDate.Text = dateSelected
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim exists As Integer = 0
        Dim date1 As Date = "#" & lblDate.Text & " " & DTPStart.Text & "#"
        Dim date12 As Date = "#" & lblDate.Text & " " & DTPEnd.Text & "#"
        Dim strConn = "server=localhost; user id=root; database=personal_scheduler; SslMode=none"
        Dim stringQuery As String = "Select * from tbl_appointments"
        Using connection As New MySqlConnection(strConn)
            Dim command As New MySqlCommand(stringQuery, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Dim date2 As Date = "#" & reader(6) & " " & reader(3) & "#"
                    Dim date3 As Date = "#" & reader(6) & " " & reader(4) & "#"
                    Dim result1 As Integer = DateTime.Compare(date1, date2)
                    Dim result2 As Integer = DateTime.Compare(date1, date3)
                    If (result1 = 0 Or result1 > 0) And result2 < 0 Then
                        exists = 2
                    ElseIf result1 < 0 And result2 < 0 And exists < 2 Then
                        exists = 1
                    End If
                End While
            Finally
                reader.Close()
            End Try
        End Using

        If txtLocation.Text = "" Or txtDesc.Text = "" Or cboReminder.SelectedItem = "" Then
            MetroMessageBox.Show(Me, "Please don't leave the required fields blank.", "Required Fields Lacking", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        ElseIf exists = 2 Then
            MetroMessageBox.Show(Me, "There is an existing appointment on that date/time, would you mind setting that appointment on a later date?", "Conflict of Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            strQuery = "insert into tbl_appointments(location, description, start_time, end_time, reminder, appointment_date) values('" & txtLocation.Text & "','" & txtDesc.Text & "','" & DTPStart.Text & "','" &
                       DTPEnd.Text & "','" & cboReminder.SelectedItem & "','" & lblDate.Text & "')"

            PS.SQLManager(strQuery, "saved")
            clear()
            AppointPanel.Enabled = False
            updateStatus()
            PS.displayRecords("Select * FROM tbl_appointments WHERE Status=1", DataGridView1)
            PS.displayRecords("Select * FROM tbl_appointments WHERE Status=2", DataGridView2)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PS = New schedulerclass
        PS.db_Connection()
        updateStatus()
        strQuery = "Select * from tbl_appointments WHERE STATUS=1"
        PS.displayRecords(strQuery, DataGridView1)
        strQuery = "Select * from tbl_appointments WHERE STATUS=2"
        PS.displayRecords(strQuery, DataGridView2)
        DTPEnd.Text = "11:59:59 PM"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppointmentsPanel.Visible = False
        AppointmentsPanel.Enabled = False
        CalendarPanel.Enabled = True
        AppointPanel.Enabled = False
        clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppointmentsPanel.Visible = True
        AppointmentsPanel.Enabled = True
        updateStatus()
        PS.displayRecords("Select * FROM tbl_appointments WHERE Status=1", DataGridView1)
        PS.displayRecords("Select * FROM tbl_appointments WHERE Status=2", DataGridView2)

    End Sub

    Private Sub connect()
        cmd = New MySqlCommand()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; user id=root;password=;database=personal_scheduler;SslMode=none"
        Try
            MysqlConn.Open()
            MsgBox("Connected")

            MysqlConn.Close()
        Catch myerror As MySqlException
            MetroMessageBox.Show(Me, myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clear()
        txtLocation.Clear()
        txtDesc.Clear()
        lblDate.Text = "Date"
        cboReminder.SelectedIndex = 0
        DTPStart.Text = "12:00:00 AM"
        DTPEnd.Text = "11:59:59 PM"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalendarPanel.Visible = True
        AppointPanel.Enabled = True
        AppointmentsPanel.Visible = False
        btnUpdate.Visible = True
        Button7.Visible = True
        btnSave.Visible = False

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        With DataGridView1
            i = DataGridView1.CurrentRow.Index
            txtid.Text = .Item(0, i).Value.ToString
            txtLocation.Text = .Item(1, i).Value.ToString
            txtDesc.Text = .Item(2, i).Value.ToString
            DTPStart.Text = .Item(3, i).Value.ToString
            DTPEnd.Text = .Item(4, i).Value.ToString
            cboReminder.Text = .Item(5, i).Value.ToString
            lblDate.Text = .Item(6, i).Value.ToString

            Button4.Enabled = True
            Button5.Enabled = True
            btnShare.Enabled = True
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtLocation.Text = "" Or txtDesc.Text = "" Or cboReminder.SelectedItem = "" Then
            MetroMessageBox.Show(Me, "Please don't leave the required fields blank.", "Required Fields Lacking", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            strQuery = "UPDATE tbl_appointments SET location='" & txtLocation.Text & "', description='" & txtDesc.Text & "', start_time='" & DTPStart.Text & "', end_time='" & DTPEnd.Text & "', reminder='" & cboReminder.SelectedItem & "', appointment_date='" & lblDate.Text & "' WHERE appointment_ID=" & txtid.Text
            PS.SQLManager(strQuery, "updated")
            clear()
            AppointPanel.Enabled = False
            AppointmentsPanel.Visible = True
            updateStatus()
            PS.displayRecords("Select * FROM tbl_appointments WHERE Status=1", DataGridView1)
            PS.displayRecords("Select * FROM tbl_appointments WHERE Status=2", DataGridView2)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clear()
        AppointmentsPanel.Visible = True
        AppointPanel.Enabled = False
        btnSave.Visible = True
        btnUpdate.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub updateStatus()
        Dim date1 As Date = DateTime.Now
        Dim strConn = "server=localhost; user id=root; database=personal_scheduler; SslMode=none"
        Dim stringQuery As String = "Select * from tbl_appointments"
        Using connection As New MySqlConnection(strConn)
            Dim command As New MySqlCommand(stringQuery, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Dim date2 As Date = "#" & reader(6) & " " & reader(3) & "#"
                    Dim result As Integer = DateTime.Compare(date1, date2)
                    If result < 0 Then
                        strQuery = "UPDATE tbl_appointments SET Status = 1 WHERE appointment_id=" & reader(0) & ""
                        PS.SQLManager(strQuery, "updated")
                    Else
                        strQuery = "UPDATE tbl_appointments SET Status = 2 WHERE appointment_id=" & reader(0) & ""
                        PS.SQLManager(strQuery, "updated")
                    End If
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        strQuery = "Delete from tbl_appointments where appointment_id =" & txtid.Text & ""
        PS.SQLManager(strQuery, "RECORD SUCCESSFULLY DELETED.")
        updateStatus()
        PS.displayRecords("Select * FROM tbl_appointments WHERE Status=1", DataGridView1)
        PS.displayRecords("Select * FROM tbl_appointments WHERE Status=2", DataGridView2)
        clear()

    End Sub

    Private Sub btnShare_Click(sender As Object, e As EventArgs) Handles btnShare.Click
        locationSelect = txtLocation.Text
        dateSelect = lblDate.Text
        startSelect = DTPStart.Text
        endSelect = DTPEnd.Text
        descSelect = txtDesc.Text

        EmailForm.dateSelect1 = dateSelect
        EmailForm.descSelect1 = descSelect
        EmailForm.locationSelect1 = locationSelect
        EmailForm.startSelect1 = startSelect
        EmailForm.endSelect1 = endSelect
        EmailForm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
