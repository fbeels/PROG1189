Imports BOL.Purchase_Order
Imports Common
Public Class SearchPOSupervisor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If ddlStatus.SelectedIndex = 0 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlEmployee.Text, OrderStatus.Pending, txtFirst.Text, txtLast.Text, IIf(txtSearchDate.Text = String.Empty, Nothing, txtSearchDate.Text), IIf(txtEndDate.Text = String.Empty, Nothing, txtEndDate.Text))
            loadDataGrid(results)
        ElseIf ddlStatus.SelectedIndex = 1 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlEmployee.Text, OrderStatus.Closed, txtFirst.Text, txtLast.Text, IIf(txtSearchDate.Text = String.Empty, Nothing, txtSearchDate.Text), IIf(txtEndDate.Text = String.Empty, Nothing, txtEndDate.Text))
            loadDataGrid(results)
        Else
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlEmployee.Text, Nothing, txtFirst.Text, txtLast.Text, IIf(txtSearchDate.Text = String.Empty, Nothing, txtSearchDate.Text), IIf(txtEndDate.Text = String.Empty, Nothing, txtEndDate.Text))
            loadDataGrid(results)
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
            Row.Item("ID") = "<a href='ProcessPO.aspx?id=" & id & "' >" & id & "</a>"
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