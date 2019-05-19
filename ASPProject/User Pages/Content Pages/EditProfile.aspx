<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="ASPProject.User_Pages.WebForm2" %>
<asp:Content ID="Edit_Profile" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; margin-top:10%; width:50%; text-align:center">
        PASSWORD
        <br />
        <asp:TextBox runat="server" ID="passBox" required placeholder="Edit Your Last Name"></asp:TextBox>
        <br />
        <br />
        FIRST NAME
        <br />
        <asp:TextBox runat="server" ID="fnameBox" required placeholder="Edit Your Last Name"></asp:TextBox>
        <br />
        <br />
        LAST NAME
        <br />
        <asp:TextBox runat="server" ID="lnameBox" required placeholder="Edit Your Last Name"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="confirmButton" Text="CONFIRM CHANGES" />
    </div>
</asp:Content>
