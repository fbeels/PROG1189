Imports BOL
Public Class RetrieveEmployee
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
        tempemp.LastName = txtsearchlname.Text
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


        ''get all employees in selected department
        'Dim allempsInDept = New List(Of Employee)
        'allempsInDept = Employee.GetAllEmpsInDept(deptid)
        'If allempsInDept.Count > 0 Then
        '    cbosupervisor.DataSource = allempsInDept
        '    cbosupervisor.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
        '    cbosupervisor.ValueMember = "empid"     ' prop name of object to return
        'End If



        'cbojobid
        'Dim allJobs = New List(Of Job)
        'allJobs = Job.GetAllJobs4Dropdowns(deptid)
        'If allJobs.Count > 0 Then
        '    cbojobid.DataSource = allJobs
        '    cbojobid.DisplayMember = "JobName"    ' indicate property name of obj to SHOW
        '    cbojobid.ValueMember = "JobId"     ' prop name of object to return
        'End If
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
   
    Private Sub RetrieveEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbsearchresults.Visible = False
        grbempinfo.Visible = False
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
    
End Class