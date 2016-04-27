Imports BOL
Public Class RetrieveEmployee
    Dim tempemp As Employee = Employee.create()

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim searchempid As Integer

        Dim idinvalid As Boolean = False

        If txtsearchid.Text = "" Then
            '  ErrorProvider1.SetError(txtsearchid, String.Empty)
            txtsearchid.BackColor = Color.Red
            idinvalid = True
        Else
            Try
                tempemp.EmpID = txtsearchid.Text
                '     ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchid.BackColor = Color.White
                searchempid = txtsearchid.Text
            Catch ex As ConstraintException
                '     ErrorProvider1.SetError(txtsearchid, ex.Message)
                txtsearchid.BackColor = Color.Red
                idinvalid = True
            End Try
        End If

        Dim lnameinvalid As Boolean = False

        Dim searchlname As String = txtsearchlname.Text

        If txtsearchlname.Text = "" Then
            '  ErrorProvider1.SetError(txtsearchid, String.Empty)
            txtsearchlname.BackColor = Color.Red
            lnameinvalid = True
        Else
            Try
                tempemp.LastName = txtsearchlname.Text
                '     ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchlname.BackColor = Color.White
                searchlname = txtsearchlname.Text
            Catch ex As ConstraintException
                '     ErrorProvider1.SetError(txtsearchid, ex.Message)
                txtsearchlname.BackColor = Color.Red
                lnameinvalid = True
            End Try
        End If


        If idinvalid = True And lnameinvalid = True Then
            lstsearchresults.Enabled = False
            btnselect.Enabled = False
        Else
            Dim searchresults = New List(Of Employee)
            searchresults = Employee.search(searchempid, searchlname)
            If searchresults.Count = 0 Then
                '   MessageBox.Show("no matches")
                lstsearchresults.Visible = False
                btnselect.Visible = False
                lblnomatches.Visible = True

            Else
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
        dtpterminationdate.Text = emp.TerminationDate

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




        'get all employees in selected department
        Dim allempsInDept = New List(Of Employee)
        allempsInDept = Employee.GetAllEmpsInDept(deptid)
        If allempsInDept.Count > 0 Then
            cbosupervisor.DataSource = allempsInDept
            cbosupervisor.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
            cbosupervisor.ValueMember = "empid"     ' prop name of object to return
        End If



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

    'Private Sub cbodept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbodept.SelectedValueChanged
    '    MsgBox("here")
    '    Dim newdeptid As Integer = cbodept.SelectedValue
    '    LoadJobsDropdown(newdeptid)
    'End Sub

    'Private Sub cbodept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodept.SelectedIndexChanged


    'End Sub

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

   
End Class