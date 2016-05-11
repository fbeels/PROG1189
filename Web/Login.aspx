<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:DropDownList runat="server" ID="ddlEmployee">
            <asp:ListItem Value="10000001">Dude, McDude (S)</asp:ListItem>
            <asp:ListItem Value="10000003">McLoser, Quitter</asp:ListItem>
            <asp:ListItem Value="10000008">Markingston, Ronald</asp:ListItem>
            <asp:ListItem Value="10000011">Smith, John</asp:ListItem>
        </asp:DropDownList><br />
    <asp:Button Text="Log in" OnClick="Unnamed_Click" runat="server" />
</asp:Content>
