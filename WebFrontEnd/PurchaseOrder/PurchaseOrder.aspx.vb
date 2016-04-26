Imports BOL.Purchase_Order
Imports BOL.Purchase_Order_Item
Imports BOL
Imports Common
Public Class CreatePO
    Inherits System.Web.UI.Page

    Dim myPurchaseOrder As PurchaseOrder

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


            If Not Page.IsPostBack Then
                ModifyPO()
            End If
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

    Sub ModifyPO()
        Dim rowIndex As Integer = 0

        For i As Integer = 0 To myPurchaseOrder.Items.Count - 1
            Dim box1 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
            Dim box2 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
            Dim box3 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
            Dim box4 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
            Dim box5 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
            Dim box6 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
            box1.Text = myPurchaseOrder.Items.Item(i).ItemName
            box2.Text = myPurchaseOrder.Items.Item(i).Description
            box3.Text = myPurchaseOrder.Items.Item(i).Price
            box4.Text = myPurchaseOrder.Items.Item(i).Quantity
            box5.Text = myPurchaseOrder.Items.Item(i).Source
            box6.Text = myPurchaseOrder.Items.Item(i).Justification
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
        dr = dt.NewRow()
        dr("RowNumber") = 1
        dr("Column1") = String.Empty
        dr("Column2") = String.Empty
        dr("Column3") = String.Empty
        dr("Column4") = String.Empty
        dr("Column5") = String.Empty
        dr("Column6") = String.Empty
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
    Private Sub AddNewRowToGrid(isSubmit As Boolean, isEdit As Boolean)
        Dim rowIndex As Integer = 0


        If ViewState("CurrentTable") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    Dim box1 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
                    Dim box2 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
                    Dim box3 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
                    Dim box4 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
                    Dim box5 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
                    Dim box6 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("RowNumber") = i + 1


                    If isEdit = False Then
                        Dim item As PurchaseOrderItem = PurchaseOrderItemFactory.Create()
                        item.ItemName = box1.Text
                        item.Description = box2.Text
                        item.Price = box3.Text
                        item.Quantity = box4.Text
                        item.Source = box5.Text
                        item.Justification = box6.Text

                        If rowIndex = dtCurrentTable.Rows.Count - 1 Then 'if the rowindex is equal to the rowcount AKA the last row, give it a fake index so it can be found and replaced later
                            item.ItemID = -1
                        End If

                        If myPurchaseOrder.PurchaseOrderID = 0 Then ' if PO has an id of 0 AKA not inserted then do so
                            myPurchaseOrder.Items.Add(item)
                            myPurchaseOrder.OrderDate = Date.Now
                            myPurchaseOrder.Status = OrderStatus.Pending
                            myPurchaseOrder.EmployeeID = ddlEmployee.SelectedValue
                            doTaxCalculations()

                            Dim ids As Dictionary(Of String, Integer) = PurchaseOrderCUD.Create(myPurchaseOrder, item) 'insert the PO and initial item, adding the ID's to a dict
                            myPurchaseOrder.PurchaseOrderID = ids("POID")
                            myPurchaseOrder.Items(0).ItemID = ids("ItemID")

                        Else 'if the po is already in the DB, update
                            If rowIndex = myPurchaseOrder.Items.Count Then 'if the last item, add it, calculate, insert and change id
                                myPurchaseOrder.Items.Add(item)
                                doTaxCalculations()
                                item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID
                                myPurchaseOrder.Items.Last.ItemID = PurchaseOrderItemCUD.Insert(item)
                                PurchaseOrderCUD.Update(myPurchaseOrder)


                            End If
                        End If


                        End If
                    ViewState("PO") = myPurchaseOrder

                    rowIndex += 1


                    dtCurrentTable.Rows(i - 1)("Column1") = box1.Text
                    dtCurrentTable.Rows(i - 1)("Column2") = box2.Text
                    dtCurrentTable.Rows(i - 1)("Column3") = box3.Text
                    dtCurrentTable.Rows(i - 1)("Column4") = box4.Text
                    dtCurrentTable.Rows(i - 1)("Column5") = box5.Text
                    dtCurrentTable.Rows(i - 1)("Column6") = box6.Text
                Next
                If isSubmit Then

                    Exit Sub
                End If


                dtCurrentTable.Rows.Add(drCurrentRow)
                ViewState("CurrentTable") = dtCurrentTable
                Gridview1.DataSource = dtCurrentTable
                Gridview1.DataBind()

            End If
        Else
            Response.Write("ViewState is null")
        End If
        SetPreviousData()
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
                    Dim box1 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("txtName"), TextBox)
                    Dim box2 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("txtDesc"), TextBox)
                    Dim box3 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("txtPrice"), TextBox)
                    Dim box4 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("txtQ"), TextBox)
                    Dim box5 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("txtStore"), TextBox)
                    Dim box6 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("txtJust"), TextBox)
                    box1.Text = dt.Rows(i)("Column1").ToString()
                    box2.Text = dt.Rows(i)("Column2").ToString()
                    box3.Text = dt.Rows(i)("Column3").ToString()
                    box4.Text = dt.Rows(i)("Column4").ToString()
                    box5.Text = dt.Rows(i)("Column5").ToString()
                    box6.Text = dt.Rows(i)("Column6").ToString()

                    rowIndex += 1
                Next
            End If
        End If
    End Sub



#End Region
End Class
