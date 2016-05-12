<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Web.Payroll.Modify" MasterPageFile="~/Acme.Master"%>

<%--<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>--%>


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

    <table border="1">
         <tr>
            <td>employee id:</td>
            <td>
                <asp:TextBox ID="txtempid" runat="server" />
                <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtempid" ErrorMessage="Emp ID is required.">*</asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td>
                <asp:TextBox ID="txtFirst" runat="server" />
                <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtFirst" ErrorMessage="First Name is required.">*</asp:RequiredFieldValidator>
                </td>
        </tr>
    
    <tr>
            <td>Middle Inital:</td>
            <td><asp:TextBox ID="txtMid" runat="server" /></td>
        </tr>
            <tr>
            <td>Last Name:</td>
            <td><asp:TextBox id="txtLast" runat="server" />
                <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtLast" ErrorMessage="Last Name is required.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
        <tr><td>Street Address:</td><td><asp:TextBox id="txtStreet" runat="server" />
            <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtStreet" ErrorMessage="Street Address is required.">*</asp:RequiredFieldValidator>
                                    </td></tr>
        <tr><td>City:</td><td> <asp:TextBox id="txtCity" runat="server" />
             <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtCity" ErrorMessage="City is required.">*</asp:RequiredFieldValidator>
                          </td></tr>
        <tr><td>Province:</td><td><asp:DropDownList id="ddlProv" runat="server">
        <asp:ListItem Text="Ontario" Value="ON" />
        <asp:ListItem Text="Quebec" Value="QC" />
        <asp:ListItem Text="Nova-Scotia" Value="NS" />
        <asp:ListItem Text="New Brunswick" Value="NB" />
        <asp:ListItem Text="Manitoba" Value="MB" />
        <asp:ListItem Text="British Columbia" Value="BC" />
        <asp:ListItem Text="Prince Edward Island" Value="PE" />
        <asp:ListItem Text="Saskatchewan" Value="SK" />
        <asp:ListItem Text="Alberta" Value="AB" />
        <asp:ListItem Text="Newfoundland and Labrador" Value="NF" />       
    </asp:DropDownList></td></tr>
        <tr><td>Postal Code:</td><td><asp:TextBox ID="txtPostal" runat="server" />
            <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtPostal" ErrorMessage="Postal is required.">*</asp:RequiredFieldValidator>
                                 </td></tr>
        <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
       <tr><td>Cell Phone:</td><td><asp:TextBox id="txtCell" runat="server" />
            <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtCell" ErrorMessage="cell phone is required.">*</asp:RequiredFieldValidator>
                                </td></tr>
        <tr><td>Work Phone</td><td><asp:TextBox id="txtwork" runat="server" />
            <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtwork" ErrorMessage="work phone is required.">*</asp:RequiredFieldValidator>
                               </td></tr>
        <tr><td>Email</td><td><asp:TextBox id="txtemail" runat="server" />
            <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtemail" ErrorMessage="email is required.">*</asp:RequiredFieldValidator>
                          </td></tr>
       <%-- <tr><td>dob</td><td><asp:TextBox id="txtdob" runat="server" /></td></tr>
        <tr><td>sin</td><td><asp:TextBox id="txtsin" runat="server" /></td></tr>
      <tr><td>seniorityDate</td><td><asp:TextBox id="txtseniorityDate" runat="server" /></td></tr>
        <tr><td>jobstartDate</td><td><asp:TextBox id="txtjobstartDate" runat="server" /></td></tr>
        <tr><td>jobId</td><td><asp:TextBox id="txtjobId" runat="server" /></td></tr>
        <tr><td>supervisiorID</td><td><asp:TextBox id="txtsupervisiorID" runat="server" /></td></tr>
        <tr><td>emailnotificatoins</td><td><asp:TextBox id="txtemailnotificatoins" runat="server" /></td></tr>
        <tr><td>payrate</td><td><asp:TextBox id="txtpayrate" runat="server" /></td></tr>
        <tr><td>terminationDate</td><td><asp:TextBox id="txtterminationDate" runat="server" /></td></tr>
        <tr><td>deptID</td><td><asp:TextBox id="txtdeptID" runat="server" /></td></tr>
        <tr><td>empstatus</td><td><asp:TextBox id="txtempstatus" runat="server" /></td></tr>
        <tr><td>lastchanged</td><td><asp:TextBox id="txtlastchanged" runat="server" /></td></tr>--%>

</table>


    <asp:ValidationSummary runat="server" HeaderText="There were errors on the page:" />
    
    <asp:Label runat="server" id="lblresult"></asp:Label><br />
    <asp:Button Text="Submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />
</asp:Content>
