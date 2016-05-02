Imports Common
Imports BOL
Public Class EditEmployee
    Inherits System.Web.UI.Page
    Dim myEmployee As Employee
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("id") Then
            myEmployee = Employee.retrieve(Request.QueryString("id"))
            txtFirst.Text = myEmployee.FirstName
            txtMid.Text = myEmployee.MiddleInt
            txtLast.Text = myEmployee.LastName

        Else
            Response.Redirect("EditEmployee.aspx?id=10000001") 'uncomment this and add URL to redirect if no ID
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class