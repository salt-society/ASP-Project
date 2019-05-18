<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color: #FFFFFF; background-color: #000000">
    <form id="login" runat="server">
        <div style="text-align: center">
            <h1>GRANDMASTER'S BAZAAR</h1>
            <br />
            <h3>LOGIN</h3>
            <br />
            <p>
                USERNAME
                <br />
                <asp:TextBox runat="server" ID="userBox" required placeholder="Insert username here"></asp:TextBox>
                <br />
                <br />
                PASSWORD
                <br />
                <asp:TextBox runat="server" ID="passBox" required type="password" placeholder="Insert password here"></asp:TextBox>
            </p>
            <br />
            <br />
            <asp:Button runat="server" ID="loginButton" text="LOGIN"/>
        </div>
    </form>

    <div style="text-align: center">
        <p>
            Need an account? <asp:HyperLink runat="server" ID="registerLink" NavigateUrl="~/Base Sites/Register.aspx" ForeColor="White">Click Here!</asp:HyperLink>
        </p>
    </div>
</body>
</html>
