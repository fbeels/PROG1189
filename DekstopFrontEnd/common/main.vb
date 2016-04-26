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
        EditEmployee.Show()
    End Sub

    Private Sub btncalcpayroll_Click(sender As Object, e As EventArgs) Handles btncalcpayroll.Click
        CalcPayroll.Show()
    End Sub
End Class