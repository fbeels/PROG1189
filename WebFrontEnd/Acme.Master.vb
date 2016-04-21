Public Class Acme
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

End Class