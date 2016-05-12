<%@ Page Title="" Language="C#" MasterPageFile="~/Acme.Master" AutoEventWireup="true" CodeBehind="PurchaseOrderPage.aspx.cs" Inherits="WebCSharp.PurchaseOrder.PurchaseOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div>      
        <asp:Label runat="server" ID="lblPage" /><br />

        <b>Date: </b>
        <asp:Label runat="server" ID="lblDate" />&nbsp;|&nbsp;
       
       

        <b>Employee: </b>
        <asp:Label runat="server" ID="lblEmp" />&nbsp;|&nbsp;
       
       

        <b>Department: </b>
        <asp:Label runat="server" ID="lblDept" />&nbsp;| &nbsp;
       
       

        <b>Supervisor: </b>
        <asp:Label ID="lblSuper" runat="server" /><br />

        <asp:Panel runat="server" ID="orderID">
            <b>Order ID: </b>
            <asp:Label Text="" runat="server" ID="lblID" />&nbsp;|&nbsp;
            <b>Order Status:</b>
            <asp:Label Text="" runat="server" ID="lblPOStatus" />
        </asp:Panel>

        <br />
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
                    <asp:TemplateField HeaderText="Reason">
                    <ItemTemplate>
                        <asp:Label ID="lblReason" runat="server"></asp:Label>
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
        <asp:Button Text="Save" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" /><br />

        <asp:Panel runat="server" ID="panMoney">

            <b>Subtotal: </b>
            <asp:Label Text="" runat="server" ID="lblSubtotal" />|&nbsp;
      
       

        <b>Tax: </b>
            <asp:Label Text="" runat="server" ID="lblTax" />
            |&nbsp;
       
       

        <b>Total: </b>
            <asp:Label Text="" runat="server" ID="lblTotal" />
        </asp:Panel>


    </div>
</asp:Content>
