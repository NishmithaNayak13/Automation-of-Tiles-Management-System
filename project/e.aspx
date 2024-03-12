<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="e.aspx.cs" Inherits="e" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddl1" runat="server" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" AutoPostBack="True">
    </asp:DropDownList><br />
    <br />
    <asp:DropDownList ID="ddl2" runat="server" AutoPostBack="True">
    </asp:DropDownList><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</asp:Content>

