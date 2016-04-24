Imports BOL.Purchase_Order
Imports Common
Public Class SearchPO
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchDate.Text = Nothing Then
            loadDataGrid(PurchaseOrderList.Create(Integer.Parse(ddlEmployee.SelectedValue), txtSearchID.Text))
        Else
            loadDataGrid(PurchaseOrderList.Create(Integer.Parse(ddlEmployee.SelectedValue), Nothing, Date.Parse(txtSearchDate.Text)))
        End If

    End Sub


    Sub loadDataGrid(results As List(Of PurchaseOrderList))
        Dim Table As New DataTable
        With Table.Columns
            .Add("ID", GetType(String))
            .Add("Employee ID", GetType(Integer))
            .Add("Status", GetType(String))
            .Add("Total", GetType(String))
            .Add("Order Date", GetType(String))
        End With

        For i As Integer = 0 To results.Count - 1
            Dim Row As DataRow
            Row = Table.NewRow()
            Dim id As Integer = results.Item(i).PurchaseOrderID
            Row.Item("ID") = "<a href='PurchaseOrder.aspx?id=" & id & "' >" & id & "</a>"
            Row.Item("Employee ID") = results.Item(i).EmployeeID
            Row.Item("Status") = results.Item(i).Status.ToString
            Row.Item("Total") = results.Item(i).Total.ToString("c2")
            Row.Item("Order Date") = results.Item(i).OrderDate.ToShortDateString
            Table.Rows.Add(Row)
        Next

        dgData.DataSource = Table
        dgData.DataBind()
    End Sub
End Class