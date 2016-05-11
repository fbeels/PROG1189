<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPayStubs.aspx.cs" Inherits="Web.Payroll.SearchPayStubs" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &lt;logged in user&gt;&nbsp;&nbsp;&nbsp;&nbsp; Start Date:&nbsp; &lt;date picker&gt;&nbsp;&nbsp;&nbsp; End Date : &lt;date picker&gt;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" />
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
    </form>
</body>
</html>
