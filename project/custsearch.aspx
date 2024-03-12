<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="custsearch.aspx.cs" Inherits="custsearch" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <br />
        <table>
            <tr>
                <td style="width: 196px">
                    <span style="color: #ffffff"><strong>Enter the name to search</strong></span></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="ddl1" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#FFFFFF"
                        OnClick="btnsubmit_Click" Style="background-color: transparent" Text="Submit" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

