<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="purreport.aspx.cs" Inherits="report" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" Text="ORDER NO WISE" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="MONTH WISE" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="YEAR WISE" OnClick="Button3_Click" /><br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:Button ID="Button4" runat="server" Text="BUTTON" OnClick="Button4_Click" /></asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="BUTTON" /></asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server">
        &nbsp;<span style="color: #ffffff">
        <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="BUTTON" /></span></asp:Panel>
    &nbsp; &nbsp;&nbsp;<br />
    <br />
    <br />
    <span
        style="color: #ffffff"> &nbsp;</span><span
        style="color: #ffffff"> </span>
    <span
        style="color: #ffffff">&nbsp;&nbsp;<asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList></span><br />
    <span style="color: #ffffff">&nbsp; &nbsp; &nbsp;<br />
    &nbsp; &nbsp; &nbsp;&nbsp;</span>
</asp:Content>

