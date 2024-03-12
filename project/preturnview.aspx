<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="preturnview.aspx.cs" Inherits="preturnview" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" /><br />
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
    <asp:DropDownList ID="DropDownList4" runat="server">
    </asp:DropDownList><br />
    <asp:Panel ID="Panel3" runat="server">
    </asp:Panel>
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
    <asp:Button ID="Button4" runat="server" Text="Button" />&nbsp;<asp:Button ID="Button5"
        runat="server" Text="Button" />
    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Button" />&nbsp;
    <asp:Button ID="Button7" runat="server" Text="Button" />&nbsp;<asp:Button ID="Button8"
        runat="server" OnClick="Button8_Click" Text="Button" />
</asp:Content>

