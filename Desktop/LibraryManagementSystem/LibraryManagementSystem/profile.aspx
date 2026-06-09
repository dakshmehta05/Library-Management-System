<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="LibraryManagementSystem.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 70%;
            border: 4px solid #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="4" cellspacing="4" class="auto-style2">
        <tr>
            <td>Email ID</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <table align="center" cellpadding="4" cellspacing="4" class="auto-style2" >
        <tr>
            <td>Roll No.</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
    <td>Name</td>
    <td>
        <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
</tr>
        <tr>
    <td>Branch</td>
    <td>
        <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
</tr>
        <tr>
    <td>Semester</td>
    <td>
        <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
</tr>
        <tr>
    <td>Phone No</td>
    <td>
        <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
</tr>
        </table>
</asp:Content>
