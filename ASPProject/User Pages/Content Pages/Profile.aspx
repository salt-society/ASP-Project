<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ASPProject.User_Pages.WebForm1" %>
<asp:Content ID="Profile" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; margin-top:10%; width:50%; height:50%; text-align:center">
        EMAIL
        <br />
        <asp:Label runat="server" ID="emailLabel" Text="Email Here"></asp:Label>
        <br />
        <br />
        NAME
        <br />
        <asp:Label runat="server" ID="nameLabel" Text="Name Here"></asp:Label>
        <br />
        <br />
        <asp:Button runat="server" ID="editButton" Text="Edit Profile" OnClick="GoToEdit" />
    </div>
</asp:Content>
