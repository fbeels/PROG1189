Public Class CalcPayroll

    Private Sub CalcPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjDataSet.CalculatePayroll' table. You can move, or remove it, as needed.
        Dim passcode As String = "1234"
        Dim processdate As Date = "2016-04-26"
        Me.CalculatePayrollTableAdapter.Fill(Me.FinalProjDataSet.CalculatePayroll(), passcode, processdate)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class