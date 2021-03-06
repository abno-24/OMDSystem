<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="OMDSystem.userLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/userLogin.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>User Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"
                                        placeholder="Email ID"></asp:TextBox><br />

                                </div>

                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"
                                        placeholder="Password" TextMode="Password"></asp:TextBox>
                                    <a href="forgetPassword.aspx">forget password?</a>
                                    <br /><br />

                                </div>

                                <div class="d-grid gap-2 col-12 mx-auto">
                                    <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Text="Login" OnClick="Button2_Click" />

                                    <a href="userSignup.aspx"><input class="btn btn-primary" id="Button1" type="button" value="Sign Up"/></a>
                                    <asp:Label CssClass="text-center fw-lighter" ID="Label1" runat="server" Text="Label">
                                        Create New Account by Clicking SignUp</asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="Homepage.aspx"><< Back to Home</a><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
