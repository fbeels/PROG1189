Imports BOL

Public Class RunPayroll

    Private Sub btnrunpayroll_Click(sender As Object, e As EventArgs) Handles btnrunpayroll.Click
        Dim strpasscode As String = txtpasscode.Text

        Dim result As Integer
        Try
            result = Payroll.RunPayRoll(strpasscode)
            ' btnrunpayroll.Visible = False
            'lblmsg.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        If result > 0 Then
            lblResults.Text = "PAYROLL Completed, " + result.ToString + " paystubs generated"
            btnrunpayroll.Enabled = False

        Else
            lblResults.Text = "ERROR 0 paystubs generated"
        End If


    End Sub

End Class