Imports BOL
Public Class AddEmployee
    Dim myemp As Employee = Employee.Create()
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
        Dim strmidinit As String = txtmiddleinit.Text
        Dim strlname As String = txtlastname.Text
        Dim dateofbirth As Date = dtpdateofbirth.Value
        Dim strsin As String = txtsin.Text
        Dim strstreetaddress As String = txtstreetaddress.Text
        Dim strcity As String = txtcity.Text
        Dim strpostal As String = txtpostal.Text
        Dim strprov As String = cboProv.SelectedValue
        Dim strcell As String = mtxcellphone.Text
        Dim strwork As String = mtxworkphone.Text
        Dim intdept As Integer = cbodept.SelectedValue
        Dim intsuper As Integer = cbosupervisor.SelectedValue
        Dim intjob As Integer = cbojobid.SelectedValue
        Dim dblpayrate As Double = txtpayrate.Text


    End Sub
End Class