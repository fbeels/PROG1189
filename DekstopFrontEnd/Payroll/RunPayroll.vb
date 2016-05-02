Imports BOL

Public Class RunPayroll

    Private Sub btnrunpayroll_Click(sender As Object, e As EventArgs) Handles btnrunpayroll.Click
        Dim strpasscode As String = txtpasscode.Text

        Dim result As Boolean
        Try
            result = Payroll.RunPayRoll(strpasscode)
            ' btnrunpayroll.Visible = False
            'lblmsg.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        lblResults.Text = "PAYROLL Completed"

    End Sub

End Class