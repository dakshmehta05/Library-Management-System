<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LibraryManagementSystem.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/CSS/library-dashboard.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border: 3px solid #000000;
        }
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <br />
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td>Enter ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
