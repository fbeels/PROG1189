<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div id="Content_lblPage">
        Welcome to the Acme Stuff Inc intranet portal! Please login.
    </div>

    <asp:DropDownList runat="server" ID="ddlEmployee">
        <asp:ListItem Value="10000005">Wayne, Bruce (S)</asp:ListItem>
        <asp:ListItem Value="10000007">Luthor, Lex (S)</asp:ListItem>
        <asp:ListItem Value="10000008">MarkingSton, Ronald (S)</asp:ListItem>
        <asp:ListItem Value="10000024">Newburt, John</asp:ListItem>
        <asp:ListItem Value="10000025">Potts, Pepper</asp:ListItem>
        <asp:ListItem Value="10000026">Gordon, Barbra</asp:ListItem>
    </asp:DropDownList><br />
    <asp:Button Text="Log in" OnClick="Unnamed_Click" runat="server" />
</asp:Content>
