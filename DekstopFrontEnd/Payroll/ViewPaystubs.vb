Public Class ViewPaystubs

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjGetLastPayroll.GetLastPayroll' table. You can move, or remove it, as needed.
        Me.GetLastPayrollTableAdapter.Fill(Me.FinalProjGetLastPayroll.GetLastPayroll)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
