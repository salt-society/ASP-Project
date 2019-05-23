<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="ViewTransactions.aspx.cs" Inherits="ASPProject.User_Pages.WebForm10" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:12.5%; margin-top:10%; width:75%">

        <asp:GridView ID="userTransactions" runat="server" AutoGenerateColumns="False" DataKeyNames="transaction_id" DataSourceID="GMBDataSource" style="width:100%">
            <Columns>
                <asp:BoundField DataField="product_id" HeaderText="Product ID" SortExpression="product_id" />
                <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
                <asp:BoundField DataField="date_purchased" HeaderText="Date Purchased" SortExpression="date_purchased" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="GMBDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="TRANSACTION_GetUserTransactions" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="ram" Name="user_id" SessionField="currentUser" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>
