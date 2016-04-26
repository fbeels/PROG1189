Imports BOL
Imports Common

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

        LoadJobsDropdown()
        LoadEmployeesDropdown(0)
        LoadJobsDropdown(0)

    End Sub

    Private Sub cbodept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodept.SelectedIndexChanged

        'Dim selecteddept As Integer
        'selecteddept = cbodept.SelectedValue

        'clear cbosupers
        'load cbosupers in that dept
        'clear jobs
        'load jobs in that dept

    End Sub


    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfirstname.Text = ""
        txtmiddleinit.Text = ""
        txtlastname.Text = ""
        '  dtpdateofbirth.Value = Date.Now
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
        Try


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
            Dim strprov As String = cboProv.SelectedItem
            ' MsgBox(strprov)
            myemp.Prov = strprov
            Dim strcell As String = mtxcellphone.Text
            myemp.Cell = strcell
            Dim strwork As String = mtxworkphone.Text
            myemp.Phone = strwork
            Dim stremail As String = txtemail.Text
            myemp.Email = stremail
            Dim intdept As Integer = cbodept.SelectedValue
            myemp.DeptID = intdept
            Dim intsuper As Integer = cbosupervisor.SelectedValue
            myemp.SupervisorID = intsuper
            Dim intjob As Integer = cbojobid.SelectedValue
            myemp.JobID = intjob
            Dim dblpayrate As Double = txtpayrate.Text
            myemp.PayRate = dblpayrate

            myemp.SeniorityDate = Date.Now
            myemp.JobStartDate = Date.Now

            Dim done As Integer = 0
            done = Employee.insert(myemp)
            If done > 0 Then
                MessageBox.Show("saved,Employee ID:" & done.ToString, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("save failed,fix the errors and try again", "info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub
    Private Sub LoadJobsDropdown(ByRef deptid As Integer)
        cbojobid.Items.Clear()
        Dim allJobs = New List(Of Job)
        allJobs = Job.GetAllJobs4Dropdowns(deptid)
        If allJobs.Count > 0 Then
            cbojobid.DataSource = allJobs
            cbojobid.DisplayMember = "JobName"    ' indicate property name of obj to SHOW
            cbojobid.ValueMember = "JobId"     ' prop name of object to return
        End If
    End Sub

    Private Sub LoadJobsDropdown()
        cbodept.Items.Clear()
        Dim allDepts = New List(Of Department)
        allDepts = Department.GetAllDepts()
        If allDepts.Count > 0 Then
            cbodept.DataSource = allDepts
            cbodept.DisplayMember = "DeptName"    ' indicate property name of obj to SHOW
            cbodept.ValueMember = "DeptId"     ' prop name of object to return
        End If
    End Sub
    Private Sub LoadEmployeesDropdown(ByRef deptid As Integer)
        'get all employees in selected department
        Dim allempsInDept = New List(Of Employee)
        allempsInDept = Employee.GetAllEmpsInDept(deptid)
        If allempsInDept.Count > 0 Then
            cbosupervisor.DataSource = allempsInDept
            cbosupervisor.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
            cbosupervisor.ValueMember = "empid"     ' prop name of object to return
        End If
    End Sub

    Private Sub btnprefill_Click(sender As Object, e As EventArgs) Handles btnprefill.Click

        txtfirstname.Text = "John"
        txtmiddleinit.Text = "Q"
        txtlastname.Text = "Smith"
        'dtpdateofbirth.Value
        txtsin.Text = "123456789"
        txtstreetaddress.Text = "1234 main street"
        txtcity.Text = "moncton"
        txtpostal.Text = "e1b5a3"
        cboProv.SelectedValue = "NB"
        mtxcellphone.Text = "5061234567"
        mtxworkphone.Text = "9027654321"
        txtemail.Text = "jsmith@acme.com"
        'Dim intdept As Integer = cbodept.SelectedValue
        'Dim intsuper As Integer = cbosupervisor.SelectedValue
        'Dim intjob As Integer = cbojobid.SelectedValue
        txtpayrate.Text = "2300"

    End Sub
End Class