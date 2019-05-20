<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Pages/Admin.Master" AutoEventWireup="true" CodeBehind="EditStock.aspx.cs" Inherits="ASPProject.Admin_Pages.WebForm2" %>
<asp:Content ID="Edit_Stock" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; width:50%;">
            Product List:
            <br />
            <asp:DropDownList ID="ProductListBox" runat="server" DataSourceID="GMBDataSource" DataTextField="product_name" DataValueField="product_name" OnSelectedIndexChanged="ResetValue" AutoPostBack="True"></asp:DropDownList>
            <span style="margin-left:50%">
                <asp:Label runat="server" ID="stockCountLabel" Text=""></asp:Label>
            </span>
            <asp:SqlDataSource ID="GMBDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="PRODUCT_GetAllProducts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            <p style="text-align:center; font-family:Verdana; color:white; font-size:28px">
                <asp:Button runat="server" ID="minusButton" Text="-" BackColor="Red" BorderColor="Red" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" OnClick="ChangeInput" />&nbsp
                <asp:Label runat="server" ID="editLabel" Text="0"></asp:Label>&nbsp
                <asp:Button runat="server" ID="plusButton" Text="+" BackColor="#66FF66" BorderColor="#66FF66" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" OnClick="ChangeInput" />
                <br />
                <asp:Button runat="server" ID="editButton" Text="EDIT" OnClick="EditStock" />
            </p>
    </div>
</asp:Content>
 