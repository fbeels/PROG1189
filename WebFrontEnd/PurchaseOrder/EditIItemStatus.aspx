<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="EditIItemStatus.aspx.vb" Inherits="WebFrontEnd.EditIItemStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    Item ID:<asp:Label ID="lblID" runat="server" /><br />
    Item Name:<asp:Label id="lblName" runat="server" /><br />
    Description:<asp:Label id="lblDesc" runat="server" /><br />
    Price:<asp:Label id="lblPrice" runat="server" /><br />
    Quantity:<asp:Label id="lblQuantity" runat="server" /><br />
    Justification:<asp:Label id="lblJustification" runat="server" /><br />
    Status:<asp:DropDownList id="ddlStatus" runat="server" AutoPostBack="true">
        <asp:ListItem Text="Pending" />
        <asp:ListItem Text="Approved" />
        <asp:ListItem Text="Denied" />
    </asp:DropDownList><br />
   
     <asp:Label Text="Reasoning For Denial:" runat="server" id="lblReason"/>  <asp:TextBox runat="server" id="txtReason"/><br /><br />
    

    <asp:Button Text="Submit" ID="btnSubmit" runat="server" /><br />
    <asp:Button Text="Return to Purchase Order" ID="btnReturn" runat="server" />
</asp:Content>
