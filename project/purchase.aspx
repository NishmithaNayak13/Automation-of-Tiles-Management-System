<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="purchase.aspx.cs" Inherits="purchase" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellpadding="1" style="width: 402px; height: 179px">
                <tr>
                    <td colspan="2" style="height: 23px">
                        <span style="font-size: 16pt; font-family: Algerian">PURCHASE DETAILS</span></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong>Customer No</strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtcno" runat="server" style="background-color: transparent" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong>Customer Name</strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtcname" runat="server" style="background-color: transparent"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong>Address</strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtcadd" runat="server" style="background-color: transparent" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong>Contact no</strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtcont" runat="server" style="background-color: transparent"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <div style="text-align: center">
                <asp:Panel ID="Panel1" runat="server" Height="89px" Width="500px">
                <table id="TABLE1" onclick="return TABLE1_onclick()">
                    <tr>
                        <td style="width: 100px">
                            Item</td>
                        <td style="width: 100px">
                            Price</td>
                        <td style="width: 100px">
                            No_of_PC</td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 21px;">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td style="width: 100px; height: 21px;">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                        <td style="width: 100px; height: 21px;">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:Button ID="btnpur" runat="server" Text="PURCHASE" /></td>
                        <td style="width: 100px">
                            <asp:Button ID="btnreset" runat="server" Text="RESET" /></td>
                        <td style="width: 100px">
                            <asp:Button ID="btnback" runat="server" OnClick="btnback_Click" Text="BACK" /></td>
                    </tr>
                </table>
                </asp:Panel>
</asp:Content>

