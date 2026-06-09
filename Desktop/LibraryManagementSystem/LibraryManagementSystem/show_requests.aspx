<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="show_requests.aspx.cs" Inherits="LibraryManagementSystem.show_requests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="919px">
        <Columns>
            
            <asp:TemplateField HeaderText="Book Name">
    <ItemTemplate>
        <%#Eval("bname") %>
    </ItemTemplate>
</asp:TemplateField >
     <asp:TemplateField HeaderText="Student Roll No">
    <ItemTemplate>
        <%#Eval("sroll") %>
    </ItemTemplate>
</asp:TemplateField>
             <asp:TemplateField HeaderText="Request Date">
                <ItemTemplate>
                    <%#Eval("dor") %>
                </ItemTemplate>
            </asp:TemplateField>
 <asp:TemplateField HeaderText="Status">
    <ItemTemplate>
        <%#Eval("status") %>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="reject" CommandName='<%#Eval("reqid") %>'>Reject</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton2" runat="server" OnCommand="accept" CommandName='<%#Eval("reqid") %>'>Accept</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton3" runat="server" OnCommand="order" CommandName='<%#Eval("reqid") %>'>Order</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton4" runat="server" OnCommand="available" CommandName='<%#Eval("reqid") %>'>Available</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>

        </Columns>
    </asp:GridView>
</asp:Content>
