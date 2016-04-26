Imports System.Net.Mail
Public Class emailTest

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click

    End Sub

    Private Sub emailTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim SendFrom As MailAddress = New MailAddress("sender@hi.ca")
            Dim SendTo As MailAddress = New MailAddress("destination@nbcc.ca")
        Dim MyMessage As MailMessage = New MailMessage(SendFrom, SendTo)
        'set the content MyMessage.IsBodyHtml = True
            MyMessage.Subject = "Art Inquiry"
            MyMessage.Body = "<h2>I am interested in your artwork</h2>... please view mine. " & "<a href='www.google.com'>View</a>"
        'Dim attachFile As New Attachment(txtAttachmentPath.Text) 'MyMessage.Attachments.Add(attachFile)
        Dim emailClient As New SmtpClient("localhost")
            emailClient.Send(MyMessage)
            MsgBox("Message Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class