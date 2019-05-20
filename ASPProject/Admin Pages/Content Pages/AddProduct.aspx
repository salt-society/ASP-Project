<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Pages/Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="ASPProject.Admin_Pages.WebForm3" %>
<asp:Content ID="Add_Product" ContentPlaceHolderID="Body" runat="server">
    <div style="text-align:center; font-family:Verdana; color:white; margin-left:25%; width:50%">
        Product Name
        <br />
        <asp:Textbox runat="server" ID="nameBox" required style="margin-left:25%; width:50%" placeholder="Insert Product Name"></asp:Textbox>
        <br />
        <br />
        Stock
        <br />
        <asp:TextBox runat="server" ID="stockBox" type="number" required style="margin-left:25%; width:50%" placeholder="Insert Stock Count Here"></asp:TextBox>
        <br />
        <br />
        Price
        <br />
        <asp:TextBox runat="server" ID="priceBox" type="number" required style="margin-left:25%; width:50%" placeholder="Insert Price Here"></asp:TextBox>
        <br />
        <br />
        Description
        <br />
        <asp:Textbox runat="server" ID="descBox" required style="margin-left:25%; width:50%" placeholder="Insert Description Name" Rows="3" TextMode="MultiLine"></asp:Textbox>
        <br />
        <br />
        Image
        <br />
        <asp:FileUpload runat="server" ID="uploadBox" />
        <br />
        <br />
        <asp:Button runat="server" ID="addButton" text="ADD PRODUCT" OnClick="GetDetails" />
    </div>
</asp:Content>
