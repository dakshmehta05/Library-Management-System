<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="all_student.aspx.cs" Inherits="LibraryManagementSystem.all_students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="765px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:TemplateField HeaderText="Student Roll No">
            <ItemTemplate>
                <%#Eval("roll")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Student Name">
            <ItemTemplate>
                <%#Eval("sname") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Branch">
    <ItemTemplate>
        <%#Eval("branch") %>
    </ItemTemplate>
</asp:TemplateField>
        <asp:TemplateField HeaderText="Semester">
    <ItemTemplate>
        <%#Eval("semester") %>
    </ItemTemplate>
</asp:TemplateField>
        <asp:TemplateField HeaderText="Phone No.">
    <ItemTemplate>
        <%#Eval("phone") %>
    </ItemTemplate>
</asp:TemplateField>
        <asp:TemplateField HeaderText="Action">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="delete_record" CommandName='<%#Eval("roll")%>'>Delete</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>
