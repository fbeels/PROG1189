Imports BOL
Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports Common
Public Class ProcessPO

    Dim myPurchaseOrder As PurchaseOrder
    Dim myItem As PurchaseOrderItem
    Dim myEmp As Employee

    Private Sub ProcessPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDropdowns()

        myEmp = Employee.retrieve(GLOBAL_LOGGEDIN_USERID)

        lblSup.Text = myEmp.FirstName & " " & myEmp.LastName
        Dim dept As Department = Department.GetADept(myEmp.DeptID)
        lblDept.Text = dept.DeptName


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstResults.Items.Clear()
        gpResults.Visible = True
        If ddlStatus.SelectedIndex = 0 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(GLOBAL_LOGGEDIN_USERID, OrderStatus.Pending, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        ElseIf ddlStatus.SelectedIndex = 1 Then
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(GLOBAL_LOGGEDIN_USERID, OrderStatus.Closed, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        Else
            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(GLOBAL_LOGGEDIN_USERID, 99, txtFirst.Text, txtLast.Text, dtStart.Value.ToShortDateString, dtpEnd.Value.ToShortDateString)
            loadDataGrid(results)
        End If
    End Sub

    Sub loadDropdowns()
        ddlStatus.Items.Add("Pending")
        ddlStatus.Items.Add("Closed")
        ddlStatus.Items.Add("All")
        ddlStatus.SelectedIndex = 0

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
        If sender.SelectedIndex <> -1 Then
            Dim id As Integer = lstResults.SelectedItem.ToString.Substring(0, lstResults.SelectedItem.ToString.IndexOf(", "))

            myPurchaseOrder = PurchaseOrderFactory.Create(id)

            gpPOInfo.Visible = True
            lblID.Text = myPurchaseOrder.PurchaseOrderID
            lblStatus.Text = myPurchaseOrder.Status.ToString()

            lblTotal.Text = myPurchaseOrder.Total.ToString("c2")

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

                Row.Item("ID") = myPurchaseOrder.Items(i).ItemID
                Row.Item("Name") = myPurchaseOrder.Items(i).ItemName
                Row.Item("Descripion") = myPurchaseOrder.Items(i).Description
                Row.Item("Price") = myPurchaseOrder.Items(i).Price
                Row.Item("Quantity") = myPurchaseOrder.Items(i).Quantity
                Row.Item("Store") = myPurchaseOrder.Items(i).Source
                Row.Item("Justification") = myPurchaseOrder.Items(i).Justification
                Table.Rows.Add(Row)
            Next

            DataGridView1.DataSource = Table

            If myPurchaseOrder.Status = OrderStatus.Closed Then
                gpItems.Enabled = False
            Else
                gpItems.Enabled = True
            End If

            If myPurchaseOrder.Items.FindAll(Function(myItem) myItem.Status = ItemStatus.Denied OrElse myItem.Status = ItemStatus.Approved).Count = myPurchaseOrder.Items.Count AndAlso myPurchaseOrder.Status <> OrderStatus.Closed Then
                Dim result As Integer = MessageBox.Show("Do you wish to close this purchase order?", "Close Order", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    PurchaseOrder.closeOrder(myPurchaseOrder)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        If Not IsDBNull(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value) Then


            Dim id As Integer = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

            myItem = PurchaseOrderItemFactory.Create(id)

            gpItems.Visible = True

            txtDesc.Text = myItem.Description
            lblItemID.Text = myItem.ItemID
            txtJustification.Text = myItem.Justification
            txtItemName.Text = myItem.ItemName
            txtPrice.Text = myItem.Price
            txtQuantity.Text = myItem.Quantity
            txtSource.Text = myItem.Source

            ddlItemStatus.SelectedIndex = myItem.Status
        End If
    End Sub



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.Equals(myItem.ItemName, txtItemName.Text) = False OrElse String.Equals(myItem.Description, txtDesc.Text) = False OrElse String.Equals(myItem.Price.ToString(), txtPrice.Text) = False OrElse String.Equals(myItem.Quantity.ToString(), txtQuantity.Text) = False OrElse String.Equals(myItem.Source, txtSource.Text) = False OrElse String.Equals(myItem.Justification, txtJustification.Text) = False Then

            If txtDenial.Text = String.Empty Then
                MsgBox("Must provide a reason to change the item.")
                Exit Sub
            Else
                myItem.ItemName = txtItemName.Text
                myItem.Description = txtDesc.Text
                myItem.Price = txtPrice.Text
                myItem.Quantity = txtQuantity.Text
                myItem.Source = txtSource.Text
                myItem.Justification = txtJustification.Text
                myItem.Reason = txtDenial.Text
            End If
        End If

        If ddlItemStatus.SelectedIndex = 2 Then
            If txtDenial.Text = String.Empty Then
                MessageBox.Show("Please add a reason for cancellation")
            Else
                PurchaseOrderItem.denyItem(myItem, txtDenial.Text)
                MsgBox("Item denied.")
            End If
        ElseIf ddlItemStatus.SelectedIndex = 1 Then
            PurchaseOrderItem.approveItem(myItem)
            MsgBox("Item approved.")
        End If

        If myPurchaseOrder.Items.FindAll(Function(myItem) myItem.Status = ItemStatus.Denied OrElse myItem.Status = ItemStatus.Approved).Count = myPurchaseOrder.Items.Count AndAlso myPurchaseOrder.Status <> OrderStatus.Closed Then
            Dim result As Integer = MessageBox.Show("Do you wish to close this purchase order?", "Close Order", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                PurchaseOrder.closeOrder(myPurchaseOrder)
            End If
        End If
    End Sub
End Class