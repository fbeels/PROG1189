Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjDataSet7777.SearchPayStubs' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iempid As Integer = TextBox1.Text
        Dim startdtpval As Date
        startdtpval = DateTimePicker1.Value
        Dim endtpval As Date
        endtpval = DateTimePicker2.Value

        ' Dim sdate
        Me.SearchPayStubsTableAdapter.Fill(Me.FinalProjDataSet7777.SearchPayStubs, iempid, startdtpval, endtpval)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class