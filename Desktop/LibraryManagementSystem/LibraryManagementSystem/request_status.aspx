<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="request_status.aspx.cs" Inherits="LibraryManagementSystem.request_status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellspacing="4" cellpadding="5" border="4">
        <tr>
            <td>Roll No</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label></td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
