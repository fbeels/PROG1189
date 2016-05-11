Imports BOL
Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports Common
Public Class CreatePO

    Dim myPurchaseOrder As PurchaseOrder
    Dim ids As Dictionary(Of String, Integer) 'id for PO and PO-Item
    Dim myEmployee As Employee

    Private Sub CreatePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPurchaseOrder = New PurchaseOrder
        myPurchaseOrder.Items = New List(Of PurchaseOrderItem)

        lblDate.Text = Date.Now().ToShortDateString()
        lblErr.Text = String.Empty
        lblErr.ForeColor = Color.Red
        setupDG()

        displayEmp()
    End Sub

    Sub setupDG()
        Dim Table As New DataTable
        With Table.Columns
            .Add("ID", GetType(String))
            .Add("Name", GetType(String))
            .Add("Descripion", GetType(String))
            .Add("Price", GetType(String))
            .Add("Quantity", GetType(String))
            .Add("Store", GetType(String))
            .Add("Reason", GetType(String))
            .Add("Justification", GetType(String))

            .Add("Status", GetType(String))
            .Add("No Longer Needed", GetType(Boolean))
        End With

        dgvPO.DataSource = Table
        dgvPO.Columns("Status").ReadOnly = True
        dgvPO.Columns("ID").ReadOnly = True
        dgvPO.Columns("Reason").ReadOnly = True
        dgvPO.Columns("ID").Width = 30
    End Sub

    Private Sub dgvPO_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.RowLeave
        Dim i As Integer = e.RowIndex


        If ValidateCell(i) = False Then
            lblErr.Text = String.Empty
            Dim item As PurchaseOrderItem = PurchaseOrderItemFactory.Create()


            item.ItemName = dgvPO.Item("Name", i).EditedFormattedValue
            item.Description = dgvPO.Item("Descripion", i).EditedFormattedValue
            item.Price = dgvPO.Item("Price", i).EditedFormattedValue
            item.Quantity = dgvPO.Item("Quantity", i).EditedFormattedValue
            item.Source = dgvPO.Item("Store", i).EditedFormattedValue
            item.Justification = dgvPO.Item("Justification", i).EditedFormattedValue
            item.Status = ItemStatus.Pending

            If dgvPO.Rows(i).Cells("No Longer Needed").FormattedValue Then
                dgvPO.Rows(i).Cells("Price").Value = 0
                dgvPO.Rows(i).Cells("Quantity").Value = 0
                dgvPO.Rows(i).Cells("Descripion").Value = "No longer needed"
                item.Description = "No longer needed"
                item.Price = 0
                item.Quantity = 0
                item.Status = ItemStatus.Denied
            End If
            If i = dgvPO.RowCount - 1 Then


                Dim merge As Boolean = False
                Dim mergeId As Integer
                For x As Integer = 0 To myPurchaseOrder.Items.Count - 1
                    If item.ItemName = myPurchaseOrder.Items(x).ItemName AndAlso item.Description = myPurchaseOrder.Items(x).Description AndAlso i = dgvPO.RowCount - 2 Then
                        If dgvPO.Rows.Count <> 2 Then
                            merge = True
                            mergeId = x
                            Exit For
                        End If
                    Else
                        merge = False
                    End If
                Next

                If merge Then
                    myPurchaseOrder.Items(mergeId).Quantity += item.Quantity
                    dgvPO.Rows(mergeId).Cells("Quantity").Value = myPurchaseOrder.Items(mergeId).Quantity
                    doTaxCalculations()
                    PurchaseOrderItemCUD.Update(myPurchaseOrder.Items(mergeId))
                    PurchaseOrderCUD.Update(myPurchaseOrder)
                    BeginInvoke(New Action(Sub() dgvPO.Rows.RemoveAt(i)))
                    dgvPO.Refresh()
                    Exit Sub
                End If
            End If
            If i = myPurchaseOrder.Items.Count Then 'if the item at the rowindex does not already exist, create it and add it.           
                item.ItemID = -1

                myPurchaseOrder.Items.Insert(i, item)
            Else 'if it does exist, remove and remake
                item.ItemID = myPurchaseOrder.Items(i).ItemID

                myPurchaseOrder.Items(i) = item
            End If

            If myPurchaseOrder.PurchaseOrderID = 0 Then 'if the PO does not exist in the DB, make it so
                myPurchaseOrder.OrderDate = Date.Now
                myPurchaseOrder.Status = OrderStatus.Pending
                myPurchaseOrder.EmployeeID = GLOBAL_LOGGEDIN_USERID

                doTaxCalculations()

                Dim ids As Dictionary(Of String, Integer) = PurchaseOrderCUD.Create(myPurchaseOrder, item) 'insert the PO and initial item, adding the ID's to a dict
                myPurchaseOrder.PurchaseOrderID = ids("POID")
                myPurchaseOrder.Items(i).ItemID = ids("ItemID")
            Else
                If item.ItemID = -1 Then

                    myPurchaseOrder.OrderDate = Date.Now
                    myPurchaseOrder.Status = OrderStatus.Pending
                    myPurchaseOrder.EmployeeID = GLOBAL_LOGGEDIN_USERID
                    item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID
                    doTaxCalculations()

                    myPurchaseOrder.Items(i).ItemID = PurchaseOrderItemCUD.Insert(item)
                    PurchaseOrderCUD.Update(myPurchaseOrder)
                Else
                    myPurchaseOrder.Items(i).PurchaseOrderID = myPurchaseOrder.PurchaseOrderID

                    myPurchaseOrder.OrderDate = Date.Now
                    myPurchaseOrder.Status = OrderStatus.Pending
                    myPurchaseOrder.EmployeeID = GLOBAL_LOGGEDIN_USERID
                    doTaxCalculations()

                    PurchaseOrderItemCUD.Update(item)
                    PurchaseOrderCUD.Update(myPurchaseOrder)
                End If
            End If
            dgvPO.Rows(i).Cells("Status").Value = item.Status.ToString
            dgvPO.Rows(i).Cells("ID").Value = item.ItemID.ToString()
        End If


        lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString
        lblStatus.Text = myPurchaseOrder.Status.ToString()

        lblStatus.Visible = True
        lblStatusLabel.Visible = True
        lblID.Visible = True
        lblIDlabel.Visible = True
    End Sub

    Private Sub ddlEmployees_DropDownClosed(sender As Object, e As EventArgs)
        displayEmp()
    End Sub

    Sub displayEmp()
        myEmployee = Employee.retrieve(GLOBAL_LOGGEDIN_USERID)
        Dim sup As Employee = Employee.retrieve(myEmployee.SupervisorID)
        lblEmp.Text = myEmployee.FirstName & " " & myEmployee.LastName
        lblDep.Text = myEmployee.DeptID
        lblSup.Text = sup.FirstName & " " & sup.LastName
    End Sub

    Function ValidateCell(row As Integer) As Boolean
        Dim err As Boolean = False
        Try
            Validation.String(dgvPO.Item("Name", row).EditedFormattedValue.ToString)
            Validation.String(dgvPO.Item("Descripion", row).EditedFormattedValue.ToString)
            Validation.Double(dgvPO.Item("Price", row).EditedFormattedValue.ToString)
            Validation.Double(dgvPO.Item("Quantity", row).EditedFormattedValue.ToString)
            Validation.String(dgvPO.Item("Store", row).EditedFormattedValue.ToString)
            Validation.String(dgvPO.Item("Justification", row).EditedFormattedValue.ToString)
        Catch ex As Exception
            lblErr.Text = "Row " & row + 1 & " Is invalid please correct"
            err = True
        End Try
        Return err
    End Function

    Sub doTaxCalculations()
        myPurchaseOrder.SubTotal = myPurchaseOrder.calculateSubtotal
        myPurchaseOrder.Tax = myPurchaseOrder.calculateTax
        myPurchaseOrder.Total = myPurchaseOrder.calculateTotal

        lblSubtotal.Text = myPurchaseOrder.SubTotal.ToString("C2")
        lblTax.Text = myPurchaseOrder.Tax.ToString("C2")
        lblTotal.Text = myPurchaseOrder.Total.ToString("C2")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstResults.Items().Clear()
        lblres.Visible = True

        If dtpStart.Text = Date.Now.ToShortDateString Then
            If txtID.Text = String.Empty Then
                lblErr.Text = "Both fields are empty, try again."
                Exit Sub
            End If

            Dim results As List(Of PurchaseOrderList) = PurchaseOrderList.Create(Integer.Parse(myEmployee.EmpID), Integer.Parse(txtID.Text), Date.MinValue, Date.MaxValue)
            loadDataGrid(results)
        Else
            Dim results As List(Of PurchaseOrderList) = (PurchaseOrderList.Create(Integer.Parse(myEmployee.EmpID), Nothing, Date.Parse(dtpStart.Text), Date.Parse(dtpEnd.Text)))
            loadDataGrid(results)
        End If

    End Sub

    Sub loadDataGrid(results As List(Of PurchaseOrderList))
        lstResults.Visible = True
        For Each item As PurchaseOrderList In results
            lstResults.Items.Add(item.PurchaseOrderID & ", " & item.Total.ToString("C2") & ", " & item.OrderDate.ToShortDateString)
        Next
    End Sub

    Private Sub lstResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstResults.MouseDoubleClick
        If lstResults.SelectedItem <> Nothing Then
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
                .Add("Status", GetType(String))
                .Add("Reason", GetType(String))
                .Add("No Longer Needed", GetType(Boolean))
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
                Row.Item("Reason") = myPurchaseOrder.Items(i).Reason
                Row.Item("Justification") = myPurchaseOrder.Items(i).Justification
                If myPurchaseOrder.Status <> OrderStatus.UnderReview Then
                    Row.Item("Status") = myPurchaseOrder.Items(i).Status
                Else
                    Row.Item("Status") = "Under review"
                End If


                If myPurchaseOrder.Items(i).Description = "No longer needed" Then
                    Row.Item("No Longer Needed") = True
                Else
                    Row.Item("No Longer Needed") = False
                End If
                Row.Item("No Longer Needed") = myPurchaseOrder.Items(i).Status

                Table.Rows.Add(Row)
            Next

            dgvPO.DataSource = Table
            lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString
            lblStatus.Text = myPurchaseOrder.Status.ToString

            lblStatus.Visible = True
            lblStatusLabel.Visible = True
            lblID.Visible = True
            lblIDlabel.Visible = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Order ID " & myPurchaseOrder.PurchaseOrderID & " saved!")
    End Sub

End Class