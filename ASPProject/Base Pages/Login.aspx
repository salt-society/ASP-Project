<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPProject.Login" %>

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
    <form id="login" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-white text-center mx-auto mt-5">
                    <h1 class="display-4">Grandmaster's Bazaar</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-6 text-white text-center mx-auto mt-2">
                    <div class="card mx-auto p-5">
                        <!-- Username -->
                        <div class="row mt-0">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Username </p>
                                <asp:TextBox runat="server" ID="userBox" required placeholder="Insert username here" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Password -->
                        <div class="row mt-2">
                            <div class="col text-dark text-left">
                                <p class="col-form-label"> Password </p>
                                <asp:TextBox runat="server" ID="passBox" required type="password" placeholder="Insert password here" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <!-- Log In -->
                        <div class="row mt-3">
                            <div class="col text-dark text-left">
                                <asp:Button runat="server" ID="loginButton" text="Log In" CssClass="btn btn-block loginButton text-white" OnClick="GetDetails"/>
                            </div>
                        </div>
                        <!-- Create Account -->
                        <div class="row mt-3">
                            <div class="col text-dark text-center">
                                <p> Need an account? <asp:HyperLink runat="server" ID="registerLink" NavigateUrl="~/Base Pages/Register.aspx">Click Here!</asp:HyperLink></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
