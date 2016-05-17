<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="EditEmployee.aspx.vb" Inherits="WebFrontEnd.EditEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Do all JavaScript and CSS stuff here -->
     <script src="../js/jquery.js"></script>
    <script src="../js/jquery-ui.js"></script>
    <link href="../css/jquery-ui.css" rel="stylesheet" />
    <link href="../css/jquery-ui.structure.css" rel="stylesheet" />
    <link href="../css/jquery-ui.theme.css" rel="stylesheet" />
    <script>
        $(function () {
            $("#Content_txtDOB").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">  
    Personal Information:
    <hr />
    First Name:<asp:TextBox ID="txtFirst" runat="server" /><br />
    Middle Inital: <asp:TextBox ID="txtMid" runat="server" /><br />
    Last Name:<asp:TextBox id="txtLast" runat="server" /><br />
    SIN:<asp:TextBox ID="txtSIN" runat="server" /><br />
    Date Of Birth:<asp:TextBox ID="txtDOB" runat="server" /><br />
    <br />

    
    Province:<asp:DropDownList id="ddlProv" runat="server">
        <asp:ListItem Text="Ontario" />
        <asp:ListItem Text="Quebec" />
        <asp:ListItem Text="Nova-Scotia" />
        <asp:ListItem Text="New Brunswick" />
        <asp:ListItem Text="Manitoba" />
        <asp:ListItem Text="British Columbia" />
        <asp:ListItem Text="Prince Edward Island" />
        <asp:ListItem Text="Saskatchewan" />
        <asp:ListItem Text="Alberta" />
        <asp:ListItem Text="Newfoundland and Labrador" />       
    </asp:DropDownList><br />
    City:<asp:TextBox id="txtCity" runat="server" /><br />
    Street Address:<asp:TextBox id="txtStreet" runat="server" /><br />
    Postal Code:<asp:TextBox ID="txtPostal" runat="server" /><br />    <br />  
    Cell Phone: <asp:TextBox id="txtCell" runat="server" /><br />   <br />
    Employment Information:
    <hr /><br />
    Department::<asp:DropDownList id="ddlDept" runat="server">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:DropDownList> <br />
    Email:<asp:TextBox runat="server" /><br />
    Job:<asp:DropDownList id="ddlJob" runat="server">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:DropDownList> <br />
    Payrate:<asp:TextBox ID="txtPayrate" runat="server" /><br />


    <asp:Button Text="Submit" ID="btnSubmit" runat="server" />
</asp:Content>
