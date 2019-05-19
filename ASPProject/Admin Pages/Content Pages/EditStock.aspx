<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Pages/Admin.Master" AutoEventWireup="true" CodeBehind="EditStock.aspx.cs" Inherits="ASPProject.Admin_Pages.WebForm2" %>
<asp:Content ID="Edit_Stock" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; width:50%;">
            Product List:
            <br />
            <asp:ListBox ID="ProductListBox" runat="server" DataSourceID="GMBDataSource" DataTextField="product_name" DataValueField="product_name"></asp:ListBox>
            <asp:SqlDataSource ID="GMBDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="PRODUCT_GetAllProducts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            <p style="text-align:center; font-family:Verdana; color:white; font-size:28px">
                <asp:Button runat="server" ID="minusButton" Text="-" BackColor="Red" BorderColor="Red" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" />&nbsp
                <asp:Label runat="server" ID="editLabel" Text="0"></asp:Label>&nbsp
                <asp:Button runat="server" ID="plusButton" Text="+" BackColor="#66FF66" BorderColor="#66FF66" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" />
                <br />
                <asp:Button runat="server" ID="editButton" Text="EDIT" />
            </p>
    </div>
</asp:Content>
