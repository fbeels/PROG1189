<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="SearchPOSupervisor.aspx.cs" Inherits="WebCSharp.PurchaseOrder.SearchPOSupervisor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery.js"></script>
    <script src="../js/jquery-ui.js"></script>
    <link href="../css/jquery-ui.css" rel="stylesheet" />
    <link href="../css/jquery-ui.structure.css" rel="stylesheet" />
    <link href="../css/jquery-ui.theme.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <script>
        $(function () {
            $("#Content_txtSearchDate").datepicker();
            $("#Content_txtEndDate").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:DropDownList runat="server" ID="ddlEmployee">
        <asp:ListItem>10000005</asp:ListItem>
        <asp:ListItem>10000007</asp:ListItem>
    </asp:DropDownList><br />
    <hr />

    <br />
    Employee First:
   
    <asp:TextBox runat="server" ID="txtFirst" placeholder="Employee First Name" />
    Employee Last:
   
    <asp:TextBox runat="server" ID="txtLast" placeholder="Employee Last Name" /><br />
    Purchase Order Status:
   
    <asp:DropDownList ID="ddlStatus" runat="server">
        <asp:ListItem Text="Pending" />
        <asp:ListItem Text="Closed" />
        <asp:ListItem Text="Both" />
    </asp:DropDownList><br />
    Date Range:
   
    <asp:TextBox runat="server" ID="txtSearchDate" Text="01/01/2000" placeholder="Purchase Order Date" />
    To 
   
    <asp:TextBox runat="server" ID="txtEndDate" placeholder="Purchase Order Date" />
    <br />

    <asp:Button Text="Search" runat="server" OnClick="btnSearch_Click" ID="btnSearch" />
    <asp:Label Text="" ID="lblErr" runat="server" />
    <asp:DataGrid runat="server" ID="dgData">
    </asp:DataGrid>
</asp:Content>
