<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="ProcessPO.aspx.vb" Inherits="WebFrontEnd.ProcessPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Label Text="Do you wish to close this order?" ID="lblClose" runat="server" /><br />
    <asp:Button Text="Yes" ID="btnYes" runat="server" /> &nbsp;&nbsp; <asp:Button Text="No" ID="btnNo" runat="server" /><br />

    PO Number:<asp:Label id="lblPoNum" runat="server" />&nbsp;&nbsp;&nbsp;
    PO Creation Date:<asp:Label id="lblPoDate" runat="server" />&nbsp;&nbsp;&nbsp;
    PO Status: <asp:Label id="lblPoStatus" runat="server" /><br />
    Employee: <asp:Label id="lblEmp" runat="server" />
    <hr />
     <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>

    
        <b>Subtotal: </b>
        <asp:Label Text="" runat="server" ID="lblSubtotal" />&nbsp;|&nbsp;
      
        <b>Tax: </b>
        <asp:Label Text="" runat="server" ID="lblTax" />
       &nbsp; |&nbsp;
       
        <b>Total: </b>
        <asp:Label Text="" runat="server" ID="lblTotal" />
</asp:Content>
