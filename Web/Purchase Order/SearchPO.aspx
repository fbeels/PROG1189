<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="SearchPO.aspx.cs" Inherits="WebCSharp.PurchaseOrder.SearchPO" %>

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
        <asp:ListItem Value="10000001">Dude, McDude (S)</asp:ListItem>
        <asp:ListItem Value="10000003">McLoser, Quitter</asp:ListItem>
        <asp:ListItem Value="10000008">Markingston, Ronald</asp:ListItem>
        <asp:ListItem Value="10000011">Smith, John</asp:ListItem>
    </asp:DropDownList><br />

    <hr />

    Search by ID or by Date<br />
    <asp:TextBox runat="server" ID="txtSearchID" placeholder="Purchase Order ID" />
    - or - 
    <asp:TextBox runat="server" ID="txtSearchDate" placeholder="Purchase Order Date" />
    &
    <asp:TextBox runat="server" ID="txtEndDate" placeholder="Purchase Order Date" />
    <br />

    <asp:Button Text="Search" runat="server" ID="btnSearch" />
    <asp:Label Text="" ID="lblErr" runat="server" />
    <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>
</asp:Content>
