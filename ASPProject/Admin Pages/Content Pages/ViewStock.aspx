<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Pages/Admin.Master" AutoEventWireup="true" CodeBehind="ViewStock.aspx.cs" Inherits="ASPProject.Admin_Pages.WebForm1" %>
<asp:Content ID="View_Stock" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; width:50%;">
        Viewing Product Stocks
        <asp:GridView ID="StockGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="product_id" DataSourceID="GMBDataSource" AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="product_id" HeaderText="Product ID" InsertVisible="False" ReadOnly="True" SortExpression="product_id" />
            <asp:BoundField DataField="product_name" HeaderText="Product Name" SortExpression="product_name" />
            <asp:BoundField DataField="stock" HeaderText="Stock" SortExpression="stock" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="GMBDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="PRODUCT_GetAllProducts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>
</asp:Content>
