<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="SearchPO.aspx.cs" Inherits="WebCSharp.PurchaseOrder.SearchPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="../css/style.css" rel="stylesheet" />
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


    <hr />

    Search by ID or by Date<br />
    <asp:TextBox runat="server" ID="txtSearchID" placeholder="Purchase Order ID" />
    - or - 
    <asp:TextBox runat="server" ID="txtSearchDate" placeholder="Start Date" />
    &
    <asp:TextBox runat="server" ID="txtEndDate" placeholder="End Date" />
    <br />

    <asp:Button Text="Search" runat="server" ID="btnSearch" OnClick="btnSearch_Click" /><br />
    <asp:Label Text="" ID="lblErr" runat="server" /><br />
    <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>
</asp:Content>
