<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="empdisplay.aspx.cs" Inherits="empdisplay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 523px; height: 206px">
            <tr>
                <td style="width: 100px">
                    <span style="font-size: 32pt"><strong><span style="color: #ffffff; font-family: Algerian">
                        ACTIVE EMPLOYEE</span>S</strong></span></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center;">
                    <br />
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
    <tr>
        <td style="width: 100px; text-align: center">
            <asp:GridView ID="GridView2" runat="server" Font-Bold="True" ForeColor="#FFFFFF">
            </asp:GridView>
        </td>
    </tr>
        </table>
</asp:Content>

