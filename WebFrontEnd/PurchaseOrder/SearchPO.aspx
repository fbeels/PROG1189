<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="SearchPO.aspx.vb" Inherits="WebFrontEnd.SearchPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery.js"></script>
    <script src="../js/jquery-ui.js"></script>
    <link href="../css/jquery-ui.css" rel="stylesheet" />
    <link href="../css/jquery-ui.structure.css" rel="stylesheet" />
    <link href="../css/jquery-ui.theme.css" rel="stylesheet" />
    <script>
        $(function () {
            $("#Content_txtSearchDate").datepicker();
            $("#Content_txtEndDate").datepicker();
            
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:DropDownList runat="server" ID="ddlEmployee">
        <asp:ListItem>10000001</asp:ListItem>

    </asp:DropDownList><br />
    <hr />

    Search by ID or by Date<br />
    <asp:TextBox runat="server" ID="txtSearchID" placeholder="Purchase Order ID" />
    - or - 
    <asp:TextBox runat="server" ID="txtSearchDate" placeholder="Purchase Order Date" /> & <asp:TextBox runat="server" ID="txtEndDate" placeholder="Purchase Order Date" />  <br />

    <asp:Button Text="Search" runat="server" ID="btnSearch" />
    <asp:Label Text="" id="lblErr" runat="server" />
    <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>
</asp:Content>
