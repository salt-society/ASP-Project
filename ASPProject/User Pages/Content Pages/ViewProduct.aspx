<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="ASPProject.User_Pages.WebForm1" %>
<asp:Content ID="Sole_Product" ContentPlaceHolderID="Body" runat="server">
    <div>

        <asp:Image ID="productImage" style="margin-left: 10%; width: 400px; height: 300px; float:left; object-fit:fill" runat="server" ImageUrl="~/Images/Trial.png" />

        <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="descriptionLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="stockLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="priceLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button runat="server" ID="minusButton" Text="-" BackColor="Red" BorderColor="Red" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" OnClick="ChangeInput" />&nbsp
        <asp:Label runat="server" ID="editLabel" Text="1"></asp:Label>&nbsp
        <asp:Button runat="server" ID="plusButton" Text="+" BackColor="#66FF66" BorderColor="#66FF66" BorderStyle="Ridge" Font-Bold="True" Font-Names="Trebuchet MS" OnClick="ChangeInput" />
        &nbsp&nbsp
        <asp:Button runat="server" ID="addButton" Text="ADD TO CART" OnClick="AddToCart" />
    </div>
</asp:Content>
