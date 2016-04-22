﻿Public Class CreatePO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDate.Text = Date.Now.ToShortDateString

        If Not Page.IsPostBack Then
            SetInitialRow()
        End If
    End Sub


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


    Private Sub AddNewRowToGrid()

        Dim rowIndex As Integer = 0

        If ViewState("CurrentTable") IsNot Nothing Then
            Dim dtCurrentTable As DataTable = DirectCast(ViewState("CurrentTable"), DataTable)
            Dim drCurrentRow As DataRow = Nothing

            If dtCurrentTable.Rows.Count > 0 Then
                For i As Integer = 1 To dtCurrentTable.Rows.Count
                    Dim box1 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("lblName"), TextBox)
                    Dim box2 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("lblDesc"), TextBox)
                    Dim box3 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("lblPrice"), TextBox)
                    Dim box4 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("lblQ"), TextBox)
                    Dim box5 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("lblStore"), TextBox)
                    Dim box6 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("lblJust"), TextBox)
                    drCurrentRow = dtCurrentTable.NewRow()
                    drCurrentRow("RowNumber") = i + 1
                    dtCurrentTable.Rows(i - 1)("Column1") = box1.Text
                    dtCurrentTable.Rows(i - 1)("Column2") = box2.Text
                    dtCurrentTable.Rows(i - 1)("Column3") = box3.Text
                    dtCurrentTable.Rows(i - 1)("Column4") = box4.Text
                    dtCurrentTable.Rows(i - 1)("Column5") = box5.Text
                    dtCurrentTable.Rows(i - 1)("Column6") = box6.Text
                    rowIndex += 1
                Next

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

    Private Sub SetPreviousData()

        Dim rowIndex As Integer = 0

        If ViewState("CurrentTable") IsNot Nothing Then
            Dim dt As DataTable = DirectCast(ViewState("CurrentTable"), DataTable)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim box1 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(1).FindControl("lblName"), TextBox)
                    Dim box2 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(2).FindControl("lblDesc"), TextBox)
                    Dim box3 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(3).FindControl("lblPrice"), TextBox)
                    Dim box4 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(4).FindControl("lblQ"), TextBox)
                    Dim box5 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(5).FindControl("lblStore"), TextBox)
                    Dim box6 As TextBox = DirectCast(Gridview1.Rows(rowIndex).Cells(6).FindControl("lblJust"), TextBox)
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


    Protected Sub ButtonAdd_Click(sender As Object, e As EventArgs)
        AddNewRowToGrid()
    End Sub

End Class
