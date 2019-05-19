<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPProject.Base_Sites.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body style="color: #FFFFFF; background-color: #000000">
    <form id="Registration" runat="server">
        <div style="text-align: center">
            <h3>REGISTRATION</h3>
            <div style="width: 40%; margin-left: 30%">
                <p>
                    EMAIL
                    <br />
                    <asp:TextBox runat="server" ID="userBox" required placeholder="Insert your email here" type="email" style="width:75%"></asp:TextBox>
                    <br />
                    <br />
                    PASSWORD:
                    <br />
                    <asp:TextBox runat="server" ID="passBox" required placeholder="Insert your password here" type="password" style="width:75%"></asp:TextBox>
                    <br />
                    <br />
                    CONFIRM PASSWORD:
                    <br />
                    <asp:TextBox runat="server" ID="confirmBox" required placeholder="Confirm your password here" type="password" style="width:75%"></asp:TextBox>
                    <br />
                    <br />
                    FIRST NAME:
                    <br />
                    <asp:TextBox runat="server" ID="fnameBox" required placeholder="Insert first name/s here" style="width:75%"></asp:TextBox>
                    <br />
                    <br />
                    LAST NAME:
                    <br />
                    <asp:TextBox runat="server" ID="lnameBox" required placeholder="Insert your last name/s here" style="width:75%"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button runat="server" ID="registerButton" Text="REGISTER" />
                    <br />
                    <br />
                    <asp:HyperLink runat="server" ID="loginLink" NavigateUrl="~/Base Pages/Login.aspx" ForeColor="White">Go back to login</asp:HyperLink>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
