<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="PaystubSearch.aspx.cs" Inherits="Web.PaystubSearch" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <script src="../js/jquery.js"></script>
    <script src="../js/jquery-ui.js"></script>
    <link href="../css/jquery-ui.css" rel="stylesheet" />
    <link href="../css/jquery-ui.structure.css" rel="stylesheet" />
    <link href="../css/jquery-ui.theme.css" rel="stylesheet" />
    <script>
        $(function () {
            $("#Content_dtpStart").datepicker();
            $("#Content_dtpEnd").datepicker();

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div>
        <asp:DropDownList runat="server" ID="ddlEmployee">
            <asp:ListItem Value="10000001">Dudette, Dude (S)</asp:ListItem>
            <asp:ListItem Value="10000003">McLoser, Quitter</asp:ListItem>
            <asp:ListItem Value="10000008">Markingston, Ronald</asp:ListItem>
            <asp:ListItem Value="10000011">Smith, John</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp; Start Date:&nbsp;
        <asp:TextBox ID="dtpStart" Text="01/01/2016" runat="server" />&nbsp;&nbsp;&nbsp; End Date :
        <asp:TextBox ID="dtpEnd" Text="5/12/2016" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Search" OnClick="Search_Click" runat="server" Text="Button" />
        <br />
        <hr />

        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="947px">
            <LocalReport ReportPath="searchpaystubs2.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="searchpayroll" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FinalProjConnectionString2 %>" SelectCommand="SearchPayStubs" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="empid" SessionField="empID" Type="Int32" />
                <asp:SessionParameter DbType="Date" Name="startdate" SessionField="startDate" />
                <asp:SessionParameter DbType="Date" Name="enddate" SessionField="endDate" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Web.FinalProjDataSet7777TableAdapters.SearchPayStubsTableAdapter" OnSelecting="ObjectDataSource1_Selecting"></asp:ObjectDataSource>
    </div>

</asp:Content>
