<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table border="0" style="width: 592px; height: 131px; text-align: center;" frame="border">
                <tr>
                    <td colspan="2" style="height: 143px">
                        <strong><span style="font-size: 48pt; color: #ffffff; font-family: Algerian">LOGIN</span></strong></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: center;">
                        <asp:Button ID="btnadmin" runat="server" Font-Bold="True" OnClick="btnadmin_Click"
                            Style="background-color: transparent ; border-radius:30px;" Text="ADMIN" Width="141px" ForeColor="#33FFFF" Height="76px" Font-Size="24pt" /></td>
                    <td style="width: 100px">
                        &nbsp; &nbsp;
                        <asp:Button ID="btnuser" runat="server" Font-Bold="True" OnClick="btnuser_Click"
                            Style="background-color: transparent ; border-radius:30px;" Text="USER" Width="132px" ForeColor="#00FFFF" Height="75px" Font-Size="24pt" /></td>
                </tr>
            </table>
</asp:Content>

