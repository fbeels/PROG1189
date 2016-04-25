Imports BOL

Public Class AddEmployee
    Dim myemp As Employee = Employee.create()

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfirstname.MaxLength = 50
        txtmiddleinit.MaxLength = 1
        txtlastname.MaxLength = 50
        dtpdateofbirth.MaxDate = Date.Now
        txtsin.MaxLength = 16
        txtstreetaddress.MaxLength = 50
        txtcity.MaxLength = 50
        txtpostal.MaxLength = 6

    End Sub

    Private Sub cbodept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodept.SelectedIndexChanged

        Dim selecteddept As Integer
        selecteddept = cbodept.SelectedValue

        'clear cbosupers
        'load cbosupers in that dept
        'clear jobs
        'load jobs in that dept

    End Sub


    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfirstname.Text = ""
        txtmiddleinit.Text = ""
        txtlastname.Text = ""
        dtpdateofbirth.Value = Date.Now
        txtsin.Text = ""
        txtstreetaddress.Text = ""
        txtcity.Text = ""
        txtpostal.Text = ""
        cboProv.SelectedIndex = -1
        mtxcellphone.Text = ""
        mtxworkphone.Text = ""
        cbodept.SelectedIndex = -1
        cbosupervisor.SelectedIndex = -1
        cbojobid.SelectedIndex = -1
        txtpayrate.Text = -1

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim strfname As String = txtfirstname.Text
        myemp.FirstName = strfname
        Dim strmidinit As String = txtmiddleinit.Text
        myemp.MiddleInt = strmidinit
        Dim strlname As String = txtlastname.Text
        myemp.LastName = strlname
        Dim dateofbirth As Date = dtpdateofbirth.Value
        myemp.DOB = dateofbirth
        Dim strsin As String = txtsin.Text
        myemp.SIN = strsin
        Dim strstreetaddress As String = txtstreetaddress.Text
        myemp.Address = strstreetaddress
        Dim strcity As String = txtcity.Text
        myemp.City = strcity
        Dim strpostal As String = txtpostal.Text
        myemp.Postal = strpostal
        Dim strprov As String = cboProv.SelectedValue
        myemp.Prov = strprov
        Dim strcell As String = mtxcellphone.Text
        myemp.Cell = strcell
        Dim strwork As String = mtxworkphone.Text
        myemp.Phone = strwork
        Dim intdept As Integer = cbodept.SelectedValue
        myemp.DeptID = intdept
        Dim intsuper As Integer = cbosupervisor.SelectedValue
        myemp.SupervisorID = intsuper
        Dim intjob As Integer = cbojobid.SelectedValue
        myemp.JobID = intjob
        Dim dblpayrate As Double = txtpayrate.Text
        myemp.PayRate = dblpayrate

    End Sub
End Class