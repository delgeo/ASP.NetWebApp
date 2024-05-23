<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssignmentWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <style>
    * {
        padding: 0;
        margin: 0
    }
    @keyframes colorchange {
        0% { color: red; }
        25% { color: blue; }
        50% { color: green; }
        75% { color: orange; }
        100% { color: purple; }
    }

    h1 {

        font-size: 45px;
        text-align: center;
        animation: colorchange 4s infinite;
    }
    .textlabel{
        position: absolute;           
        height:50px;
        text-align:center;
        border-radius: 3px;
        top: 257px; 
        left: 407px; 
        color: blueviolet;
            width: 443px;
        }

    </style>
    

    <h1>Welcome to the ASP.Net Demo</h1>
    <br />
    <asp:Label ID="LabelDefaultText1" CssClass="textlabel" runat="server" Font-Bold="true" Font-Size="X-Large" BorderColor="#9900FF" BorderStyle="Ridge" BorderWidth="4px"></asp:Label>
    <asp:HiddenField ID="LabelDefaultText2" runat="server" />

</asp:Content>
