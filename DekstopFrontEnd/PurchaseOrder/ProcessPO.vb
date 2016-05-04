Imports BOL
Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports Common
Public Class ProcessPO


    Dim myPurchaseOrder As PurchaseOrder
    Dim myItem As PurchaseOrderItem

    Private Sub ProcessPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDropdowns()


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ddlStatus.SelectedIndex = 0 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlSupervisors.Text, OrderStatus.Pending, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        ElseIf ddlStatus.SelectedIndex = 1 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlSupervisors.Text, OrderStatus.Closed, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        Else
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(ddlSupervisors.Text, Nothing, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        End If
    End Sub

    Sub loadDropdowns()
        ddlStatus.Items.Add("Pending")
        ddlStatus.Items.Add("Approved")
        ddlStatus.Items.Add("Denied")
        ddlStatus.SelectedIndex = 0

        ddlSupervisors.Items.Add("10000002")
        ddlSupervisors.Items.Add("10000007")
        ddlSupervisors.SelectedIndex = 0


        ddlItemStatus.Items.Add("Pending")
        ddlItemStatus.Items.Add("Approved")
        ddlItemStatus.Items.Add("Denied")
        ddlItemStatus.SelectedIndex = 0
    End Sub


    Sub loadDataGrid(results As List(Of PurchaseOrderList))
        For i As Integer = 0 To results.Count - 1
            Dim x As Employee = Employee.retrieve(results(i).EmployeeID)
            lstResults.Items.Add(results(i).PurchaseOrderID & ", " & x.FirstName & ", " & x.LastName & ", " & results(i).OrderDate & ", " & results(i).Total)
        Next
    End Sub

    Private Sub lstResults_DoubleClick(sender As Object, e As EventArgs) Handles lstResults.DoubleClick
        Dim id As Integer = lstResults.SelectedItem.ToString.Substring(0, lstResults.SelectedItem.ToString.IndexOf(", "))

        myPurchaseOrder = PurchaseOrderFactory.Create(id)
        Dim Table As New DataTable
        With Table.Columns
            .Add("ID", GetType(String))
            .Add("Name", GetType(String))
            .Add("Descripion", GetType(String))
            .Add("Price", GetType(String))
            .Add("Quantity", GetType(String))
            .Add("Store", GetType(String))
            .Add("Justification", GetType(String))
        End With

        For i As Integer = 0 To myPurchaseOrder.Items.Count - 1
            Dim Row As DataRow
            Row = Table.NewRow()

            Row.Item("ID") = myPurchaseOrder.PurchaseOrderID
            Row.Item("Name") = myPurchaseOrder.Items(i).ItemName
            Row.Item("Descripion") = myPurchaseOrder.Items(i).Description
            Row.Item("Price") = myPurchaseOrder.Items(i).Price
            Row.Item("Quantity") = myPurchaseOrder.Items(i).Quantity
            Row.Item("Store") = myPurchaseOrder.Items(i).Source
            Row.Item("Justification") = myPurchaseOrder.Items(i).Justification
            Table.Rows.Add(Row)
        Next

        DataGridView1.DataSource = Table
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim id As Integer = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

        myItem = PurchaseOrderItemFactory.Create(id)

        gpItems.Visible = True

        lblDesc.Text = myItem.Description
        lblItemID.Text = myItem.ItemID
        lblJust.Text = myItem.Justification
        lblName.Text = myItem.ItemName
        lblPrice.Text = myItem.Price
        lblQuantity.Text = myItem.Quantity
        ddlItemStatus.SelectedIndex = myItem.Status
    End Sub

    Private Sub ddlItemStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlItemStatus.SelectedIndexChanged
        If ddlItemStatus.SelectedIndex = 2 Then
            txtDenial.Visible = True
            lblDenial.Visible = True
        Else
            txtDenial.Visible = False
            lblDenial.Visible = False
        End If
    End Sub
End Class