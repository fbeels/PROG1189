Imports System.Net.Mail
Public Class CalcPayroll

    Private Sub CalcPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjGetLastPayroll.GetLastPayroll' table. You can move, or remove it, as needed.
        Me.GetLastPayrollTableAdapter.Fill(Me.FinalProjGetLastPayroll.GetLastPayroll)
        'TODO: This line of code loads data into the 'FinalProjDataSet.CalculatePayroll' table. You can move, or remove it, as needed.
        Me.CalculatePayrollTableAdapter.Fill(Me.FinalProjDataSet.CalculatePayroll)
        'TODO: This line of code loads data into the 'FinalProjDataSet2.CalculatePayroll' table. You can move, or remove it, as needed.
        Me.CalculatePayrollTableAdapter.Fill(Me.FinalProjDataSet2.CalculatePayroll)
        ''TODO: This line of code loads data into the 'FinalProjGetLastPayroll.GetLastPayroll' table. You can move, or remove it, as needed.
        'Me.GetLastPayrollTableAdapter.Fill(Me.FinalProjGetLastPayroll.GetLastPayroll)
        ''TODO: This line of code loads data into the 'FinalProjDataSet.CalculatePayroll' table. You can move, or remove it, as needed.
        'Dim passcode As String = "1234"
        'Dim processdate As Date = "2016-04-26"
        'Me.CalculatePayrollTableAdapter.Fill(Me.FinalProjDataSet.CalculatePayroll(), passcode, processdate)

        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub btnemail_Click(sender As Object, e As EventArgs) Handles btnemail.Click
        Try

            Dim SendFrom As MailAddress = New MailAddress("sender@hi.ca")
            Dim SendTo As MailAddress = New MailAddress("destination@nbcc.ca")
            Dim MyMessage As MailMessage = New MailMessage(SendFrom, SendTo)
            'set the content MyMessage.IsBodyHtml = True
            MyMessage.Subject = "Payroll"
            MyMessage.Body = "<h2>here's your paystubb</h2>"
            'Dim attachFile As New Attachment(txtAttachmentPath.Text) 'MyMessage.Attachments.Add(attachFile)
            Dim emailClient As New SmtpClient("localhost")
            emailClient.Send(MyMessage)


            'Dim SendTo As MailAddress = New MailAddress("dude@dude.com")

            'Dim SendTo As MailAddress = New MailAddress("Hsimpson@ictech.ca")
            'emailClient.Send(MyMessage)
            'Dim SendTo As MailAddress = New MailAddress("quit@gone.com")
            'emailClient.Send(MyMessage)
            'Dim SendTo As MailAddress = New MailAddress("bwayne@waynetech.com")
            'emailClient.Send(MyMessage)
            'Dim SendTo As MailAddress = New MailAddress("lex@lexcorp.com")
            'emailClient.Send(MyMessage)
            'Dim SendTo As MailAddress = New MailAddress("rmarkingston@ ibm.com")
            ' emailClient.Send(MyMessage)
            'Dim SendTo As MailAddress = New MailAddress("jsmith@acme.com")

            'emailClient.Send(MyMessage)
            'MsgBox("Message Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class