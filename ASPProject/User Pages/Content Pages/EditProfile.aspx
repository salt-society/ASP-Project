﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User Pages/User.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="ASPProject.User_Pages.WebForm8" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="margin-left:25%; margin-top:10%; width:50%; text-align:center">
        PASSWORD
        <br />
        <asp:TextBox runat="server" ID="passBox" required type="password" placeholder="Edit Your Password"></asp:TextBox>
        <br />
        <br />
        CONFIRM PASSWORD
        <br />
        <asp:TextBox runat="server" ID="confirmBox" required type="password" placeholder="Confirm the password edit"></asp:TextBox>
        <br />
        <br />
        FIRST NAME
        <br />
        <asp:TextBox runat="server" ID="fnameBox" required placeholder="Edit Your First Name"></asp:TextBox>
        <br />
        <br />
        LAST NAME
        <br />
        <asp:TextBox runat="server" ID="lnameBox" required placeholder="Edit Your Last Name"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="confirmButton" Text="CONFIRM CHANGES" OnClick="GetDetails" />
    </div>
</asp:Content>
