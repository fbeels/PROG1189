﻿Imports BOL
Imports Common

Public Class AddEmployee
    Dim myemp As Employee = Employee.create()
    Dim DEBUG As Boolean = True
    Dim loadorreset As Boolean = False
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadorreset = True
        txtfirstname.MaxLength = 50
        txtmiddleinit.MaxLength = 1
        txtlastname.MaxLength = 50
        dtpdateofbirth.MaxDate = Date.Now
        txtsin.MaxLength = 16
        txtstreetaddress.MaxLength = 50
        txtcity.MaxLength = 50
        txtpostal.MaxLength = 6

        LoadDeptsDropdown()
        ' LoadEmployeesDropdown(0)
        LoadJobsDropdown(0)
        btnprefill.Visible = False

        mtxcellphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        mtxworkphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If DEBUG = True Then
            btnprefill.Visible = True
        End If
        loadorreset = True

    End Sub


    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        loadorreset = True
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
        ' cbosupervisor.SelectedIndex = -1
        cbojobid.SelectedIndex = -1
        txtpayrate.Text = ""
        txtemail.Text = ""
        cboProv.SelectedIndex = -1

        cbodept.SelectedItem = 1
        '  cbosupervisor.SelectedItem = 1
        cbojobid.SelectedItem = 1
        lblresult.Text = ""

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim inputisallok As Boolean = True
            '----------------------------------------------------------------
            Dim strfname As String = txtfirstname.Text
            If strfname = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtfirstname, "first name required")
                txtfirstname.BackColor = Color.Red
            Else
                inputisallok = True
                ErrorProvider1.SetError(txtfirstname, String.Empty)
                txtfirstname.BackColor = Color.White
                myemp.FirstName = strfname
            End If


            '----------------------------------------------------------------
            ' Dim strmidinit As String = txtmiddleinit.Text
            If IsNumeric(txtmiddleinit.Text) Then
                ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")
                txtmiddleinit.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)
                txtmiddleinit.BackColor = Color.White
                myemp.MiddleInt = txtmiddleinit.Text
            End If

            '----------------------------------------------------------------
            Dim strlname As String = txtlastname.Text
            If strlname = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtlastname, "last name required")
                txtlastname.BackColor = Color.Red
            Else
                inputisallok = True
                ErrorProvider1.SetError(txtlastname, String.Empty)
                txtlastname.BackColor = Color.White
                myemp.LastName = strlname
            End If

            '----------------------------------------------------------------
            Dim dateofbirth As Date = dtpdateofbirth.Value
            myemp.DOB = dateofbirth
            '----------------------------------------------------------------
            Dim strsin As String = txtsin.Text
            If strsin = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtsin, "sin required")
                txtsin.BackColor = Color.Red
            Else
                inputisallok = True
                ErrorProvider1.SetError(txtsin, String.Empty)
                txtsin.BackColor = Color.White
                myemp.SIN = strsin
            End If

            '----------------------------------------------------------------

            Dim straddress As String = txtstreetaddress.Text
            If straddress = "" Then
                ErrorProvider1.SetError(txtstreetaddress, "address required")
                txtstreetaddress.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtstreetaddress, String.Empty)
                txtstreetaddress.BackColor = Color.White
                myemp.Address = straddress
            End If
            '----------------------------------------------------------------
            Dim strcity As String = txtcity.Text

            If strcity = "" Then
                ErrorProvider1.SetError(txtcity, "city required")
                txtcity.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtcity, String.Empty)
                txtcity.BackColor = Color.White
                myemp.City = strcity
            End If
            '----------------------------------------------------------------
            Dim strpostal As String = txtpostal.Text

            If strpostal = "" Then
                ErrorProvider1.SetError(txtpostal, "postal required")
                txtpostal.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtpostal, String.Empty)
                txtpostal.BackColor = Color.White
                myemp.Postal = strpostal
            End If
            '----------------------------------------------------------------
            Dim strprov As String = cboProv.SelectedItem
            ' MsgBox(strprov)
            myemp.Prov = strprov
            '----------------------------------------------------------------
            Dim strcellphone As String = mtxcellphone.Text
            If strcellphone = "" Then
                ErrorProvider1.SetError(mtxcellphone, "cell phone required")
                mtxcellphone.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(mtxcellphone, String.Empty)
                mtxcellphone.BackColor = Color.White
                myemp.Cell = strcellphone
            End If
            '----------------------------------------------------------------

            Dim strworkphone As String = mtxworkphone.Text
            If strworkphone = "" Then
                ErrorProvider1.SetError(mtxworkphone, "work phone required")
                mtxworkphone.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(mtxworkphone, String.Empty)
                mtxworkphone.BackColor = Color.White
                myemp.Phone = strworkphone
            End If
            '----------------------------------------------------------------
            Dim stremail As String = txtemail.Text

            If stremail = "" Then
                ErrorProvider1.SetError(txtemail, "email required")
                txtemail.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtemail, String.Empty)
                txtemail.BackColor = Color.White
                myemp.Email = stremail
            End If
            '----------------------------------------------------------------
            Dim intdept As Integer = cbodept.SelectedValue
            myemp.DeptID = intdept
            '----------------------------------------------------------------
            'Dim intsuper As Integer = cbosupervisor.SelectedValue
            ' myemp.SupervisorID = intsuper
            myemp.SupervisorID = lblsuperid.Text
            myemp.supervisorName = lblsupername.Text
            '----------------------------------------------------------------
            Dim intjob As Integer = cbojobid.SelectedValue
            myemp.JobID = intjob
            '----------------------------------------------------------------
            Dim dblpayrate As Double
            If txtpayrate.Text = "" Then
                dblpayrate = 0
            Else
                dblpayrate = txtpayrate.Text
            End If

            Dim strpayrate As String = txtpayrate.Text
            If strpayrate = "" Then
                ErrorProvider1.SetError(txtpayrate, "payrate required")
                txtpayrate.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtpayrate, String.Empty)
                txtpayrate.BackColor = Color.White
                ' myemp.FirstName = strfname
            End If
         



            myemp.PayRate = dblpayrate
            '----------------------------------------------------------------
            myemp.SeniorityDate = Date.Now
            '----------------------------------------------------------------
            myemp.JobStartDate = Date.Now
            '----------------------------------------------------------------


            Dim done As Integer = 0
            If inputisallok = True Then
                done = Employee.insert(myemp)
            End If

            If done > 0 Then
                lblresult.Text = "saved,Employee ID:" & done.ToString
                'MessageBox.Show("saved,Employee ID:" & done.ToString, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lblresult.Text = "save failed,fix the errors and try again"
                'MessageBox.Show("save failed,fix the errors and try again", "info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblresult.Text = ex.Message.ToString
        End Try




    End Sub
    Private Sub btnprefill_Click(sender As Object, e As EventArgs) Handles btnprefill.Click

        txtfirstname.Text = "John"
        ErrorProvider1.SetError(txtfirstname, String.Empty)
        txtfirstname.BackColor = Color.White

        txtmiddleinit.Text = "Q"
        ErrorProvider1.SetError(txtmiddleinit, String.Empty)
        txtmiddleinit.BackColor = Color.White

        txtlastname.Text = "Smith"
        ErrorProvider1.SetError(txtlastname, String.Empty)
        txtlastname.BackColor = Color.White

        'dtpdateofbirth.Value
        txtsin.Text = "123456789"
        ErrorProvider1.SetError(txtsin, String.Empty)
        txtsin.BackColor = Color.White

        txtstreetaddress.Text = "1234 main street"
        ErrorProvider1.SetError(txtstreetaddress, String.Empty)
        txtstreetaddress.BackColor = Color.White

        txtcity.Text = "moncton"
        ErrorProvider1.SetError(txtcity, String.Empty)
        txtcity.BackColor = Color.White

        txtpostal.Text = "e1b5a3"
        ErrorProvider1.SetError(txtpostal, String.Empty)
        txtpostal.BackColor = Color.White

        mtxcellphone.Text = "5061234567"
        ErrorProvider1.SetError(mtxcellphone, String.Empty)
        mtxcellphone.BackColor = Color.White

        mtxworkphone.Text = "9027654321"
        ErrorProvider1.SetError(mtxworkphone, String.Empty)
        mtxworkphone.BackColor = Color.White

        txtemail.Text = "jsmith@acme.com"
        ErrorProvider1.SetError(txtemail, String.Empty)
        txtemail.BackColor = Color.White

        'Dim intdept As Integer = cbodept.SelectedValue
        'Dim intsuper As Integer = cbosupervisor.SelectedValue
        'Dim intjob As Integer = cbojobid.SelectedValue

        txtpayrate.Text = "2300"
        ErrorProvider1.SetError(txtpayrate, String.Empty)
        txtpayrate.BackColor = Color.White

        cboProv.SelectedText = "NB"
        cbodept.SelectedItem = 1
        'cbosupervisor.SelectedItem = 1
        cbojobid.SelectedItem = 1

        lblresult.Text = ""

    End Sub


    Private Sub LoadJobsDropdown(ByRef deptid As Integer)
        cbojobid.DataSource = Nothing
        cbojobid.Items.Clear()
        Dim allJobs = New List(Of Job)
        allJobs = Job.GetAllJobs4Dropdowns(deptid)
        If allJobs.Count > 0 Then
            cbojobid.DataSource = allJobs
            cbojobid.DisplayMember = "JobName"    ' indicate property name of obj to SHOW
            cbojobid.ValueMember = "JobId"     ' prop name of object to return
        End If
    End Sub
    Private Sub LoadDeptsDropdown()
        cbodept.Items.Clear()
        Dim allDepts = New List(Of Department)
        allDepts = Department.GetAllDepts()
        If allDepts.Count > 0 Then
            cbodept.DataSource = allDepts
            cbodept.DisplayMember = "DeptName"   ' indicate property name of obj to SHOW
            cbodept.ValueMember = "DeptId"     ' prop name of object to return
        End If
        ' lblsuperid.Text = a
        '   lblsupername.Text = allDepts(0).SupervisorName
    End Sub
    'Private Sub LoadEmployeesDropdown(ByRef deptid As Integer)

    '    'get all employees in selected department
    '    Dim allempsInDept = New List(Of Employee)
    '    allempsInDept = Employee.GetAllEmpsInDept(deptid)
    '    If allempsInDept.Count > 0 Then
    '        cbosupervisor.DataSource = allempsInDept
    '        cbosupervisor.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
    '        cbosupervisor.ValueMember = "empid"     ' prop name of object to return
    '    End If
    'End Sub
    Private Sub GetSupervisor(ByRef deptid As Integer)
        Dim superdept As Department = Department.GetADept(deptid)
        lblsupername.Text = superdept.SupervisorName
        lblsuperid.Text = superdept.SupervisorId.ToString
    End Sub


    Private Sub txtfirstname_Leave(sender As Object, e As EventArgs) Handles txtfirstname.Leave
        Dim strfname As String = txtfirstname.Text
        If strfname = "" Then
            ErrorProvider1.SetError(txtfirstname, "first name required")
            txtfirstname.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtfirstname, String.Empty)
            txtfirstname.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtlastname_Leave(sender As Object, e As EventArgs) Handles txtlastname.Leave
        Dim strlname As String = txtlastname.Text
        If strlname = "" Then
            ErrorProvider1.SetError(txtlastname, "first name required")
            txtlastname.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtlastname, String.Empty)
            txtlastname.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If

    End Sub
    Private Sub txtmiddleinit_Leave(sender As Object, e As EventArgs) Handles txtmiddleinit.Leave
        ' Dim strmint As String = txtmiddleinit.Text
        If IsNumeric(txtmiddleinit.Text) Then
            ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")
                txtmiddleinit.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)
                txtmiddleinit.BackColor = Color.White
                ' myemp.FirstName = strfname
            End If
    End Sub
    Private Sub txtstreetaddress_Leave(sender As Object, e As EventArgs) Handles txtstreetaddress.Leave
        Dim straddress As String = txtstreetaddress.Text
        If straddress = "" Then
            ErrorProvider1.SetError(txtstreetaddress, "address required")
            txtstreetaddress.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtstreetaddress, String.Empty)
            txtstreetaddress.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtcity_Leave(sender As Object, e As EventArgs) Handles txtcity.Leave
        Dim strcity As String = txtcity.Text
        If strcity = "" Then
            ErrorProvider1.SetError(txtcity, "city required")
            txtcity.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtcity, String.Empty)
            txtcity.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtpostal_Leave(sender As Object, e As EventArgs) Handles txtpostal.Leave
        Dim strpostal As String = txtpostal.Text
        If strpostal = "" Then
            ErrorProvider1.SetError(txtpostal, "postal required")
            txtpostal.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtpostal, String.Empty)
            txtpostal.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub mtxcellphone_Leave(sender As Object, e As EventArgs) Handles mtxcellphone.Leave
        Dim strcellphone As String = mtxcellphone.Text
        If strcellphone = "" Then
            ErrorProvider1.SetError(mtxcellphone, "cell phone required")
            mtxcellphone.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(mtxcellphone, String.Empty)
            mtxcellphone.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub mtxworkphone_Leave(sender As Object, e As EventArgs) Handles mtxworkphone.Leave
        Dim strworkphone As String = mtxworkphone.Text
        If strworkphone = "" Then
            ErrorProvider1.SetError(mtxworkphone, "work phone required")
            mtxworkphone.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(mtxworkphone, String.Empty)
            mtxworkphone.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        Dim stremail As String = txtemail.Text
        If stremail = "" Then
            ErrorProvider1.SetError(txtemail, "email required")
            txtemail.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtemail, String.Empty)
            txtemail.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtsin_Leave(sender As Object, e As EventArgs) Handles txtsin.Leave
        Dim strsin As String = txtsin.Text
        If strsin = "" Then
            ErrorProvider1.SetError(txtsin, "sin required")
            txtsin.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtsin, String.Empty)
            txtsin.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtpayrate_Leave(sender As Object, e As EventArgs) Handles txtpayrate.Leave
        Dim strpayrate As String = txtpayrate.Text
        If strpayrate = "" Then
            ErrorProvider1.SetError(txtpayrate, "payrate required")
            txtpayrate.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtpayrate, String.Empty)
            txtpayrate.BackColor = Color.White
            ' myemp.FirstName = strfname
        End If
    End Sub

    'Private Sub cbodept_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    Dim selecteddept As Integer
    '    If loadorreset = True Then

    '        selecteddept = DirectCast(cbodept.SelectedValue, Department).DeptID
    '        MsgBox(selecteddept)
    '        'clear cbosupers
    '        'load cbosupers in that dept
    '        LoadJobsDropdown(selecteddept)
    '        'clear jobs
    '        'load jobs in that dept
    '    Else

    '    End If


    'End Sub


    Private Sub cbodept_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbodept.SelectionChangeCommitted

        Dim selecteddept As Integer = 0
        If loadorreset = True Then
            selecteddept = CInt(cbodept.SelectedValue)
            'MsgBox(selecteddept)        
            LoadJobsDropdown(selecteddept)
            'clear jobs
            'load jobs in that dept
            GetSupervisor(selecteddept)
        Else

        End If
    End Sub


 
End Class