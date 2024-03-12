<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="empsearch.aspx.cs" Inherits="empsearch" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 604px; height: 125px">
            <tr>
                <td style="width: 100px">
                    <span style="font-size: 16pt; color: #ffffff"><strong>
                    Employee name to search</strong></span></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" Text="Submit" OnClick="btnsubmit_Click" style="background-color: transparent" Font-Size="12pt" ForeColor="#FFFFFF" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" Font-Bold="True" ForeColor="#FFFFFF">
                    </asp:GridView>
                </td>
            </tr>
        </table>
</asp:Content>

