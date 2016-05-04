<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="PurchaseOrder.aspx.vb" Inherits="WebFrontEnd.CreatePO" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div>
        <asp:DropDownList runat="server" ID="ddlEmployee">
            <asp:ListItem Value="10000001">Dude, McDude (S)</asp:ListItem>
            <asp:ListItem Value="10000003">McLoser, Quitter</asp:ListItem>
            <asp:ListItem Value="10000008">Markingston, Ronald</asp:ListItem>
            <asp:ListItem Value="10000011">Smith, John</asp:ListItem>
        </asp:DropDownList><br />

        <asp:Label runat="server" ID="lblPage" Font-Size="large" /><br />

        <b>Date: </b>
        <asp:Label runat="server" ID="lblDate" />&nbsp;|&nbsp;
       
        <b>Employee: </b>
        <asp:Label runat="server" ID="lblEmp" />&nbsp;|&nbsp;
       
        <b>Department: </b>
        <asp:Label runat="server" ID="lblDept" />&nbsp;| &nbsp;
       
        <b>Supervisor: </b>
        <asp:Label ID="lblSuper" runat="server" />

        <hr />
        <br />
        <br />
        <asp:Label ID="lblError" ForeColor="Red" runat="server" />
        <asp:GridView ID="Gridview1" runat="server" ShowFooter="true" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="RowNumber" HeaderText="Row Number" />
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQ" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Store">
                    <ItemTemplate>
                        <asp:TextBox ID="txtStore" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Justification">
                    <ItemTemplate>
                        <asp:TextBox ID="txtJust" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="No Longer Needed">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkNotNeeded" runat="server" />
                    </ItemTemplate>
                    <FooterStyle HorizontalAlign="Right" />
                    <FooterTemplate>
                        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add New Row" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button Text="Submit" ID="btnSubmit" runat="server" />
        <b>Order ID: </b>
        <asp:Label Text="" runat="server" ID="lblID" />
        <br />

        <b>Subtotal: </b>
        <asp:Label Text="" runat="server" ID="lblSubtotal" />|&nbsp;
      
        <b>Tax: </b>
        <asp:Label Text="" runat="server" ID="lblTax" />
        |&nbsp;
       
        <b>Total: </b>
        <asp:Label Text="" runat="server" ID="lblTotal" />|
   
    </div>
</asp:Content>
