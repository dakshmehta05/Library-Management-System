<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="my_issue.aspx.cs" Inherits="LibraryManagementSystem.my_issue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 align="center"><asp:Label ID="Label5" runat="server"></asp:Label></h3>
    <p align="center">
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </p>
    <p align="center">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    
       
</asp:Content>
