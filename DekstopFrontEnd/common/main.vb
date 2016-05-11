Imports BOL
Public Class main
    ' Global glbLoggedinUser As Integer

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        If TabControl1.Contains(AddEmployee) Then
            TabControl1.TabPages(AddEmployee).Select()
        Else
            TabControl1.TabPages.Add(AddEmployee)
        End If
    End Sub

    Private Sub btnsearchEmp_Click(sender As Object, e As EventArgs) Handles btnsearchEmp.Click
        If TabControl1.Contains(RetrieveEmployee) Then
            TabControl1.TabPages(RetrieveEmployee).Select()
        Else
            TabControl1.TabPages.Add(RetrieveEmployee)
        End If
    End Sub

    Private Sub btnmodemp_Click(sender As Object, e As EventArgs) Handles btnmodemp.Click

        If TabControl1.Contains(EditEmployee) Then
            TabControl1.TabPages(EditEmployee).Select()
        Else
            TabControl1.TabPages.Add(EditEmployee)
        End If
    End Sub

    'Private Sub btncalcpayroll_Click(sender As Object, e As EventArgs)
    '    If TabControl1.Contains(CalcPayroll) Then
    '        TabControl1.TabPages(CalcPayroll).Select()
    '    Else
    '        TabControl1.TabPages.Add(CalcPayroll)
    '    End If
    'End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AboutBox1.Show()
    End Sub

    Private Sub btncreatePO_Click(sender As Object, e As EventArgs) Handles btncreatePO.Click
        If TabControl1.Contains(CreatePO) Then
            TabControl1.TabPages(CreatePO).Select()
        Else
            TabControl1.TabPages.Add(CreatePO)
        End If
    End Sub

    Private Sub btnmodPO_Click(sender As Object, e As EventArgs) Handles btnmodPO.Click
        If TabControl1.Contains(ProcessPO) Then
            TabControl1.TabPages(ProcessPO).Select()
        Else
            TabControl1.TabPages.Add(ProcessPO)
        End If
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim allemps = New List(Of Employee)
        allemps = Employee.GetAllEmpsInDept(0)
        If allemps.Count > 0 Then
            cboUser.DataSource = allemps
            cboUser.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
            cboUser.ValueMember = "empid"     ' prop name of object to return
        End If
        GLOBAL_LOGGEDIN_USERID = cboUser.SelectedValue
        lblloggedinuserid.Text = GLOBAL_LOGGEDIN_USERID.ToString

        ' Dim thispayperiod As PayPeriod

        Dim ispayday As Boolean = PayPeriod.IsItPayday
        Dim hasrun As Boolean = PayPeriod.HasPayBeenRun

        If (ispayday = True) Then

            If (hasrun = False) Then
                'ask for passcode
                'MsgBox("yea payday and it hasnot been run")
                If TabControl1.Contains(RunPayroll) Then
                    TabControl1.TabPages(RunPayroll).Select()
                Else
                    TabControl1.TabPages.Add(RunPayroll)
                End If
            Else
                'do nothing

                ToolStripStatusLabel1.Text = "Payday. Payroll has already been run."

                '//////////////////////////////////////////
                'If TabControl1.Contains(RunPayroll) Then
                '    TabControl1.TabPages(RunPayroll).Select()
                'Else
                '    TabControl1.TabPages.Add(RunPayroll)
                'End If
                '/////////////////////////////////

            End If

        Else
            'do nothing
            ToolStripStatusLabel1.Text = "Not payday"
        End If




    End Sub



    Private Sub btnmodemp_Click_1(sender As Object, e As EventArgs) Handles btnmodemp.Click
        If TabControl1.Contains(EditEmployee) Then
            TabControl1.TabPages(EditEmployee).Select()
        Else
            TabControl1.TabPages.Add(EditEmployee)
        End If
    End Sub

    Private Sub btnviewpayroll_Click(sender As Object, e As EventArgs) Handles btnviewpayroll.Click
        If TabControl1.Contains(ViewPaystubs) Then
            TabControl1.TabPages(ViewPaystubs).Select()
        Else
            TabControl1.TabPages.Add(ViewPaystubs)
        End If
    End Sub


    Private Sub cboUser_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboUser.SelectionChangeCommitted
        GLOBAL_LOGGEDIN_USERID = cboUser.SelectedValue
        lblloggedinuserid.Text = GLOBAL_LOGGEDIN_USERID.ToString
    End Sub


    Private Sub btnsearchpaystubs_Click(sender As Object, e As EventArgs) Handles btnsearchpaystubs.Click
        If TabControl1.Contains(Form1) Then
            TabControl1.TabPages(Form1).Select()
        Else
            TabControl1.TabPages.Add(Form1)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        AboutBox1.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        If TabControl1.Contains(CreatePO) Then
            TabControl1.TabPages(CreatePO).Select()
        Else
            TabControl1.TabPages.Add(CreatePO)
        End If
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        If TabControl1.Contains(AddEmployee) Then
            TabControl1.TabPages(AddEmployee).Select()
        Else
            TabControl1.TabPages.Add(AddEmployee)
        End If
    End Sub
End Class