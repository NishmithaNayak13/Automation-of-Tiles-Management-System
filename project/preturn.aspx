<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="preturn.aspx.cs" Inherits="preturn" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <asp:Panel ID="Panel6" runat="server">
        <table style="color: #ffffff" id="TABLE1">
            <tr>
                <td colspan="2">
                    PURCHASE RETURN</td>
                <td colspan="1">
                </td>
                <td colspan="1">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 28px;">
                    PURCHASE RETURN NO</td>
                <td style="width: 100px; height: 28px;">
                    <asp:TextBox ID="txtret" runat="server" AutoPostBack="True"></asp:TextBox></td>
                <td style="width: 100px; height: 28px">
                    BILL NO</td>
                <td style="width: 100px; height: 28px">
                    <asp:TextBox ID="txtbillno" runat="server" OnTextChanged="txtbillno_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 26px;">
                    DATE</td>
                <td style="width: 100px; height: 26px;">
                    <asp:TextBox ID="txtdate" runat="server" OnTextChanged="txtdate_TextChanged"></asp:TextBox></td>
                <td style="width: 100px; height: 26px;">
                </td>
                <td style="width: 100px; height: 26px;">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    </td>
                <td style="width: 100px">
                    </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    QUANTITY</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtqty" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    QUANTITY REJECTED</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtqr" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnret" runat="server" OnClick="btnret_Click" Text="RETURN" /></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
        </asp:Panel>
    </div>
</asp:Content>

