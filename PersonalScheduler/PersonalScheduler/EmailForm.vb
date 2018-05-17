Imports System.Net.Mail
Imports MetroFramework

Public Class EmailForm
    Dim emailAdd As String = ""
    Dim password As String = ""
    Public PS As Form1

    Public locationSelect1 As String
    Public descSelect1 As String
    Public dateSelect1 As String
    Public startSelect1 As String
    Public endSelect1 As String
    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential(emailAdd, password)
        Smtp_Server.Port = 587
        Smtp_Server.Host = "smtp.gmail.com"
        Smtp_Server.EnableSsl = True

        e_mail.From = New MailAddress(emailAdd)
        e_mail.To.Add(txtTo.Text)
        e_mail.Subject = txtSubject.Text
        e_mail.IsBodyHtml = False

        PS = New Form1

        e_mail.Body = "Date : " & dateSelect1 & ", Location : " & locationSelect1 & ", Description : " & descSelect1 & ", Time : " & startSelect1 & " until " & endSelect1
        Try
            Smtp_Server.Send(e_mail)
            MsgBox("Email Sent")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error Sending Email : " & ex.Message)
        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If txtEmailAdd.Text = "" Or txtPassword.Text = "" Then
            MetroMessageBox.Show(Me, "Please don't leave the required fields blank.", "Required Fields Lacking", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            emailAdd = txtEmailAdd.Text
            password = txtPassword.Text
            Panel1.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class