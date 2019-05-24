<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPProject.Base_Sites.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grandmaster's Bazaar</title>
    <!-- CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="~/Src/style.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.7.0/animate.min.css">

    <!-- JS -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</head>
<body>
    <form id="Registration" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-white text-center mx-auto mt-5">
                    <h1 class="display-4">Registration</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-6 text-white text-center mx-auto mt-2">
                    <div class="card mx-auto p-5">
                        <!-- Email -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Email </p>
                                <asp:TextBox runat="server" ID="userBox" required placeholder="Insert your email here" type="email" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Password -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Password </p>
                                <asp:TextBox runat="server" ID="passBox" required placeholder="Insert your password here" type="password" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Confirm Password -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Confirm Password </p>
                                <asp:TextBox runat="server" ID="confirmBox" required placeholder="Confirm your password here" type="password" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- First Name -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> First Name </p>
                                <asp:TextBox runat="server" ID="fnameBox" required placeholder="Insert first name/s here" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Last Name -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Last Name </p>
                                <asp:TextBox runat="server" ID="lnameBox" required placeholder="Insert your last name/s here" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Register -->
                        <div class="row mt-3">
                            <div class="col text-dark text-left">
                                <asp:Button runat="server" ID="registerButton" text="Log In" CssClass="btn btn-block loginButton text-white" OnClick="GetDetails"/>
                            </div>
                        </div>
                        <!-- Back to Log In -->
                        <div class="row mt-3">
                            <div class="col text-dark text-center">
                                <asp:HyperLink runat="server" ID="loginLink" NavigateUrl="~/Base Pages/Login.aspx" CssClass="">Go back to login</asp:HyperLink>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
