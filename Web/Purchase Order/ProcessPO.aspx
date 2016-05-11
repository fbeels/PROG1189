<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="ProcessPO.aspx.cs" Inherits="WebCSharp.PurchaseOrder.ProcessPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Label Text="Do you wish to close this order?" ID="lblClose" runat="server" /><br />
    <asp:Button Text="Yes" OnClick="btnYes_Click" ID="btnYes" runat="server" />
    &nbsp;&nbsp;
    <asp:Button Text="No" ID="btnNo" runat="server" /><br />

    PO Number:<asp:Label ID="lblPoNum" runat="server" />&nbsp;&nbsp;&nbsp;
    PO Creation Date:<asp:Label ID="lblPoDate" runat="server" />&nbsp;&nbsp;&nbsp;
    PO Status:
    <asp:Label ID="lblPoStatus" runat="server" /><br />
    Employee:
    <asp:Label ID="lblEmp" runat="server" />&nbsp;&nbsp;&nbsp; | &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblDept" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp; | &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblSupervisor" runat="server"></asp:Label>
    <hr />
    <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>

    <br />
    <b>Subtotal: </b>
    <asp:Label Text="" runat="server" ID="lblSubtotal" />&nbsp;|&nbsp;
      
       

    <b>Tax: </b>
    <asp:Label Text="" runat="server" ID="lblTax" />
    &nbsp; |&nbsp;
       
       

    <b>Total: </b>
    <asp:Label Text="" runat="server" ID="lblTotal" />
    <br /><br />
    
    <asp:Panel runat="server" ID="pnlItemInfo">
        
        Item ID:<asp:Label ID="txtID" CssClass="txt" runat="server" /><br />
        <div id="itemDetails">
        Item Name:<asp:TextBox ID="txtName"  CssClass="txt" runat="server" /><br />
        Description:<asp:TextBox ID="txtDesc"  CssClass="txt" runat="server" /><br />
        Price:<asp:TextBox ID="txtPrice"  CssClass="txt" runat="server" /><br />
        Quantity:<asp:TextBox ID="txtQuantity"  CssClass="txt" runat="server" /><br />
        Store:<asp:TextBox ID="txtSource"  CssClass="txt" runat="server" /><br />
        Justification:<asp:TextBox ID="txtJustification"  CssClass="txt" runat="server" /><br />
        Status:<asp:DropDownList ID="ddlStatus" runat="server"  CssClass="txt" onselectedindexchanged="ddlStatus_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Pending" />
            <asp:ListItem Text="Approved" />
            <asp:ListItem Text="Denied" />
        </asp:DropDownList><br />

        <asp:Label Text="Reasoning:"  CssClass="txt" runat="server" ID="lblReason" />
        <asp:TextBox runat="server" ID="txtReason" /><br />
            </div>
        <br />
        <asp:Label id="lblMsg"  CssClass="txt" runat="server" />
        <asp:Button Text="Save Item" OnClick="btnSubmit_Click" ID="btnSubmit" runat="server" /><br />
    </asp:Panel>
</asp:Content>
