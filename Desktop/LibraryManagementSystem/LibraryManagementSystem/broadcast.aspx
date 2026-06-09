<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="broadcast.aspx.cs" Inherits="LibraryManagementSystem.broadcast" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="573px"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="205px" Width="573px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click" />
</asp:Content>
