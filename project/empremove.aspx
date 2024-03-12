<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="empremove.aspx.cs" Inherits="empremove" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 555px; height: 211px">
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">
                        Enter the emp name to remove :<br />
                        </span>
                    </td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Button ID="btnremove" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="btnremove_Click"
                            Style="background-color: transparent" Text="REMOVE" /></td>
                    <td style="width: 100px">
                        <asp:Button ID="btndisplay" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="btndisplay_Click"
                            Style="background-color: transparent" Text="DISPLAY" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
</asp:Content>

