<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="changes_admin.aspx.cs" Inherits="LibraryManagementSystem.changes_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 70%;
            border: 4px solid #000000;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table align="center" cellpadding="5" cellspacing="5" class="auto-style2">
        <tr>
            <td colspan="2">Request ID</td>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">Book Name</td>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Book Author</td>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Book Subject</td>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Student Roll no.</td>
            <td colspan="2">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">Date of Request</td>
            <td class="auto-style4" colspan="2">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Status</td>
            <td colspan="2">
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="REJECT" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="ACCEPT" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="ORDER" OnClick="Button3_Click" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="AVAILABLE" OnClick="Button4_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="Label8" runat="server"></asp:Label>
</asp:Content>
