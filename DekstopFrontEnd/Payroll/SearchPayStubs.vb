Imports Microsoft.Reporting.WinForms
Imports BOL

Public Class SearchPayStubs
    'Dim Param1 As New ReportParameter
    Private Sub SearchPayStubs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjSearchPayStubs.SearchPayStubs' table. You can move, or remove it, as needed.
        
        Dim allEmps = New List(Of Employee)
        allEmps = Employee.GetAllEmpsInDept(0)
        If allEmps.Count > 0 Then
            cboEmployees.DataSource = allEmps
            cboEmployees.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
            cboEmployees.ValueMember = "empid"     ' prop name of object to return
        End If
    End Sub

    Private Sub btnsearchpaystubs_Click(sender As Object, e As EventArgs) Handles btnsearchpaystubs.Click

        Dim empid As Integer
        empid = cboEmployees.SelectedValue

        'Dim rptParameter As ReportParameter
        'rptParameter = New ReportParameter("empid", empid)
        'ReportViewer1.LocalReport.SetParameters(rptParameter)
        MessageBox.Show(empid.ToString)
        ' Dim empidParameter = New ReportParameter("empid", empid)
        ' ReportViewer1.LocalReport.SetParameters(new ReportParameter[empidParameter],)

        Dim startdtpval As Date
        startdtpval = dtpStartDate.Value

        'Dim rptParameter2 As ReportParameter
        'rptParameter2 = New ReportParameter("startdate", startdtpval)
        'ReportViewer1.LocalReport.SetParameters(rptParameter2)
        MessageBox.Show(startdtpval.ToString)

        Dim enddtpval As Date
        enddtpval = dtpEndDate.Value

        'Dim rptParameter3 As ReportParameter
        'rptParameter3 = New ReportParameter("enddate", enddtpval)
        'ReportViewer1.LocalReport.SetParameters(rptParameter3)
        MessageBox.Show(enddtpval.ToString)

        Me.SearchPayStubsTableAdapter.Fill(Me.FinalProjSearchPayStubs.SearchPayStubs, empid, startdtpval, enddtpval)
        ' Me.SearchPayStubsTableAdapter.Fill(Me.FinalProjSearchPayStubs.SearchPayStubs)
        'TODO: This line of code loads data into the 'FinalProjSearchPayStubs.SearchPayStubs' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()


    End Sub
End Class