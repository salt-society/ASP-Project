<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="ASPProject.User_Pages.WebForm7" %>
<asp:Content ID="ViewProducts" ContentPlaceHolderID="Body" runat="server">
    <div style="width:80%; margin-left: 10%">
        <asp:GridView ID="ProductGrid" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="product_id" DataSourceID="GMBDatabaseAccess" ForeColor="#333333" GridLines="None" style="width:80%; margin-left:10%" OnSelectedIndexChanged="SendToProductPage" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="product_name" HeaderText="Product Name" ReadOnly="True" SortExpression="product_name" />
            <asp:BoundField DataField="stock" HeaderText="Stock" SortExpression="stock" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
            <asp:ImageField DataImageUrlField="image" HeaderText="Sample Image"></asp:ImageField>        
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:SqlDataSource ID="GMBDatabaseAccess" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="PRODUCT_GetAllProducts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>
</asp:Content>
