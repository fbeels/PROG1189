Imports BOL
Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports Common
Public Class CreatePO
    Dim myItems As List(Of PurchaseOrderItem)
    Dim myPurchaseOrder As PurchaseOrder
    Dim ids As Dictionary(Of String, Integer) 'id for PO and PO-Item
    Dim myEmployee As Employee

    Private Sub CreatePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myItems = New List(Of PurchaseOrderItem)
        myPurchaseOrder = New PurchaseOrder
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
        If checkForEmpty() = False Then

            For i As Integer = 0 To dgvPO.Rows.Count - 2
                'Dim item As PurchaseOrderItem = PurchaseOrderItemFactory.Create()


                'item.ItemName = dgvPO.Item("Name", i).EditedFormattedValue
                'item.Description = dgvPO.Item("Descripion", i).EditedFormattedValue
                'item.Price = dgvPO.Item("Price", i).EditedFormattedValue
                'item.Quantity = dgvPO.Item("Quantity", i).EditedFormattedValue
                'item.Source = dgvPO.Item("Store", i).EditedFormattedValue
                'item.Justification = dgvPO.Item("Justification", i).EditedFormattedValue
                'myPurchaseOrder.Items.Add(item)
                'item.ItemID = myItems.Item(i - 1).ItemID
                'If myPurchaseOrder.PurchaseOrderID = 0 Then
                '    myPurchaseOrder.OrderDate = Date.Now()
                '    myPurchaseOrder.Status = OrderStatus.Pending
                '    myPurchaseOrder.Items = myItems
                '    myPurchaseOrder.SubTotal = myPurchaseOrder.calculateSubtotal
                '    myPurchaseOrder.Tax = myPurchaseOrder.calculateTax
                '    myPurchaseOrder.Total = myPurchaseOrder.calculateTotal
                '    myPurchaseOrder.EmployeeID = ddlEmployees.Text


                '    ids = PurchaseOrderCUD.Create(myPurchaseOrder, item)
                '    myPurchaseOrder.PurchaseOrderID = ids("POID")
                'Else
                '    myPurchaseOrder.Items = myItems
                '    myPurchaseOrder.SubTotal = myPurchaseOrder.calculateSubtotal
                '    myPurchaseOrder.Tax = myPurchaseOrder.calculateTax
                '    myPurchaseOrder.Total = myPurchaseOrder.calculateTotal
                '    item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID
                '    If i = dgvPO.Rows.Count Then 'if it's the last item in the table, add it.
                '        If item.ItemName <> Nothing Then
                '            PurchaseOrderItemCUD.Insert(item)
                '        End If

                '    End If

                '    PurchaseOrderCUD.Update(myPurchaseOrder)
                '    PurchaseOrderItemCUD.Update(item)
                'End If
            Next

        End If

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

    Function checkForEmpty() As Boolean
        Dim err As Boolean = False
        For i As Integer = 0 To dgvPO.Rows.Count - 2
            For x As Integer = 0 To dgvPO.ColumnCount - 2
                If String.IsNullOrEmpty(dgvPO.Item(x, i).EditedFormattedValue.ToString) Then
                    err = True
                End If
            Next
        Next

        If err Then
            lblErr.Text = "One or more fields are empty, please fix!"
        Else
            lblErr.Text = String.Empty
        End If
        Return err
    End Function
End Class