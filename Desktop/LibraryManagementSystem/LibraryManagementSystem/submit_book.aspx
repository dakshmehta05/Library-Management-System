<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="submit_book.aspx.cs" Inherits="LibraryManagementSystem.submit_book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 100%;
        border: 4px solid #000000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="4" cellspacing="4" class="auto-style2">
    <tr>
        <td>Book ID</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SEARCH" />
        </td>
    </tr>
    <tr>
        <td>Book ID</td>
        <td colspan="2">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;<asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">Details</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>Student ID</td>
        <td colspan="2">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        &nbsp;<asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">Details</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>Date of Issue</td>
        <td colspan="2">
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Date of Submission</td>
        <td colspan="2">
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SUBMIT BOOK" />
        </td>
    </tr>
</table>
</asp:Content>
