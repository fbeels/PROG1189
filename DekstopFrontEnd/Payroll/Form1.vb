Imports BOL

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjDataSet7777.SearchPayStubs' table. You can move, or remove it, as needed.
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
        ' MessageBox.Show(empid.ToString)
    
        Dim startdtpval As Date
        startdtpval = dtpStartDate.Value
        '  MessageBox.Show(startdtpval.ToString)

        Dim enddtpval As Date
        enddtpval = dtpEndDate.Value
        '  MessageBox.Show(enddtpval.ToString)

        Me.SearchPayStubsTableAdapter.Fill(Me.FinalProjDataSet7777.SearchPayStubs, empid, startdtpval, enddtpval)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class