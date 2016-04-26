Public Class main

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

    Private Sub btncalcpayroll_Click(sender As Object, e As EventArgs) Handles btncalcpayroll.Click
        If TabControl1.Contains(CalcPayroll) Then
            TabControl1.TabPages(CalcPayroll).Select()
        Else
            TabControl1.TabPages.Add(CalcPayroll)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class