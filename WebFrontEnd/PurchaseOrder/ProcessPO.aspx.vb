Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports BOL
Imports Common
Public Class ProcessPO
    Inherits Page

    Dim myPurchaseOrder As PurchaseOrder
    Dim myEmployee As Employee

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("id") <> Nothing Then
            myPurchaseOrder = PurchaseOrderFactory.Create(Request.QueryString("id"))
            myEmployee = Employee.retrieve(myPurchaseOrder.EmployeeID)

            loadData()

            lblEmp.Text = myEmployee.FirstName & " " & myEmployee.LastName
            lblPoDate.Text = myPurchaseOrder.OrderDate.ToShortDateString
            lblPoNum.Text = myPurchaseOrder.PurchaseOrderID
            lblSubtotal.Text = myPurchaseOrder.calculateSubtotal.ToString("C2")
            lblTax.Text = myPurchaseOrder.calculateTax.ToString("C2")
            lblTotal.Text = myPurchaseOrder.calculateTotal.ToString("C2")
            lblPoStatus.Text = myPurchaseOrder.Status.ToString

            btnNo.Visible = False
            btnYes.Visible = False
            lblClose.Visible = False

            If Not Page.IsPostBack Then
                If myPurchaseOrder.Items.Exists(Function(myItem) myItem.Status = ItemStatus.Denied OrElse myItem.Status = ItemStatus.Approved) Then
                    btnNo.Visible = True
                    btnYes.Visible = True
                    lblClose.Visible = True
                ElseIf myPurchaseOrder.Items.Exists(Function(myItem) myItem.Status = ItemStatus.Pending) Then
                    PurchaseOrder.markPending(myPurchaseOrder)
                End If
            End If
        Else
            Response.Redirect("SearchPOSupervisor.aspx")
        End If
    End Sub
    Private Sub loadData()

        Dim Table As New DataTable
        With Table.Columns
            .Add("ID", GetType(String))
            .Add("Name", GetType(String))
            .Add("Description", GetType(String))
            .Add("Price", GetType(String))
            .Add("Quantity", GetType(String))
            .Add("Source", GetType(String))
            .Add("Justification", GetType(String))
            .Add("Status", GetType(String))
            .Add("Reason", GetType(String))
        End With

        For i As Integer = 0 To myPurchaseOrder.Items.Count - 1
            Dim Row As DataRow
            Row = Table.NewRow()
            Dim id As Integer = myPurchaseOrder.Items(i).ItemID
            Row.Item("ID") = "<a href='EditItemStatus.aspx?id=" & id & "' >" & id & "</a>"
            Row.Item("Name") = myPurchaseOrder.Items(i).ItemName
            Row.Item("Description") = myPurchaseOrder.Items(i).Description
            Row.Item("Price") = myPurchaseOrder.Items(i).Price
            Row.Item("Quantity") = myPurchaseOrder.Items(i).Quantity
            Row.Item("Source") = myPurchaseOrder.Items(i).Source
            Row.Item("Justification") = myPurchaseOrder.Items(i).Justification
            Row.Item("Status") = myPurchaseOrder.Items(i).Status.ToString
            Row.Item("Reason") = myPurchaseOrder.Items(i).Reason
            Table.Rows.Add(Row)
        Next

        dgData.DataSource = Table
        dgData.DataBind()
    End Sub

    Protected Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        PurchaseOrder.closeOrder(myPurchaseOrder)
    End Sub
End Class