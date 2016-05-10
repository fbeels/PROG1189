Imports BOL
Imports Common

Public Class AddEmployee
    Dim myemp As Employee = Employee.create()
    Dim DEBUG As Boolean = True
    Dim loadorreset As Boolean = False
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbcode.Text = ""
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
        LoadJobsDropdown(cbodept.SelectedValue)
        btnprefill.Visible = False

        mtxcellphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        mtxworkphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If DEBUG = True Then
            btnprefill.Visible = True
        End If
        loadorreset = True
        lblsuperid.Visible = False

        lblresult.Text = GLOBAL_LOGGEDIN_USERID

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

            validatefirstname(strfname)
            If ErrorProvider1.GetError(txtfirstname) <> String.Empty Then
                inputisallok = False
            End If




            '----------------------------------------------------------------
            ' Dim strmidinit As String = txtmiddleinit.Text
            If IsNumeric(txtmiddleinit.Text) Then
                ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")

            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)

                myemp.MiddleInt = txtmiddleinit.Text
            End If

            '----------------------------------------------------------------
            Dim strlname As String = txtlastname.Text
  


            Try
                myemp.LastName = strlname
                inputisallok = True
                ErrorProvider1.SetError(txtlastname, String.Empty)

            Catch ex As Exception
                inputisallok = False
                ErrorProvider1.SetError(txtlastname, ex.Message)

            End Try


            '----------------------------------------------------------------
            Dim dateofbirth As Date = dtpdateofbirth.Value
            myemp.DOB = dateofbirth
            '----------------------------------------------------------------
            Dim strsin As String = txtsin.Text
            If strsin = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtsin, "sin required")

            Else
                inputisallok = True
                ErrorProvider1.SetError(txtsin, String.Empty)

                myemp.SIN = strsin
            End If

            '----------------------------------------------------------------

            Dim straddress As String = txtstreetaddress.Text
            If straddress = "" Then
                ErrorProvider1.SetError(txtstreetaddress, "address required")

            Else
                ErrorProvider1.SetError(txtstreetaddress, String.Empty)

                myemp.Address = straddress
            End If
            '----------------------------------------------------------------
            Dim strcity As String = txtcity.Text

            If strcity = "" Then
                ErrorProvider1.SetError(txtcity, "city required")

            Else
                ErrorProvider1.SetError(txtcity, String.Empty)

                myemp.City = strcity
            End If
            '----------------------------------------------------------------
            Dim strpostal As String = txtpostal.Text

            If strpostal = "" Then
                ErrorProvider1.SetError(txtpostal, "postal required")

            Else
                ErrorProvider1.SetError(txtpostal, String.Empty)

                myemp.Postal = strpostal
            End If
            '----------------------------------------------------------------
            
            Dim strcellphone As String = mtxcellphone.Text
            'If strcellphone = "" Then
            '    ErrorProvider1.SetError(mtxcellphone, "cell phone required")
            '    mtxcellphone.BackColor = Color.Red
            'Else
            '    ErrorProvider1.SetError(mtxcellphone, String.Empty)
            '    mtxcellphone.BackColor = Color.White
            '    myemp.Cell = strcellphone
            'End If


            mtxcellphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            Try
                myemp.Cell = strcellphone
                ' inputisallok = True
                ErrorProvider1.SetError(mtxcellphone, String.Empty)

            Catch ex As Exception
                ' inputisallok = False
                ErrorProvider1.SetError(mtxcellphone, ex.Message)

            End Try



            '----------------------------------------------------------------
            mtxworkphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            Dim strworkphone As String = mtxworkphone.Text
            If strworkphone = "" Then
                ErrorProvider1.SetError(mtxworkphone, "work phone required")

            Else
                ErrorProvider1.SetError(mtxworkphone, String.Empty)

                myemp.Phone = strworkphone
            End If
            '----------------------------------------------------------------
            Dim stremail As String = txtemail.Text

            If stremail = "" Then
                ErrorProvider1.SetError(txtemail, "email required")

            Else
                ErrorProvider1.SetError(txtemail, String.Empty)

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

            Else
                ErrorProvider1.SetError(txtpayrate, String.Empty)

                ' myemp.FirstName = strfname
            End If
            '--------------------------------------
            Dim strprov As String = cboProv.Text
            If strprov = "" Then
                ErrorProvider1.SetError(cboProv, "item required")

            Else
                ErrorProvider1.SetError(cboProv, String.Empty)

                ' myemp.FirstName = strfname
                myemp.Prov = strprov
            End If

            'Dim strprov As String = cboProv.SelectedItem
            'MsgBox("the prov is:" & strprov, MsgBoxStyle.OkOnly, "strprov")
            '
            '----------------------------------------------------------------

            '------------------------------------
            myemp.PayRate = dblpayrate
            '----------------------------------------------------------------
            myemp.SeniorityDate = Date.Now
            '----------------------------------------------------------------
            myemp.JobStartDate = Date.Now
            '----------------------------------------------------------------
            If chkemailstub.Checked = True Then
                myemp.EmailNotification = True
            Else
                myemp.EmailNotification = False
            End If

            Dim done As Integer = 0
            If inputisallok = True Then
                done = Employee.insert(myemp)
            End If

            If done > 0 Then
                lblresult.Text = "saved,Employee ID:" & done.ToString
                lblbcode.Text = done.ToString
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


        txtmiddleinit.Text = "Q"
        ErrorProvider1.SetError(txtmiddleinit, String.Empty)


        txtlastname.Text = "Smith"
        ErrorProvider1.SetError(txtlastname, String.Empty)


        'dtpdateofbirth.Value
        txtsin.Text = "123456789"
        ErrorProvider1.SetError(txtsin, String.Empty)


        txtstreetaddress.Text = "1234 main street"
        ErrorProvider1.SetError(txtstreetaddress, String.Empty)


        txtcity.Text = "moncton"
        ErrorProvider1.SetError(txtcity, String.Empty)


        txtpostal.Text = "e1b5a3"
        ErrorProvider1.SetError(txtpostal, String.Empty)


        mtxcellphone.Text = "5061234567"
        ErrorProvider1.SetError(mtxcellphone, String.Empty)


        mtxworkphone.Text = "9027654321"
        ErrorProvider1.SetError(mtxworkphone, String.Empty)


        txtemail.Text = "jsmith@acme.com"
        ErrorProvider1.SetError(txtemail, String.Empty)


        'Dim intdept As Integer = cbodept.SelectedValue
        'Dim intsuper As Integer = cbosupervisor.SelectedValue
        'Dim intjob As Integer = cbojobid.SelectedValue
        cbodept.SelectedIndex = 0
        LoadJobsDropdown(cbodept.SelectedValue)

        lblsuperid.Text = "10000005"
        lblsupername.Text = "Bruce Wayne"

        txtpayrate.Text = "2300"
        ErrorProvider1.SetError(txtpayrate, String.Empty)


        cboProv.SelectedIndex = 1
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
        validatefirstname(strfname)
    End Sub
    Private Sub txtlastname_Leave(sender As Object, e As EventArgs) Handles txtlastname.Leave
        Dim strlname As String = txtlastname.Text


        Try
            myemp.LastName = strlname
            ' inputisallok = True
            ErrorProvider1.SetError(txtlastname, String.Empty)

        Catch ex As Exception
            ' inputisallok = False
            ErrorProvider1.SetError(txtlastname, ex.Message)

        End Try


    End Sub
    Private Sub txtmiddleinit_Leave(sender As Object, e As EventArgs) Handles txtmiddleinit.Leave
        ' Dim strmint As String = txtmiddleinit.Text
        If IsNumeric(txtmiddleinit.Text) Then
            ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")

            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)

                ' myemp.FirstName = strfname
            End If
    End Sub
    Private Sub txtstreetaddress_Leave(sender As Object, e As EventArgs) Handles txtstreetaddress.Leave
        Dim straddress As String = txtstreetaddress.Text
        If straddress = "" Then
            ErrorProvider1.SetError(txtstreetaddress, "address required")

        Else
            ErrorProvider1.SetError(txtstreetaddress, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtcity_Leave(sender As Object, e As EventArgs) Handles txtcity.Leave
        Dim strcity As String = txtcity.Text
        If strcity = "" Then
            ErrorProvider1.SetError(txtcity, "city required")

        Else
            ErrorProvider1.SetError(txtcity, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtpostal_Leave(sender As Object, e As EventArgs) Handles txtpostal.Leave
        Dim strpostal As String = txtpostal.Text
        If strpostal = "" Then
            ErrorProvider1.SetError(txtpostal, "postal required")

        Else
            ErrorProvider1.SetError(txtpostal, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub mtxcellphone_Leave(sender As Object, e As EventArgs) Handles mtxcellphone.Leave
        Dim strcellphone As String = mtxcellphone.Text
      


        Try
            myemp.Cell = strcellphone
            ' inputisallok = True
            ErrorProvider1.SetError(mtxcellphone, String.Empty)

        Catch ex As Exception
            ' inputisallok = False
            ErrorProvider1.SetError(mtxcellphone, ex.Message)

        End Try


    End Sub
    Private Sub mtxworkphone_Leave(sender As Object, e As EventArgs) Handles mtxworkphone.Leave
        Dim strworkphone As String = mtxworkphone.Text
        If strworkphone = "" Then
            ErrorProvider1.SetError(mtxworkphone, "work phone required")

        Else
            ErrorProvider1.SetError(mtxworkphone, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        Dim stremail As String = txtemail.Text
        If stremail = "" Then
            ErrorProvider1.SetError(txtemail, "email required")

        Else
            ErrorProvider1.SetError(txtemail, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtsin_Leave(sender As Object, e As EventArgs) Handles txtsin.Leave
        Dim strsin As String = txtsin.Text
        If strsin = "" Then
            ErrorProvider1.SetError(txtsin, "sin required")

        Else
            ErrorProvider1.SetError(txtsin, String.Empty)

            ' myemp.FirstName = strfname
        End If
    End Sub
    Private Sub txtpayrate_Leave(sender As Object, e As EventArgs) Handles txtpayrate.Leave
        Dim strpayrate As String = txtpayrate.Text
        If strpayrate = "" Then
            ErrorProvider1.SetError(txtpayrate, "payrate required")

        Else
            ErrorProvider1.SetError(txtpayrate, String.Empty)

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


    'Private Sub cbodept_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbodept.SelectionChangeCommitted

    '    Dim selecteddept As Integer = 0
    '    If loadorreset = True Then
    '        selecteddept = CInt(cbodept.SelectedValue)
    '        'MsgBox(selecteddept)        
    '        LoadJobsDropdown(selecteddept)
    '        'clear jobs
    '        'load jobs in that dept
    '        GetSupervisor(selecteddept)
    '    Else

    '    End If
    'End Sub
    Private Sub cbodept_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbodept.SelectionChangeCommitted

        Dim selecteddept As Integer = 0
        ' If loadorreset = True Then
        selecteddept = CInt(cbodept.SelectedValue)
        'MsgBox(selecteddept)        
        LoadJobsDropdown(selecteddept)
        'clear jobs
        'load jobs in that dept
        GetSupervisor(selecteddept)
        '  Else

        '  End If
    End Sub

    Private Sub validatefirstname(ByRef strfname As String)
        Try
            myemp.FirstName = strfname
            ' inputisallok = True
            ErrorProvider1.SetError(txtfirstname, String.Empty)

        Catch ex As Exception
            ' inputisallok = False
            ErrorProvider1.SetError(txtfirstname, ex.Message)

        End Try
    End Sub
    Private Sub validatelastname(ByRef strlname As String)
        Try
            myemp.LastName = strlname
            ' inputisallok = True
            ErrorProvider1.SetError(txtlastname, String.Empty)

        Catch ex As Exception
            ' inputisallok = False
            ErrorProvider1.SetError(txtlastname, ex.Message)

        End Try
    End Sub

End Class