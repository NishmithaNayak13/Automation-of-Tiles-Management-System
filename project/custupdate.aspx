<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="custupdate.aspx.cs" Inherits="custupdate" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 512px; height: 228px">
            <tr>
                <td colspan="2" style="height: 20px">
                    <span style="color: #ffffff">UPDATE</span></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 40px; text-align: left">
                    <span style="color: #ffffff">CUSTOMER NAME :</span></td>
                <td style="width: 100px; height: 40px; text-align: left">
                    <asp:DropDownList ID="ddl1" runat="server">
                    </asp:DropDownList></td>
                <td style="width: 100px; height: 40px">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="Button1_Click"
                        Style="background-color: transparent" Text="UPDATE" /></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 40px">
                    <asp:Panel ID="Panel1" runat="server">
                        <div style="text-align: center">
                            <table style="width: 302px; height: 167px">
                                <tr>
                                    <td style="width: 190px; text-align: left">
                                        <span style="color: #ffffff">CUST ID:</span></td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtid" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 190px; text-align: left">
                                        <span style="color: #ffffff">ADDRESS :</span></td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtadd" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 190px; text-align: left">
                                        <span style="color: #ffffff">CONTACT NO:</span></td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtcon" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 190px; text-align: left">
                                        <span style="color: #ffffff">EMAIL :</span></td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtemail" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 190px">
                                    </td>
                                    <td style="width: 100px">
                                        <br />
                                        <asp:Button ID="btnupdate" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="btnupdate_Click"
                                            Style="background-color: transparent" Text="SAVE" Width="70px" /></td>
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

