<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="s_search_book.aspx.cs" Inherits="LibraryManagementSystem.s_search_book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="4" cellspacing="4" class="auto-style1">
        <tr>
            <td>Enter Book ID</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>Book ID</td>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Author</td>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Subject</td>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label5" runat="server"></asp:Label>
&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">Request Book</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
