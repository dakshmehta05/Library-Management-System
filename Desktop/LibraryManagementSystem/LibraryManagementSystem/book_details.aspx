<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book_details.aspx.cs" Inherits="LibraryManagementSystem.book_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/CSS/library-dashboard.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 3px solid #000000;
        }
    </style>
</head>
<body>
    <center>
        <h1 align="center>">Student Panel</h1>
        <br />
        <hr />
        <h2 align="center">Book Details</h2>
        <h4 align="center"><asp:Label ID="Label5" runat="server"></asp:Label></h4>
       
    <form id="form1" runat="server">
        <table align="center" cellpadding="4" cellspacing="4" class="auto-style1">
            <tr>
                <td>BookID</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Book Name</td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Book Author</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Book Subject</td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="BACK" />
                </td>
            </tr>
        </table>
        <br />
       
        <div>
        </div>
    </form>
        </center>
</body>
</html>
