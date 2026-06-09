<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="LibraryManagementSystem.message" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" Height="224px" Width="689px" AutoGenerateColumns="False">
        <Columns>

            <asp:TemplateField HeaderText="Subject">
                <ItemTemplate>
                    <%#Eval("subject")%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <%#Eval("msg") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="Delete_message" CommandName='<%#Eval("mid") %>'>Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <%#Eval("status") %>
                </ItemTemplate>
                </asp:TemplateField>

            <asp:TemplateField HeaderText="Visibility">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" CommandName='<%#Eval("mid") %>' runat="server" Text='<%#Eval("status") %>' OnCommand="LinkButton2_Command"></asp:LinkButton> 
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
