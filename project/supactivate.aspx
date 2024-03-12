<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="supactivate.aspx.cs" Inherits="supactivate" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 334px; height: 231px">
            <tr>
                <td style="width: 100px">
                    <span style="color: #ffffff"><strong>Enter name to activate</strong></span></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddl1" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Button ID="btnactivate" runat="server" Font-Bold="True" ForeColor="#FFFFFF"
                        OnClick="btnactivate_Click" Style="background-color: transparent" Text="Activate"
                        Width="68px" /></td>
                <td style="width: 100px">
                    <asp:Button ID="btndisplay" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="btndisplay_Click"
                        Style="background-color: transparent" Text="Display" Width="81px" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

