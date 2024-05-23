<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsgmtAdmin.aspx.cs" Inherits="AssignmentWebApplication.AsgmtAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        
        h2 {
            text-align: center; 
            margin-top: 50px;
            color: blueviolet;

        }
        table {
            margin: 0 auto;
            border-collapse: collapse;
            border: 1px solid black;
        }
        th, td {
            border: 1px solid black;
            padding: 8px;
            text-align: center;
            border: 2px solid blueviolet; /* Add a border to table cells to match the table border */
        }
        .no-border {
            border: none;
            outline: none; /* Optionally remove the outline for a cleaner look */
        }
        .ButtonSave {
            display: block;
            margin: 0 auto;
            background-color: blueviolet;
            font-family: 'Cambria';
            font-size: 15px;
            color: #F5F5DC;
            border-radius:8px;
        }
    
    .styled-table th,
    .styled-table td {
        border: 1px solid purple; /* Add a border to table cells to match the table border */
        padding: 8px;             /* Add some padding for better spacing */
    }
    </style>

    <h2>Control Panel</h2>
    <br />
    <br />
    <div class="flex-container">
        <table border="1">
            <tr>
                <td>Default Page Text 1</td>
                <td><asp:TextBox ID="TextBoxDefaultPageText1" CssClass="no-border" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Default Page Text 2</td>
                <td><asp:TextBox ID="TextBoxDefaultPageText2" CssClass="no-border" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Header Text</td>
                <td><asp:TextBox ID="HeaderText" CssClass="no-border" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Footer Text</td>
                <td><asp:TextBox ID="FooterText" CssClass="no-border" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </div>

    <br />
    <br />

    <div class="row">
        <div class="col">
            <asp:Button ID="ButtonSave" CssClass="ButtonSave" runat="server" Text="Save" BorderStyle="None" Height="29px" Width="70px" OnClick="ButtonSave_Click" />                
        </div>
    </div>

</asp:Content>
