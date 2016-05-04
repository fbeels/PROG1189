Imports BOL

Public Class main

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs)
        If TabControl1.Contains(AddEmployee) Then
            TabControl1.TabPages(AddEmployee).Select()
        Else
            TabControl1.TabPages.Add(AddEmployee)
        End If
    End Sub

    Private Sub btnsearchEmp_Click(sender As Object, e As EventArgs)
        If TabControl1.Contains(RetrieveEmployee) Then
            TabControl1.TabPages(RetrieveEmployee).Select()
        Else
            TabControl1.TabPages.Add(RetrieveEmployee)
        End If
    End Sub

    Private Sub btnmodemp_Click(sender As Object, e As EventArgs)

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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
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
        'If TabControl1.Contains(ModifyPO) Then
        '    TabControl1.TabPages(ModifyPO).Select()
        'Else
        '    TabControl1.TabPages.Add(ModifyPO)
        'End If
    End Sub


    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load

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
                MsgBox("yea payday and BOOOOO it has been run")

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
                MsgBox("NOT payday")
            End If




    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        AboutBox1.ShowDialog()
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
End Class