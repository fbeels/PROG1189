Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports BOL
Imports Common
Public Class EditIItemStatus
    Inherits System.Web.UI.Page
    Dim myItem As PurchaseOrderItem
    Dim myPurchaseOrder As PurchaseOrder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("id") <> Nothing Then
            myItem = PurchaseOrderItemFactory.Create(Request.QueryString("id"))

            lblName.Text = myItem.ItemName
            lblDesc.Text = myItem.Description
            lblID.Text = myItem.ItemID
            lblJustification.Text = myItem.Justification
            lblPrice.Text = myItem.Price.ToString("C2")
            lblQuantity.Text = myItem.Quantity.ToString("C2")

            lblReason.Visible = False
            txtReason.Visible = False

            myPurchaseOrder = PurchaseOrderFactory.Create(myItem.PurchaseOrderID)

            If myPurchaseOrder.Status = OrderStatus.Closed Then
                txtReason.Enabled = False
                ddlStatus.Enabled = False
                btnSubmit.Enabled = False
            End If
        Else
            Response.Redirect("SearchPOSupervisor.aspx")
        End If
    End Sub

    Private Sub ddlStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlStatus.SelectedIndexChanged
        If ddlStatus.SelectedIndex = 2 Then
            lblReason.Visible = True
            txtReason.Visible = True
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case ddlStatus.SelectedIndex
            Case 1
                PurchaseOrderItem.approveItem(myItem)
                PurchaseOrder.markUnderReview(myPurchaseOrder)
            Case 2
                PurchaseOrderItem.denyItem(myItem, txtReason.Text)
                PurchaseOrder.markUnderReview(myPurchaseOrder)
        End Select
    End Sub

    Protected Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Response.Redirect("ProcessPO.aspx?id=" & myItem.PurchaseOrderID)
    End Sub
End Class