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
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
       Search by ID or by Date<br />
    <asp:TextBox runat="server" id="txtSearchID" placeholder="Purchase Order ID"/> - or - 
    <asp:TextBox runat="server" id="txtSearchDate" placeholder="Purchase Order Date"/><br />

    <asp:Button Text="Search" runat="server" id="btnSearch"/>

    <asp:DataGrid runat="server" ID="dgData">    
        
    </asp:DataGrid>
</asp:Content>
