<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Acme.Master" CodeBehind="CreatePO.aspx.vb" Inherits="WebFrontEnd.CreatePO" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div>
        <asp:DropDownList runat="server" ID="ddlEmployee">
            <asp:ListItem>10000001</asp:ListItem>
            
        </asp:DropDownList><br />

        Date:<asp:Label runat="server" ID="lblDate" />
        Employee: 
        <asp:Label runat="server" ID="lblEmp" />
        Department:
        <asp:Label runat="server" ID="lblDept" />Supervisor:<asp:Label ID="lblSuper" runat="server" />
        <hr />
        <br />
        <br />

        <asp:TextBox runat="server" ID="t" />

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
                    <FooterStyle HorizontalAlign="Right" />
                    <FooterTemplate>
                        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add New Row" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button Text="Submit" ID="btnSubmit" runat="server" />
    </div>
</asp:Content>
