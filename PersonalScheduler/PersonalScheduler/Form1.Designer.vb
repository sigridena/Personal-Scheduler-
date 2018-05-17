<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.AppointPanel = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboAllDay = New System.Windows.Forms.CheckBox()
        Me.cboReminder = New System.Windows.Forms.ComboBox()
        Me.DTPEnd = New System.Windows.Forms.DateTimePicker()
        Me.DTPStart = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.CalendarPanel = New System.Windows.Forms.Panel()
        Me.AppointmentsPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnShare = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NavPanel.SuspendLayout()
        Me.AppointPanel.SuspendLayout()
        Me.CalendarPanel.SuspendLayout()
        Me.AppointmentsPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Personal Scheduler"
        '
        'NavPanel
        '
        Me.NavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.NavPanel.Controls.Add(Me.Label2)
        Me.NavPanel.Controls.Add(Me.Button3)
        Me.NavPanel.Controls.Add(Me.Button2)
        Me.NavPanel.Controls.Add(Me.Button1)
        Me.NavPanel.Controls.Add(Me.Label1)
        Me.NavPanel.Location = New System.Drawing.Point(0, 5)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.Size = New System.Drawing.Size(206, 443)
        Me.NavPanel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "© Team Espejo 2018"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(0, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(211, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "     About"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(0, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "     Appointments"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "     Calendar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendar
        '
        Me.MonthCalendar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar.Location = New System.Drawing.Point(25, 46)
        Me.MonthCalendar.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(44, 349)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 43)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'AppointPanel
        '
        Me.AppointPanel.Controls.Add(Me.Button7)
        Me.AppointPanel.Controls.Add(Me.lblDate)
        Me.AppointPanel.Controls.Add(Me.btnUpdate)
        Me.AppointPanel.Controls.Add(Me.cboAllDay)
        Me.AppointPanel.Controls.Add(Me.cboReminder)
        Me.AppointPanel.Controls.Add(Me.DTPEnd)
        Me.AppointPanel.Controls.Add(Me.btnSave)
        Me.AppointPanel.Controls.Add(Me.DTPStart)
        Me.AppointPanel.Controls.Add(Me.Label7)
        Me.AppointPanel.Controls.Add(Me.Label5)
        Me.AppointPanel.Controls.Add(Me.Label6)
        Me.AppointPanel.Controls.Add(Me.Label10)
        Me.AppointPanel.Controls.Add(Me.Label4)
        Me.AppointPanel.Controls.Add(Me.Label3)
        Me.AppointPanel.Controls.Add(Me.txtDesc)
        Me.AppointPanel.Controls.Add(Me.txtLocation)
        Me.AppointPanel.Enabled = False
        Me.AppointPanel.Location = New System.Drawing.Point(274, 4)
        Me.AppointPanel.Name = "AppointPanel"
        Me.AppointPanel.Size = New System.Drawing.Size(235, 414)
        Me.AppointPanel.TabIndex = 5
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DimGray
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(122, 355)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 29)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Cancel"
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.Location = New System.Drawing.Point(27, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(35, 16)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(30, 355)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 29)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'cboAllDay
        '
        Me.cboAllDay.AutoSize = True
        Me.cboAllDay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cboAllDay.Location = New System.Drawing.Point(131, 16)
        Me.cboAllDay.Name = "cboAllDay"
        Me.cboAllDay.Size = New System.Drawing.Size(82, 25)
        Me.cboAllDay.TabIndex = 10
        Me.cboAllDay.Text = "All day"
        Me.cboAllDay.UseVisualStyleBackColor = True
        '
        'cboReminder
        '
        Me.cboReminder.FormattingEnabled = True
        Me.cboReminder.Items.AddRange(New Object() {"0 minute", "1 minute", "5 minutes", "10 minutes", "15 minutes", "20 minutes", "25 minutes", "30 minutes", "45 minutes", "1 hour", "2 hours", "3 hours", "12 hours", "24 hours"})
        Me.cboReminder.Location = New System.Drawing.Point(30, 308)
        Me.cboReminder.Name = "cboReminder"
        Me.cboReminder.Size = New System.Drawing.Size(176, 29)
        Me.cboReminder.TabIndex = 9
        Me.cboReminder.Text = "Reminder Time"
        '
        'DTPEnd
        '
        Me.DTPEnd.CustomFormat = "Time"
        Me.DTPEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPEnd.Location = New System.Drawing.Point(30, 252)
        Me.DTPEnd.Name = "DTPEnd"
        Me.DTPEnd.ShowUpDown = True
        Me.DTPEnd.Size = New System.Drawing.Size(176, 27)
        Me.DTPEnd.TabIndex = 8
        Me.DTPEnd.Value = New Date(2018, 5, 13, 0, 0, 0, 0)
        '
        'DTPStart
        '
        Me.DTPStart.CustomFormat = "Time"
        Me.DTPStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPStart.Location = New System.Drawing.Point(30, 199)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.ShowUpDown = True
        Me.DTPStart.Size = New System.Drawing.Size(176, 27)
        Me.DTPStart.TabIndex = 8
        Me.DTPStart.Value = New Date(2018, 5, 13, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(31, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(40, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Appointment Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(31, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "FROM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(30, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 21)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(30, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Reminder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(30, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Location"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(30, 116)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(176, 27)
        Me.txtDesc.TabIndex = 5
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(30, 62)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(176, 27)
        Me.txtLocation.TabIndex = 4
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(69, 327)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(112, 27)
        Me.txtid.TabIndex = 12
        Me.txtid.Visible = False
        '
        'CalendarPanel
        '
        Me.CalendarPanel.AutoSize = True
        Me.CalendarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CalendarPanel.Controls.Add(Me.AppointmentsPanel)
        Me.CalendarPanel.Controls.Add(Me.txtid)
        Me.CalendarPanel.Controls.Add(Me.Label9)
        Me.CalendarPanel.Controls.Add(Me.Label8)
        Me.CalendarPanel.Controls.Add(Me.AppointPanel)
        Me.CalendarPanel.Controls.Add(Me.MonthCalendar)
        Me.CalendarPanel.Location = New System.Drawing.Point(206, 30)
        Me.CalendarPanel.Name = "CalendarPanel"
        Me.CalendarPanel.Size = New System.Drawing.Size(527, 421)
        Me.CalendarPanel.TabIndex = 6
        '
        'AppointmentsPanel
        '
        Me.AppointmentsPanel.Controls.Add(Me.TabControl1)
        Me.AppointmentsPanel.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentsPanel.Name = "AppointmentsPanel"
        Me.AppointmentsPanel.Size = New System.Drawing.Size(524, 418)
        Me.AppointmentsPanel.TabIndex = 7
        Me.AppointmentsPanel.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(518, 415)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnShare)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(510, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Upcoming Appointments"
        '
        'btnShare
        '
        Me.btnShare.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnShare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShare.Enabled = False
        Me.btnShare.FlatAppearance.BorderSize = 0
        Me.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShare.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnShare.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShare.Location = New System.Drawing.Point(347, 320)
        Me.btnShare.Name = "btnShare"
        Me.btnShare.Size = New System.Drawing.Size(126, 35)
        Me.btnShare.TabIndex = 1
        Me.btnShare.Text = "Share via Email"
        Me.btnShare.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(198, 320)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 35)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Remove"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(48, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 35)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(510, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(510, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appointments History"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(0, 13)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(510, 350)
        Me.DataGridView2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(21, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "to add an appointment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(21, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(245, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Select desired date you want "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 447)
        Me.Controls.Add(Me.CalendarPanel)
        Me.Controls.Add(Me.NavPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(33, 97, 33, 32)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NavPanel.ResumeLayout(False)
        Me.NavPanel.PerformLayout()
        Me.AppointPanel.ResumeLayout(False)
        Me.AppointPanel.PerformLayout()
        Me.CalendarPanel.ResumeLayout(False)
        Me.CalendarPanel.PerformLayout()
        Me.AppointmentsPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents NavPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents btnSave As Button
    Friend WithEvents AppointPanel As Panel
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents CalendarPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboReminder As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboAllDay As CheckBox
    Friend WithEvents AppointmentsPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnShare As Button
    Public WithEvents txtLocation As TextBox
    Public WithEvents DTPStart As DateTimePicker
    Public WithEvents DTPEnd As DateTimePicker
    Public WithEvents lblDate As Label
End Class
