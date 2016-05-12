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
        Dim intselectedemp As Integer = lstsearchresults.SelectedValue
        'If tempemp.EmpID = intselectedemp Then
        'Else
        LoadEmployee(intselectedemp)
        'End If

        grbpersonal.Enabled = True
        grbjob.Enabled = False
        grbjob.Visible = False
        grbemployment.Enabled = False
        grbemployment.Visible = False

        If (GLOBAL_LOGGEDIN_USERID = intselectedemp) Then
            btnSave.Text = "cant modify own record"
            btnSave.Enabled = False
        Else
            btnSave.Text = "Save"
            btnSave.Enabled = True

        End If



    End Sub

    Private Sub btneditjobinfo_Click(sender As Object, e As EventArgs) Handles btneditjobinfo.Click
        Dim intselectedemp As Integer = lstsearchresults.SelectedValue
        'If tempemp.EmpID = intselectedemp Then
        'Else
        LoadEmployee(intselectedemp)
        'End If
        grbjob.Enabled = True
        grbjob.Visible = True
        grbpersonal.Enabled = False
        grbemployment.Enabled = False
        grbemployment.Visible = False
        If (GLOBAL_LOGGEDIN_USERID = intselectedemp) Then
            btnSave.Text = "cant modify own record"
            btnSave.Enabled = False
        Else
            btnSave.Text = "Save"
            btnSave.Enabled = True

        End If
    End Sub

    Private Sub btneditemploymentinfo_Click(sender As Object, e As EventArgs) Handles btneditemploymentinfo.Click
        Dim intselectedemp As Integer = lstsearchresults.SelectedValue
        'If tempemp.EmpID = intselectedemp Then
        'Else
        LoadEmployee(intselectedemp)
        'End If
        grbemployment.Enabled = True
        grbemployment.Visible = True
        grbpersonal.Enabled = False
        grbjob.Enabled = False
        grbjob.Visible = False
        If (GLOBAL_LOGGEDIN_USERID = intselectedemp) Then
            btnSave.Text = "cant modify own record"
            btnSave.Enabled = False
        Else
            btnSave.Text = "Save"
            btnSave.Enabled = True

        End If

    End Sub


    Private Sub LoadEmployee(ByRef intselectedemp As Integer)
        grbempinfo.Visible = True


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
        ' lbltermination.Visible = False
        dtpterminationdate.Text = emp.TerminationDate

        'If emp.TerminationDate < "2222-12-31" Then
        '    dtpterminationdate.Visible = True
        '    '   lbltermination.Visible = True
        'End If


        Dim strprov As String = emp.Prov
        'MsgBox(strprov)
        cboProv.SelectedText = ""
        cboProv.SelectedIndex = cboProv.FindStringExact(strprov)
        'cboProv.SelectedText = strprov.ToString

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

        txtempid.Text = emp.EmpID
        txtempid.Enabled = False

        Select Case emp.empstatus
            Case 0
                rdostatusActive.Checked = True
                dtpterminationdate.Visible = False
            Case 1
                rdostatusTerminated.Checked = True
                dtpterminationdate.Visible = True
                ' dtpterminationdate.Top = 291

            Case 2
                rdostatusRetired.Checked = True
                dtpterminationdate.Visible = True
                '  dtpterminationdate.Top = 264
        End Select

        If emp.CANRETIRE = True Then
            rdostatusRetired.Enabled = True
        Else
            rdostatusRetired.Enabled = False
        End If
        lbllastupdated.Text = emp.lastupdated

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
    Private Sub cbodept_SelectionChangeCommitted(sender As Object, e As EventArgs)

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

            Else
                ErrorProvider1.SetError(txtsearchid, "invalid employee id length")

            End If

        Else
            If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
                ErrorProvider1.SetError(txtsearchid, "employee lastname or id is required")

                ''elseIf 

            Else
                ErrorProvider1.SetError(txtsearchid, "employee must be a number")

            End If


        End If
    End Sub

    Private Sub txtsearchlname_GotFocus(sender As Object, e As EventArgs) Handles txtsearchlname.GotFocus
        grbempinfo.Visible = False
    End Sub


    Private Sub txtsearchlname_Leave(sender As Object, e As EventArgs) Handles txtsearchlname.Leave
        If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
            ErrorProvider1.SetError(txtsearchlname, "employee lastname or id is required")

        Else
            ErrorProvider1.SetError(txtsearchlname, String.Empty)

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
        lblsuperid.Text = superdept.SupervisorId
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim inputisallok As Boolean = True

            tempemp.EmpID = txtempid.Text
            '----------------------------------------------------------------
            Dim strfname As String = txtfirstname.Text

            'validatefirstname(strfname)
            'If ErrorProvider1.GetError(txtfirstname) <> String.Empty Then
            '    inputisallok = False
            'End If

            If strfname = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtfirstname, "first name required")

            Else
                inputisallok = True
                ErrorProvider1.SetError(txtfirstname, String.Empty)

                tempemp.FirstName = strfname
            End If


            '----------------------------------------------------------------
            ' Dim strmidinit As String = txtmiddleinit.Text
            If IsNumeric(txtmiddleinit.Text) Then
                ErrorProvider1.SetError(txtmiddleinit, "middle initial cant be a number")

            Else
                ErrorProvider1.SetError(txtmiddleinit, String.Empty)

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

            Catch ex As Exception
                inputisallok = False
                ErrorProvider1.SetError(txtlastname, ex.Message)

            End Try


            '----------------------------------------------------------------
            Dim dateofbirth As Date = dtpdateofbirth.Value
            tempemp.DOB = dateofbirth
            '    MessageBox.Show(dtpdateofbirth.ToString())
            '   MessageBox.Show(dateofbirth.ToString())
            '----------------------------------------------------------------
            Dim strsin As String = txtsin.Text
            If strsin = "" Then
                inputisallok = False
                ErrorProvider1.SetError(txtsin, "sin required")

            Else
                inputisallok = True
                ErrorProvider1.SetError(txtsin, String.Empty)

                tempemp.SIN = strsin
            End If

            '----------------------------------------------------------------

            Dim straddress As String = txtstreetaddress.Text
            If straddress = "" Then
                ErrorProvider1.SetError(txtstreetaddress, "address required")

            Else
                ErrorProvider1.SetError(txtstreetaddress, String.Empty)

                tempemp.Address = straddress
            End If
            '----------------------------------------------------------------
            Dim strcity As String = txtcity.Text

            If strcity = "" Then
                ErrorProvider1.SetError(txtcity, "city required")

            Else
                ErrorProvider1.SetError(txtcity, String.Empty)

                tempemp.City = strcity
            End If
            '----------------------------------------------------------------
            Dim strpostal As String = txtpostal.Text

            If strpostal = "" Then
                ErrorProvider1.SetError(txtpostal, "postal required")

            Else
                ErrorProvider1.SetError(txtpostal, String.Empty)

                tempemp.Postal = strpostal
            End If
            '----------------------------------------------------------------

            mtxcellphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            Dim strcellphone As String = mtxcellphone.Text




            Try
                tempemp.Cell = strcellphone
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

                tempemp.Phone = strworkphone
            End If
            '----------------------------------------------------------------
            Dim stremail As String = txtemail.Text

            If stremail = "" Then
                ErrorProvider1.SetError(txtemail, "email required")

            Else
                ErrorProvider1.SetError(txtemail, String.Empty)

                tempemp.Email = stremail
            End If
            '----------------------------------------------------------------
            Dim intdept As Integer = CInt(cbodept.SelectedValue)
            tempemp.DeptID = intdept

            '  MsgBox("the deptid is:" & intdept, MsgBoxStyle.OkOnly, "intdept")
            '----------------------------------------------------------------
            'Dim intsuper As Integer = cbosupervisor.SelectedValue
            ' myemp.SupervisorID = intsuper
            tempemp.SupervisorID = lblsuperid.Text
            tempemp.supervisorName = lblsuper.Text
            '----------------------------------------------------------------
            Dim intjob As Integer = CInt(cbojobid.SelectedValue)
            tempemp.JobID = intjob
            '  MsgBox("the jobid is:" & intjob, MsgBoxStyle.OkOnly, "intjob")

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

                tempemp.PayRate = CDbl(strpayrate)
            End If
            '--------------------------------------
            Dim strprov As String = cboProv.Text
            If strprov = "" Then
                ErrorProvider1.SetError(cboProv, "item required")

            Else
                ErrorProvider1.SetError(cboProv, String.Empty)

                ' myemp.FirstName = strfname
                tempemp.Prov = strprov
            End If

            'Dim strprov As String = cboProv.SelectedItem
            '  MsgBox("the prov is:" & strprov, MsgBoxStyle.OkOnly, "strprov")
            '
            '----------------------------------------------------------------

            '------------------------------------
            tempemp.PayRate = dblpayrate
            '----------------------------------------------------------------
            Dim SeniorityDate As Date = dtpsenority.Value
            tempemp.SeniorityDate = SeniorityDate

            '  MessageBox.Show(dtpsenority.ToString())
            '  MessageBox.Show(SeniorityDate.ToString())
            '----------------------------------------------------------------
            ' tempemp.JobStartDate = Date.Now
            Dim JobStartDate As Date = dtpstartdate.Value
            tempemp.JobStartDate = JobStartDate

            '  MessageBox.Show(dtpstartdate.ToString())
            '   MessageBox.Show(JobStartDate.ToString())

            Dim TerminationDate As Date = dtpterminationdate.Value
            tempemp.TerminationDate = TerminationDate

            '  MessageBox.Show(dtpterminationdate.ToString())
            '  MessageBox.Show(TerminationDate.ToString())
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

            ' If done > 0 Then
            ' lbldebug.Font.Size.Equals = 14
            lbldebug.Text = "saved" ',Employee ID:" & done.ToString
            'MessageBox.Show("saved,Employee ID:" & done.ToString, "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    lbldebug.Text = "save failed,fix the errors and try again"
            '    'MessageBox.Show("save failed,fix the errors and try again", "info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbldebug.Text = ex.Message.ToString
        End Try
    End Sub

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbsearchresults.Visible = False
        grbempinfo.Visible = False
    End Sub

    Private Sub dtpsenority_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpstartdate_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpterminationdate_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpdateofbirth_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdostatusRetired_CheckedChanged(sender As Object, e As EventArgs) Handles rdostatusRetired.CheckedChanged
        If rdostatusRetired.Checked Then
            dtpterminationdate.Visible = True
            dtpterminationdate.Top = 52
        End If
    End Sub

    Private Sub rdostatusActive_CheckedChanged(sender As Object, e As EventArgs) Handles rdostatusActive.CheckedChanged
        If rdostatusActive.Checked Then
            dtpterminationdate.Visible = False
        End If
    End Sub

    Private Sub rdostatusTerminated_CheckedChanged(sender As Object, e As EventArgs) Handles rdostatusTerminated.CheckedChanged
        If rdostatusTerminated.Checked Then
            dtpterminationdate.Visible = True
            dtpterminationdate.Top = 82
        End If
    End Sub

   
   
    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class