<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="search_student.aspx.cs" Inherits="LibraryManagementSystem.search_student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
        <tr>
            <td>Enter Roll No.</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>Roll No</td>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td colspan="3">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Branch</td>
            <td colspan="3">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Semester</td>
            <td colspan="3">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Phone No</td>
            <td colspan="3">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td colspan="3">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Photo</td>
            <td colspan="2">
                <asp:Image ID="Image1" runat="server" Width="200px" />
            </td>
        </tr>
    </table>
</asp:Content>
