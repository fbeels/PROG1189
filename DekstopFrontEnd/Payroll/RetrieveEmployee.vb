Imports BOL
Public Class RetrieveEmployee
    Dim tempemp As Employee = Employee.create()


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim searchempid As Integer
        Dim searchlname As String
        Dim blsearchidisfilled As Boolean = False
        Dim blsearchlnameisfilled As Boolean = False

        If txtsearchlname.Text = "" Then
            blsearchlnameisfilled = False
            ErrorProvider1.SetError(txtsearchlname, "lastname required")
        Else
            blsearchlnameisfilled = True
        End If


        If txtsearchid.Text = "" Then
            blsearchidisfilled = False
        Else
            If IsNumeric(txtsearchid.Text) = False Then
                blsearchidisfilled = False
                ErrorProvider1.SetError(txtsearchid, "employee must be a number")
            Else
                If txtsearchid.TextLength = 8 Then
                    blsearchidisfilled = True
                Else
                    blsearchidisfilled = False
                    ErrorProvider1.SetError(txtsearchid, "invalid employee id length")
                End If

            End If
        End If
        Dim idinvalid As Boolean = False
        Dim lnameinvalid As Boolean = False

        If blsearchidisfilled = False And blsearchlnameisfilled = False Then
            idinvalid = True
            lnameinvalid = True

            'ErrorProvider1.SetError(txtsearchlname, String.Empty)
            'ErrorProvider1.SetError(txtsearchid, String.Empty)
        ElseIf blsearchidisfilled = False And blsearchlnameisfilled = True Then
            ErrorProvider1.SetError(txtsearchlname, String.Empty)
            searchlname = txtsearchlname.Text
            ErrorProvider1.SetError(txtsearchid, String.Empty)
            searchempid = txtsearchid.Text
        ElseIf blsearchidisfilled = True And blsearchlnameisfilled = False Then
            ErrorProvider1.SetError(txtsearchlname, String.Empty)
            searchlname = txtsearchlname.Text
            ErrorProvider1.SetError(txtsearchid, String.Empty)
            searchempid = txtsearchid.Text
        ElseIf blsearchidisfilled = True And blsearchlnameisfilled = True Then
            ErrorProvider1.SetError(txtsearchlname, String.Empty)
            searchlname = txtsearchlname.Text
            ErrorProvider1.SetError(txtsearchid, String.Empty)
            searchempid = txtsearchid.Text
        End If

 


        '
        ''//////////////////////////////////////////////////////////////////////////////

        'If IsNumeric(txtsearchid.Text) And (txtsearchid.TextLength > 0) Then
        '    If txtsearchid.TextLength = 8 Then
        '        ErrorProvider1.SetError(txtsearchid, String.Empty)

        '        searchempid = txtsearchid.Text
        '        idinvalid = False
        '        tempemp.EmpID = txtsearchid.Text
        '    Else


        '        idinvalid = True
        '    End If

        'Else
        '    If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
        '        ErrorProvider1.SetError(txtsearchid, "employee lastname or id is required")

        '        idinvalid = True
        '    Else


        '        idinvalid = True
        '    End If


        'End If

        ''//////////////////////////////////////////////////////////////////////////////////
        'Dim lnameinvalid As Boolean = False



        'If (txtsearchlname.Text = "") And (txtsearchid.Text = "") Then
        '    ErrorProvider1.SetError(txtsearchlname, "employee lastname or id is required")

        '    lnameinvalid = True
        'Else
        '    ErrorProvider1.SetError(txtsearchlname, String.Empty)

        '    searchlname = txtsearchlname.Text
        '    lnameinvalid = False

        'End If
        'If Not (txtsearchlname.Text = String.Empty) Then
        '    tempemp.LastName = txtsearchlname.Text
        'End If

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


        txtfirstname.Enabled = False
        txtmiddleinit.Enabled = False
        txtlastname.Enabled = False
        dtpdateofbirth.Enabled = False
        txtsin.Enabled = False
        txtstreetaddress.Enabled = False
        txtcity.Enabled = False
        cboProv.Enabled = False
        txtpostal.Enabled = False
        mtxcellphone.Enabled = False
        mtxworkphone.Enabled = False
        txtemail.Enabled = False
        cbodept.Enabled = False
        cbojobid.Enabled = False
        txtpayrate.Enabled = False
        dtpsenority.Enabled = False
        dtpstartdate.Enabled = False


        '0 active,1 fired,2 retired
        Select Case emp.empstatus
            Case 0
                rdostatusActive.Checked = True
                dtpterminationdate.Visible = False
            Case 1
                rdostatusTerminated.Checked = True
                dtpterminationdate.Visible = True
                dtpterminationdate.Top = 291

            Case 2
                rdostatusRetired.Checked = True
                dtpterminationdate.Visible = True
                dtpterminationdate.Top = 264
        End Select

        dtpterminationdate.Enabled = False
        rdostatusActive.Enabled = False
        rdostatusTerminated.Enabled = False
        rdostatusRetired.Enabled = False

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

        lbldebug.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub txtsearchid_GotFocus(sender As Object, e As EventArgs) Handles txtsearchid.GotFocus
        grbempinfo.Visible = False
    End Sub

    'Private Sub txtsearchid_Leave(sender As Object, e As EventArgs) Handles txtsearchid.Leave
    '    ' Dim strmint As String = txtmiddleinit.Text
    '    If IsNumeric(txtsearchid.Text) And (txtsearchid.TextLength > 0) Then
    '        If txtsearchid.TextLength = 8 Then
    '            ErrorProvider1.SetError(txtsearchid, String.Empty)

    '        Else
    '            ErrorProvider1.SetError(txtsearchid, "invalid employee id length")

    '        End If

    '    Else
    '        If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
    '            ErrorProvider1.SetError(txtsearchid, "employee lastname or id is required")

    '            ''elseIf 

    '        Else
    '            ErrorProvider1.SetError(txtsearchid, "employee must be a number")

    '        End If


    '    End If
    'End Sub

    Private Sub txtsearchlname_GotFocus(sender As Object, e As EventArgs) Handles txtsearchlname.GotFocus
        grbempinfo.Visible = False
    End Sub

    
    'Private Sub txtsearchlname_Leave(sender As Object, e As EventArgs) Handles txtsearchlname.Leave
    '    If txtsearchlname.Text = "" And txtsearchid.Text = "" Then
    '        ErrorProvider1.SetError(txtsearchlname, "employee lastname or id is required")

    '    Else
    '        ErrorProvider1.SetError(txtsearchlname, String.Empty)

    '    End If
    'End Sub


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
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbldebug.Top = lbldebug.Top + 5
    End Sub
End Class