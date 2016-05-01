Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports BOL
Imports Common
Public Class CreatePO
    Inherits System.Web.UI.Page

    Dim myPurchaseOrder As PurchaseOrder
    Dim isEdit As Boolean = False
    Dim PO_ID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDate.Text = Date.Now.ToShortDateString

        If Not Page.IsPostBack Then
            SetInitialRow()

            myPurchaseOrder = New PurchaseOrder
            myPurchaseOrder.Items = New List(Of PurchaseOrderItem)
        End If

        If Request.QueryString("id") <> Nothing Then
            PO_ID = Request.QueryString("id")
            myPurchaseOrder = PurchaseOrderFactory.Create(PO_ID)
            isEdit = True
            lblPage.Text = "Modify Purchase Order"
            If Not Page.IsPostBack Then
                SetupModify()
            End If
        Else
            lblPage.Text = "Create Purchase Order"
            isEdit = False
        End If

        If IsNothing(ViewState("PO")) AndAlso IsNothing(ViewState("Items")) Then
            ViewState("PO") = myPurchaseOrder
        Else
            myPurchaseOrder = ViewState("PO")
        End If
        loadEmp()
    End Sub

    Sub loadEmp()
        Dim myEmp As Employee = Employee.retrieve(ddlEmployee.Text)
        lblEmp.Text = myEmp.FirstName & " " & myEmp.LastName
        lblDept.Text = myEmp.DeptID
        Dim sup As Employee = Employee.retrieve(myEmp.SupervisorID)
        lblSuper.Text = sup.FirstName & " " & sup.LastName
    End Sub

    Sub SetupModify()
        Dim rowIndex As Integer = 0

        For i As Integer = 0 To myPurchaseOrder.Items.Count - 1
            Dim txtName As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
            Dim txtDesc As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
            Dim txtPrice As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
            Dim txtQ As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
            Dim txtStore As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
            Dim txtJust As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
            txtName.Text = myPurchaseOrder.Items.Item(i).ItemName
            txtDesc.Text = myPurchaseOrder.Items.Item(i).Description
            txtPrice.Text = myPurchaseOrder.Items.Item(i).Price
            txtQ.Text = myPurchaseOrder.Items.Item(i).Quantity
            txtStore.Text = myPurchaseOrder.Items.Item(i).Source
            txtJust.Text = myPurchaseOrder.Items.Item(i).Justification
            rowIndex += 1
            AddNewRowToGrid(False, True)
        Next
    End Sub

#Region "Add PO/Items Controls"
    Protected Sub ButtonAdd_Click(sender As Object, e As EventArgs)
        AddNewRowToGrid(False, False)
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        AddNewRowToGrid(True, False)
    End Sub

    ''' <summary>
    ''' Sets the inital rows in the gridview
    ''' </summary>
    Private Sub SetInitialRow()
        Dim dt As New DataTable()
        Dim dr As DataRow = Nothing
        dt.Columns.Add(New DataColumn("RowNumber", GetType(String)))
        dt.Columns.Add(New DataColumn("Column1", GetType(String)))
        dt.Columns.Add(New DataColumn("Column2", GetType(String)))
        dt.Columns.Add(New DataColumn("Column3", GetType(String)))
        dt.Columns.Add(New DataColumn("Column4", GetType(String)))
        dt.Columns.Add(New DataColumn("Column5", GetType(String)))
        dt.Columns.Add(New DataColumn("Column6", GetType(String)))
        dt.Columns.Add(New DataColumn("Column7", GetType(String)))
        dt.Columns.Add(New DataColumn("Column8", GetType(Boolean)))
        dr = dt.NewRow()
        dr("RowNumber") = 1
        dr("Column1") = String.Empty
        dr("Column2") = String.Empty
        dr("Column3") = String.Empty
        dr("Column4") = String.Empty
        dr("Column5") = String.Empty
        dr("Column6") = String.Empty
        dr("Column7") = String.Empty
        dr("Column8") = False
        dt.Rows.Add(dr)
        ViewState("CurrentTable") = dt
        Gridview1.DataSource = dt
        Gridview1.DataBind()
    End Sub

    Sub doTaxCalculations()
        myPurchaseOrder.SubTotal = myPurchaseOrder.calculateSubtotal
        myPurchaseOrder.Tax = myPurchaseOrder.calculateTax
        myPurchaseOrder.Total = myPurchaseOrder.calculateTotal
    End Sub

    ''' <summary>
    ''' Adds a new row the gridview
    ''' </summary>
    Private Sub AddNewRowToGrid(isSubmit As Boolean, skipInsertLogic As Boolean)
        Dim rowIndex As Integer = 0

        If ViewState("CurrentTable") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    Dim txtName As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
                    Dim txtDesc As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
                    Dim txtPrice As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
                    Dim txtQ As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
                    Dim txtStore As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
                    Dim txtJust As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
                    Dim lblStatus As Label = DirectCast(Gridview1.Rows(rowIndex).Cells(7).FindControl("lblStatus"), Label)
                    Dim chkNotNeeded As CheckBox = DirectCast(Gridview1.Rows(rowIndex).Cells(8).FindControl("chkNotNeeded"), CheckBox)

                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("RowNumber") = i + 1

                    If skipInsertLogic = False Then

                        If rowIndex <> dtCurrentTable.Rows.Count Then
                            Dim item As PurchaseOrderItem = PurchaseOrderItemFactory.Create()

                            If chkNotNeeded.Checked Then
                                txtPrice.Text = 0
                                txtQ.Text = 0
                                txtDesc.Text = "No longer needed"
                            End If

                            Try
                                item.ItemName = Validation.String(txtName.Text)
                                item.Description = Validation.String(txtDesc.Text)

                                If txtDesc.Text <> "No longer needed" Then 'skip validation for these, since they are empty and will trigger validation
                                    item.Price = Validation.Double(txtPrice.Text)
                                    item.Quantity = Validation.String(txtQ.Text)
                                End If

                                item.Source = Validation.String(txtStore.Text)
                                item.Justification = Validation.String(txtJust.Text)
                            Catch ex As Exception
                                lblError.Text = ex.Message.ToString()
                                Exit Sub
                            End Try


                            If rowIndex = dtCurrentTable.Rows.Count - 1 Then 'if the rowindex is equal to the rowcount AKA the last row, give it a fake index so it can be found and replaced later
                                item.ItemID = -1
                            End If

                            If myPurchaseOrder.PurchaseOrderID = 0 Then ' if PO has an id of 0 AKA not inserted then do so
                                myPurchaseOrder.Items.Insert(rowIndex, item)
                                myPurchaseOrder.OrderDate = Date.Now
                                myPurchaseOrder.Status = OrderStatus.Pending
                                myPurchaseOrder.EmployeeID = ddlEmployee.SelectedValue
                                doTaxCalculations()

                                Dim ids As Dictionary(Of String, Integer) = PurchaseOrderCUD.Create(myPurchaseOrder, item) 'insert the PO and initial item, adding the ID's to a dict
                                myPurchaseOrder.PurchaseOrderID = ids("POID")
                                myPurchaseOrder.Items(rowIndex).ItemID = ids("ItemID")

                            Else 'if the po is already in the DB, update

                                Dim merge As Boolean = False
                                Dim mergeId As Integer
                                For x As Integer = 0 To myPurchaseOrder.Items.Count - 1
                                    If item.ItemName = myPurchaseOrder.Items(x).ItemName AndAlso item.Description = myPurchaseOrder.Items(x).Description AndAlso rowIndex = dtCurrentTable.Rows.Count - 1 Then
                                        merge = True
                                        mergeId = x
                                        Exit For
                                    Else
                                        merge = False
                                    End If
                                Next

                                If merge Then
                                    'merge
                                    myPurchaseOrder.Items(mergeId).Price += item.Price
                                    myPurchaseOrder.Items(mergeId).Quantity += item.Quantity
                                    doTaxCalculations()
                                    PurchaseOrderItemCUD.Update(myPurchaseOrder.Items(mergeId))
                                    PurchaseOrderCUD.Update(myPurchaseOrder)
                                    txtName.Text = String.Empty
                                    txtDesc.Text = String.Empty
                                    txtPrice.Text = String.Empty
                                    txtQ.Text = String.Empty
                                    txtStore.Text = String.Empty
                                    txtJust.Text = String.Empty
                                    lblStatus.Text = String.Empty
                                    Exit Sub
                                ElseIf rowIndex = myPurchaseOrder.Items.Count Then
                                    'insert
                                    item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID
                                    myPurchaseOrder.Items.Insert(rowIndex, item)
                                    doTaxCalculations()
                                    myPurchaseOrder.Items.Last.ItemID = PurchaseOrderItemCUD.Insert(item)
                                    PurchaseOrderCUD.Update(myPurchaseOrder)
                                Else
                                    'update
                                    item.ItemID = myPurchaseOrder.Items(rowIndex).ItemID
                                    item.PurchaseOrderID = myPurchaseOrder.Items(rowIndex).PurchaseOrderID

                                    If item.Description = "No longer needed" Then
                                        item.Status = ItemStatus.Denied
                                    End If

                                    myPurchaseOrder.Items.RemoveAt(rowIndex)
                                    myPurchaseOrder.Items.Insert(rowIndex, item)
                                    doTaxCalculations()
                                    PurchaseOrderItemCUD.Update(myPurchaseOrder.Items(rowIndex))
                                    PurchaseOrderCUD.Update(myPurchaseOrder)
                                End If
                            End If
                        End If
                    Else
                        If rowIndex <> dtCurrentTable.Rows.Count - 1 Then
                            txtName.Text = myPurchaseOrder.Items(rowIndex).ItemName
                            txtDesc.Text = myPurchaseOrder.Items(rowIndex).Description
                            txtPrice.Text = myPurchaseOrder.Items(rowIndex).Price
                            txtQ.Text = myPurchaseOrder.Items(rowIndex).Quantity
                            txtStore.Text = myPurchaseOrder.Items(rowIndex).Source
                            txtJust.Text = myPurchaseOrder.Items(rowIndex).Justification
                            lblStatus.Text = myPurchaseOrder.Items(rowIndex).Status.ToString
                        End If
                    End If
                    ViewState("PO") = myPurchaseOrder
                    If rowIndex <> dtCurrentTable.Rows.Count - 1 Then
                        lblStatus.Text = myPurchaseOrder.Items(rowIndex).Status.ToString
                    End If

                    dtCurrentTable.Rows(i - 1)("Column1") = txtName.Text
                    dtCurrentTable.Rows(i - 1)("Column2") = txtDesc.Text
                    dtCurrentTable.Rows(i - 1)("Column3") = txtPrice.Text
                    dtCurrentTable.Rows(i - 1)("Column4") = txtQ.Text
                    dtCurrentTable.Rows(i - 1)("Column5") = txtStore.Text
                    dtCurrentTable.Rows(i - 1)("Column6") = txtJust.Text
                    dtCurrentTable.Rows(i - 1)("Column7") = lblStatus.Text
                    dtCurrentTable.Rows(i - 1)("Column8") = chkNotNeeded.Checked


                    rowIndex += 1
                Next

                If isSubmit = False Then
                    dtCurrentTable.Rows.Add(drCurrentRow)
                    ViewState("CurrentTable") = dtCurrentTable
                    Gridview1.DataSource = dtCurrentTable
                    Gridview1.DataBind()
                End If
            End If
        Else
            Response.Write("ViewState is null")
        End If
        SetPreviousData()
        lblTotal.Text = myPurchaseOrder.calculateTotal.ToString("c2")
        lblTax.Text = myPurchaseOrder.calculateTax.ToString("c2")
        lblSubtotal.Text = myPurchaseOrder.calculateSubtotal.ToString("c2")
        lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString
    End Sub
    ''' <summary>
    ''' Sets the previous data in the row
    ''' </summary>
    Private Sub SetPreviousData()
        Dim rowIndex As Integer = 0

        If ViewState("CurrentTable") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim txtName As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
                    Dim txtDesc As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
                    Dim txtPrice As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
                    Dim txtQ As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
                    Dim txtStore As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
                    Dim txtJust As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
                    Dim lblStatus As Label = DirectCast(Gridview1.Rows(rowIndex).Cells(7).FindControl("lblStatus"), Label)
                    Dim chkNotNeeded As CheckBox = DirectCast(Gridview1.Rows(rowIndex).Cells(8).FindControl("chkNotNeeded"), CheckBox)
                    txtName.Text = dt.Rows(i)("Column1").ToString()
                    txtDesc.Text = dt.Rows(i)("Column2").ToString()
                    txtPrice.Text = dt.Rows(i)("Column3").ToString()
                    txtQ.Text = dt.Rows(i)("Column4").ToString()
                    txtStore.Text = dt.Rows(i)("Column5").ToString()
                    txtJust.Text = dt.Rows(i)("Column6").ToString()
                    lblStatus.Text = dt.Rows(i)("Column7").ToString()

                    If txtDesc.Text = "Not longer needed" Then
                        chkNotNeeded.Checked = True
                    Else
                        chkNotNeeded.Checked = False
                    End If


                    rowIndex += 1
                Next
            End If
        End If
    End Sub
#End Region
End Class
