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
        setupEmployees()
        displayEmp()
    End Sub

    Sub setupEmployees()
        ddlEmployees.Items.Add("10000001")
        ddlEmployees.SelectedIndex = 0
    End Sub

    Sub setupDG()
        Dim Table As New DataTable
        With Table.Columns
            .Add("Name", GetType(String))
            .Add("Descripion", GetType(String))
            .Add("Price", GetType(String))
            .Add("Quantity", GetType(String))
            .Add("Store", GetType(String))
            .Add("Justification", GetType(String))
        End With

        dgvPO.DataSource = Table
    End Sub

    Private Sub dgvPO_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.RowLeave
        Dim i As Integer = e.RowIndex

        If ValidateCell(i) = False Then
            lblErr.Text = String.Empty
            Dim item As PurchaseOrderItem = PurchaseOrderItemFactory.Create()

            If i = myPurchaseOrder.Items.Count Then 'if the item at the rowindex does not already exist, create it and add it.           
                item.ItemName = dgvPO.Item("Name", i).EditedFormattedValue
                item.Description = dgvPO.Item("Descripion", i).EditedFormattedValue
                item.Price = dgvPO.Item("Price", i).EditedFormattedValue
                item.Quantity = dgvPO.Item("Quantity", i).EditedFormattedValue
                item.Source = dgvPO.Item("Store", i).EditedFormattedValue
                item.Justification = dgvPO.Item("Justification", i).EditedFormattedValue
                item.ItemID = -1

                myPurchaseOrder.Items.Insert(i, item)
            Else 'if it does exist, remove and remake

                item.ItemName = dgvPO.Item("Name", i).EditedFormattedValue
                item.Description = dgvPO.Item("Descripion", i).EditedFormattedValue
                item.Price = dgvPO.Item("Price", i).EditedFormattedValue
                item.Quantity = dgvPO.Item("Quantity", i).EditedFormattedValue
                item.Source = dgvPO.Item("Store", i).EditedFormattedValue
                item.Justification = dgvPO.Item("Justification", i).EditedFormattedValue
                item.ItemID = myPurchaseOrder.Items(i).ItemID

                myPurchaseOrder.Items(i) = item
            End If

            If myPurchaseOrder.PurchaseOrderID = 0 Then 'if the PO does not exist in the DB, make it so
                myPurchaseOrder.OrderDate = Date.Now
                myPurchaseOrder.Status = OrderStatus.Pending
                myPurchaseOrder.EmployeeID = ddlEmployees.Text

                doTaxCalculations()

                Dim ids As Dictionary(Of String, Integer) = PurchaseOrderCUD.Create(myPurchaseOrder, item) 'insert the PO and initial item, adding the ID's to a dict
                myPurchaseOrder.PurchaseOrderID = ids("POID")
                myPurchaseOrder.Items(i).ItemID = ids("ItemID")
            Else
                If item.ItemID = -1 Then

                    myPurchaseOrder.OrderDate = Date.Now
                    myPurchaseOrder.Status = OrderStatus.Pending
                    myPurchaseOrder.EmployeeID = ddlEmployees.Text
                    item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID
                    doTaxCalculations()

                    myPurchaseOrder.Items(i).ItemID = PurchaseOrderItemCUD.Insert(item)
                    PurchaseOrderCUD.Update(myPurchaseOrder)
                Else
                    myPurchaseOrder.Items(i).PurchaseOrderID = myPurchaseOrder.PurchaseOrderID

                    myPurchaseOrder.OrderDate = Date.Now
                    myPurchaseOrder.Status = OrderStatus.Pending
                    myPurchaseOrder.EmployeeID = ddlEmployees.Text
                    doTaxCalculations()

                    PurchaseOrderItemCUD.Update(item)
                    PurchaseOrderCUD.Update(myPurchaseOrder)
                End If
            End If
        End If


        lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString

    End Sub

    Private Sub ddlEmployees_DropDownClosed(sender As Object, e As EventArgs) Handles ddlEmployees.DropDownClosed
        displayEmp()
    End Sub

    Sub displayEmp()
        myEmployee = Employee.retrieve(ddlEmployees.Text)
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
            lblErr.Text = "Row " & row + 1 & " is invalid please correct"
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

    End Sub
End Class