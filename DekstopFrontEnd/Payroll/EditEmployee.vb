Imports BOL

Public Class EditEmployee
    Dim tempemp As Employee = Employee.create()
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim searchempid As Integer

        Dim idinvalid As Boolean = False
        '//////////////////////////////////////////////////////////////////////////////
        'If txtsearchid.Text = "" Then
        '    '  ErrorProvider1.SetError(txtsearchid, String.Empty)
        '    txtsearchid.BackColor = Color.Red
        '    idinvalid = True
        'Else
        '    Try
        '        tempemp.EmpID = txtsearchid.Text
        '        '     ErrorProvider1.SetError(txtsearchid, String.Empty)
        '        txtsearchid.BackColor = Color.White
        '        searchempid = txtsearchid.Text
        '    Catch ex As ConstraintException
        '        '     ErrorProvider1.SetError(txtsearchid, ex.Message)
        '        txtsearchid.BackColor = Color.Red
        '        idinvalid = True
        '    End Try
        'End If
        ' Dim strmint As String = txtmiddleinit.Text
        If IsNumeric(txtsearchid.Text) And (txtsearchid.TextLength > 0) Then
            If txtsearchid.TextLength = 8 Then
                ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchid.BackColor = Color.White
                searchempid = txtsearchid.Text
                idinvalid = False
                tempemp.EmpID = txtsearchid.Text
            Else
                ErrorProvider1.SetError(txtsearchid, "invalid employee id length")
                txtsearchid.BackColor = Color.Red
                idinvalid = True
            End If

        Else
            If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
                ErrorProvider1.SetError(txtsearchid, "employee lastname or id is required")
                txtsearchid.BackColor = Color.Red
                idinvalid = True
            Else
                ErrorProvider1.SetError(txtsearchid, "employee must be a number")
                txtsearchid.BackColor = Color.Red
                idinvalid = True
            End If


        End If

        '//////////////////////////////////////////////////////////////////////////////////
        Dim lnameinvalid As Boolean = False

        Dim searchlname As String = txtsearchlname.Text

        'If txtsearchlname.Text = "" Then
        '    '  ErrorProvider1.SetError(txtsearchid, String.Empty)
        '    txtsearchlname.BackColor = Color.Red
        '    lnameinvalid = True
        'Else
        '    Try
        '        tempemp.LastName = txtsearchlname.Text
        '        '     ErrorProvider1.SetError(txtsearchid, String.Empty)
        '        txtsearchlname.BackColor = Color.White
        '        searchlname = txtsearchlname.Text
        '    Catch ex As ConstraintException
        '        '     ErrorProvider1.SetError(txtsearchid, ex.Message)
        '        txtsearchlname.BackColor = Color.Red
        '        lnameinvalid = True
        '    End Try
        'End If
        If (txtsearchlname.Text = "") And (txtsearchid.Text = "") Then
            ErrorProvider1.SetError(txtsearchlname, "employee lastname or id is required")
            txtsearchlname.BackColor = Color.Red
            lnameinvalid = True
        Else
            ErrorProvider1.SetError(txtsearchlname, String.Empty)
            txtsearchlname.BackColor = Color.White
            searchlname = txtsearchlname.Text
            lnameinvalid = False

        End If
        If Not (txtsearchlname.Text = String.Empty) Then
            tempemp.LastName = txtsearchlname.Text
        End If

        '/////////////////////////////////////////////////////////////////////////////
        If idinvalid = True And lnameinvalid = True Then
            lstsearchresults.Enabled = False
            btnselect.Enabled = False
        Else
            Dim searchresults = New List(Of Employee)
            searchresults = Employee.search(searchempid, searchlname)
            If searchresults.Count = 0 Then
                '   MessageBox.Show("no matches")
                grbsearchresults.Visible = False
                lstsearchresults.Visible = False
                btnselect.Visible = False
                lblnomatches.Visible = True

            Else
                grbsearchresults.Visible = True
                lblnomatches.Visible = False
                lstsearchresults.Enabled = True
                btnselect.Enabled = True
                lstsearchresults.Visible = True
                btnselect.Visible = True
                lstsearchresults.DataSource = searchresults
                lstsearchresults.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
                lstsearchresults.ValueMember = "empid"     ' prop name of object to return
            End If

        End If




    End Sub


    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        grbempinfo.Visible = True

        Dim intselectedemp As Integer = lstsearchresults.SelectedValue
        lbldebug.Text = intselectedemp

        Dim emp As Employee
        emp = Employee.retrieve(intselectedemp)

        txtfirstname.Text = emp.FirstName
        txtmiddleinit.Text = emp.MiddleInt
        txtlastname.Text = emp.LastName
        dtpdateofbirth.Text = emp.DOB

        txtsin.Text = emp.SIN
        txtstreetaddress.Text = emp.Address
        txtcity.Text = emp.City

        txtpostal.Text = emp.Postal

        mtxcellphone.Text = emp.Cell
        mtxworkphone.Text = emp.Phone
        txtemail.Text = emp.Email

        dtpsenority.Text = emp.SeniorityDate
        dtpstartdate.Text = emp.JobStartDate

        dtpterminationdate.Visible = False
        lbltermination.Visible = False
        dtpterminationdate.Text = emp.TerminationDate

        If emp.TerminationDate < "9998-12-31" Then
            dtpterminationdate.Visible = True
            lbltermination.Visible = True
        End If


        Dim strprov As String = emp.Prov
        'MsgBox(strprov.ToString)
        cboProv.SelectedText = strprov.ToString

        Dim deptid As Integer = emp.DeptID

        'cbodept

        Dim allDepts = New List(Of Department)
        allDepts = Department.GetAllDepts()
        If allDepts.Count > 0 Then
            cbodept.DataSource = allDepts
            cbodept.DisplayMember = "DeptName"    ' indicate property name of obj to SHOW
            cbodept.ValueMember = "DeptId"     ' prop name of object to return
        End If

        GetSupervisor(emp.DeptID)

        LoadJobsDropdown(deptid)

        txtpayrate.Text = emp.PayRate

       


    End Sub
    Private Sub LoadJobsDropdown(ByRef deptid As Integer)
        cbojobid.DataSource = Nothing
        Dim allJobs = New List(Of Job)
        allJobs = Job.GetAllJobs4Dropdowns(deptid)
        If allJobs.Count > 0 Then
            cbojobid.DataSource = allJobs
            cbojobid.DisplayMember = "JobName"    ' indicate property name of obj to SHOW
            cbojobid.ValueMember = "JobId"     ' prop name of object to return
        End If
    End Sub
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
    Private Sub txtsearchid_GotFocus(sender As Object, e As EventArgs) Handles txtsearchid.GotFocus
        grbempinfo.Visible = False
    End Sub

    Private Sub txtsearchid_Leave(sender As Object, e As EventArgs) Handles txtsearchid.Leave
        ' Dim strmint As String = txtmiddleinit.Text
        If IsNumeric(txtsearchid.Text) And (txtsearchid.TextLength > 0) Then
            If txtsearchid.TextLength = 8 Then
                ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchid.BackColor = Color.White
            Else
                ErrorProvider1.SetError(txtsearchid, "invalid employee id length")
                txtsearchid.BackColor = Color.Red
            End If

        Else
            If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
                ErrorProvider1.SetError(txtsearchid, "employee lastname or id is required")
                txtsearchid.BackColor = Color.Red
                ''elseIf 

            Else
                ErrorProvider1.SetError(txtsearchid, "employee must be a number")
                txtsearchid.BackColor = Color.Red
            End If


        End If
    End Sub

    Private Sub txtsearchlname_GotFocus(sender As Object, e As EventArgs) Handles txtsearchlname.GotFocus
        grbempinfo.Visible = False
    End Sub


    Private Sub txtsearchlname_Leave(sender As Object, e As EventArgs) Handles txtsearchlname.Leave
        If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
            ErrorProvider1.SetError(txtsearchlname, "employee lastname or id is required")
            txtsearchlname.BackColor = Color.Red
        Else
            ErrorProvider1.SetError(txtsearchlname, String.Empty)
            txtsearchlname.BackColor = Color.White
        End If
    End Sub


    Private Sub lstsearchresults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsearchresults.SelectedIndexChanged
        grbempinfo.Visible = False
    End Sub

    Private Sub txtsearchid_TextChanged(sender As Object, e As EventArgs) Handles txtsearchid.TextChanged
        grbempinfo.Visible = False
        grbsearchresults.Visible = False
    End Sub

    Private Sub txtsearchlname_TextChanged(sender As Object, e As EventArgs) Handles txtsearchlname.TextChanged
        grbempinfo.Visible = False
        grbsearchresults.Visible = False
    End Sub


    Private Sub GetSupervisor(ByRef deptid As Integer)
        Dim superdept As Department = Department.GetADept(deptid)
        lblsuper.Text = superdept.SupervisorName
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim inputisallok As Boolean = True
            '----------------------------------------------------------------
            Dim strfname As String = txtfirstname.Text

            'validatefirstname(strfname)
            'If ErrorProvider1.GetError(txtfirstname) <> String.Empty Then
            '    inputisallok = False
            'End If

            If strfname = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtfirstname, "first name required")
                txtfirstname.BackColor = Color.Red
            Else
                inputisallok = True
                ErrorProvider1.SetError(txtfirstname, String.Empty)
                txtfirstname.BackColor = Color.White
                tempemp.FirstName = strfname
            End If


            '----------------------------------------------------------------
            ' Dim strmidinit As String = txtmiddleinit.Text
            If IsNumeric(txtmiddleinit.Text) Then
                ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")
                txtmiddleinit.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)
                txtmiddleinit.BackColor = Color.White
                tempemp.MiddleInt = txtmiddleinit.Text
            End If

            '----------------------------------------------------------------
            Dim strlname As String = txtlastname.Text
            'If strlname = "" Then
            '    inputisallok = False
            '    ErrorProvider1.SetError(txtlastname, "last name required")
            '    txtlastname.BackColor = Color.Red
            'Else
            '    inputisallok = True
            '    ErrorProvider1.SetError(txtlastname, String.Empty)
            '    txtlastname.BackColor = Color.White
            '    myemp.LastName = strlname
            'End If


            Try
                tempemp.LastName = strlname
                inputisallok = True
                ErrorProvider1.SetError(txtlastname, String.Empty)
                txtfirstname.BackColor = Color.White
            Catch ex As Exception
                inputisallok = False
                ErrorProvider1.SetError(txtlastname, ex.Message)
                txtlastname.BackColor = Color.Red
            End Try


            '----------------------------------------------------------------
            Dim dateofbirth As Date = dtpdateofbirth.Value
            tempemp.DOB = dateofbirth
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
                tempemp.SIN = strsin
            End If

            '----------------------------------------------------------------

            Dim straddress As String = txtstreetaddress.Text
            If straddress = "" Then
                ErrorProvider1.SetError(txtstreetaddress, "address required")
                txtstreetaddress.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtstreetaddress, String.Empty)
                txtstreetaddress.BackColor = Color.White
                tempemp.Address = straddress
            End If
            '----------------------------------------------------------------
            Dim strcity As String = txtcity.Text

            If strcity = "" Then
                ErrorProvider1.SetError(txtcity, "city required")
                txtcity.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtcity, String.Empty)
                txtcity.BackColor = Color.White
                tempemp.City = strcity
            End If
            '----------------------------------------------------------------
            Dim strpostal As String = txtpostal.Text

            If strpostal = "" Then
                ErrorProvider1.SetError(txtpostal, "postal required")
                txtpostal.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtpostal, String.Empty)
                txtpostal.BackColor = Color.White
                tempemp.Postal = strpostal
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
                tempemp.Cell = strcellphone
                ' inputisallok = True
                ErrorProvider1.SetError(mtxcellphone, String.Empty)
                mtxcellphone.BackColor = Color.White
            Catch ex As Exception
                ' inputisallok = False
                ErrorProvider1.SetError(mtxcellphone, ex.Message)
                mtxcellphone.BackColor = Color.Red
            End Try



            '----------------------------------------------------------------
            mtxworkphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            Dim strworkphone As String = mtxworkphone.Text
            If strworkphone = "" Then
                ErrorProvider1.SetError(mtxworkphone, "work phone required")
                mtxworkphone.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(mtxworkphone, String.Empty)
                mtxworkphone.BackColor = Color.White
                tempemp.Phone = strworkphone
            End If
            '----------------------------------------------------------------
            Dim stremail As String = txtemail.Text

            If stremail = "" Then
                ErrorProvider1.SetError(txtemail, "email required")
                txtemail.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(txtemail, String.Empty)
                txtemail.BackColor = Color.White
                tempemp.Email = stremail
            End If
            '----------------------------------------------------------------
            Dim intdept As Integer = cbodept.SelectedValue
            tempemp.DeptID = intdept
            '----------------------------------------------------------------
            'Dim intsuper As Integer = cbosupervisor.SelectedValue
            ' myemp.SupervisorID = intsuper
            tempemp.SupervisorID = lblsuperid.Text
            tempemp.supervisorName = lblsuper.Text
            '----------------------------------------------------------------
            Dim intjob As Integer = cbojobid.SelectedValue
            tempemp.JobID = intjob
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
                tempemp.PayRate = CDbl(strpayrate)
            End If
            '--------------------------------------
            Dim strprov As String = cboProv.Text
            If strprov = "" Then
                ErrorProvider1.SetError(cboProv, "item required")
                cboProv.BackColor = Color.Red
            Else
                ErrorProvider1.SetError(cboProv, String.Empty)
                cboProv.BackColor = Color.White
                ' myemp.FirstName = strfname
                tempemp.Prov = strprov
            End If

            'Dim strprov As String = cboProv.SelectedItem
            MsgBox("the prov is:" & strprov, MsgBoxStyle.OkOnly, "strprov")
            '
            '----------------------------------------------------------------

            '------------------------------------
            tempemp.PayRate = dblpayrate
            '----------------------------------------------------------------
            tempemp.SeniorityDate = Date.Now
            '----------------------------------------------------------------
            tempemp.JobStartDate = Date.Now
            '----------------------------------------------------------------
            If chkemailstub.Checked = True Then
                tempemp.EmailNotification = True
            Else
                tempemp.EmailNotification = False
            End If

            Dim done As Integer = 0
            If inputisallok = True Then
                done = Employee.update(tempemp)
            End If

            If done > 0 Then
                lbldebug.Text = "saved,Employee ID:" & done.ToString
                'MessageBox.Show("saved,Employee ID:" & done.ToString, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lbldebug.Text = "save failed,fix the errors and try again"
                'MessageBox.Show("save failed,fix the errors and try again", "info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbldebug.Text = ex.Message.ToString
        End Try
    End Sub

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbsearchresults.Visible = False
        grbempinfo.Visible = False
    End Sub
End Class