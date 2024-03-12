<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="custupdate1.aspx.cs" Inherits="custupdate" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 618px; height: 103px">
            <tr>
                <td style="width: 100px">
                    <span style="color: #ffffff"><strong>ENTER CUSTOMER NAME TO EDIT:</strong></span></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                        Style="background-color: transparent" Text="SUBMIT" /></td>
            </tr>
        </table>
</asp:Content>

