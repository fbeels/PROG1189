﻿Imports BOL.Purchase_Order
Imports Common
Public Class SearchPOSupervisor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtEmployeeName.Text = String.Empty Then
            lblErr.Text = "Must have an employee name or partial name"
        Else
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlStatus.SelectedIndex, txtEmployeeName.Text, ddlEmployee.Text, txtSearchDate.Text, txtEndDate.Text)
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