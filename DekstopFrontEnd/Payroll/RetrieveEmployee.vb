Imports BOL
Public Class RetrieveEmployee
    Dim tempemp As Employee = Employee.create()

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim searchempid As Integer

        Dim idinvalid As Boolean = False

        If txtsearchid.Text = "" Then
            '  ErrorProvider1.SetError(txtsearchid, String.Empty)
            txtsearchid.BackColor = Color.White
        Else
            Try
                tempemp.EmpID = txtsearchid.Text
                '     ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchid.BackColor = Color.White
                searchempid = txtsearchid.Text
            Catch ex As ConstraintException
                '     ErrorProvider1.SetError(txtsearchid, ex.Message)
                txtsearchid.BackColor = Color.Red
                idinvalid = True
            End Try
        End If

        Dim lnameinvalid As Boolean = False

        Dim searchlname As String = txtsearchlname.Text

        If txtsearchlname.Text = "" Then
            '  ErrorProvider1.SetError(txtsearchid, String.Empty)
            txtsearchlname.BackColor = Color.White
        Else
            Try
                tempemp.LastName = txtsearchlname.Text
                '     ErrorProvider1.SetError(txtsearchid, String.Empty)
                txtsearchlname.BackColor = Color.White
                searchlname = txtsearchlname.Text
            Catch ex As ConstraintException
                '     ErrorProvider1.SetError(txtsearchid, ex.Message)
                txtsearchlname.BackColor = Color.Red
                lnameinvalid = True
            End Try
        End If


        If idinvalid = True Or lnameinvalid = True Then
            lstsearchresults.Enabled = False
            btnselect.Enabled = False
        Else
            Dim searchresults = New List(Of Employee)
            searchresults = Employee.search(searchempid, searchlname)
            If searchresults.Count = 0 Then
                '   MessageBox.Show("no matches")
                lstsearchresults.Visible = False
                btnselect.Visible = False
                lblnomatches.Visible = True

            Else
                lblnomatches.Visible = False
                lstsearchresults.Enabled = True
                btnselect.Enabled = True
                lstsearchresults.Visible = True
                btnselect.Visible = True
                lstsearchresults.DataSource = searchresults
                lstsearchresults.DisplayMember = "lastname"    ' indicate property name of obj to SHOW
                lstsearchresults.ValueMember = "empid"     ' prop name of object to return
            End If

        End If




    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click

        Dim intselectedemp As Integer = lstsearchresults.SelectedValue
        lbldebug.Text = intselectedemp

        Dim emp As Employee
        emp = Employee.retrieve(intselectedemp)

        txtfirstname.Text = emp.FirstName
        txtmiddleinit.Text = emp.MiddleInt
        txtlastname.Text = emp.LastName
    End Sub
End Class