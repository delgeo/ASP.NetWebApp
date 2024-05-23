<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsgmtLogin.aspx.cs" Inherits="AssignmentWebApplication.AsgmtLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    body {
        margin: 0;
        padding: 0;
    }
    .center-block {
        display: block;
        margin-right: auto;
        margin-left: auto;
    }
    .ButtonSubmit{
        background-color: blueviolet;
        font-family: 'Cambria';
        font-size: 15px;
        color: #F5F5DC;
        border-radius:8px;
    }
    .card {
        margin: 0 auto; /* Added */
        float: none; /* Added */
        width: 40rem;
    }
</style>
<div id="login">
    <h3 class="text-center text-white pt-5">Login form</h3>
    <div class="container">
        <div class="card" style="border-radius: 1rem; color:blueviolet; border-color:blueviolet">
            <div class="card-body p-5 text-center">
                <div id="login-row" class="row justify-content-center align-items-center">
                    <div id="login-column" class="col-md-6">
                        <div id="login-box" class="col-md-12">
                            <h3 class="text-center">Login</h3>
                            <div class="form-group">
                                <asp:Label ID="LabelUsername" runat="server" Text="Username"></asp:Label><br>
                                <asp:TextBox ID="TextBoxEmail" runat="server" class="form-control center-block" placeholder="Enter your username"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <br />
                                <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br>
                                <asp:TextBox ID="TextBoxPassword" runat="server" class="form-control center-block" placeholder="Enter your password" TextMode="Password"></asp:TextBox>
                            </div>
                            <br />
                            <asp:Button CssClass="ButtonSubmit" ID="ButtonSubmit" runat="server" Text="Submit" BorderStyle="None" Height="29px" Width="70px" OnClick="ButtonSubmit_Click" /><br>
                            <asp:Label ID="LabelMessage" runat="server" ForeColor="#FF3300"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>
