<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="supupdate.aspx.cs" Inherits="supupdate" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 418px; height: 228px">
            <tr>
                <td colspan="2">
                    <span style="color: #ffffff">UPDATE</span></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 40px; text-align: left;">
                    <span style="color: #ffffff">SUPLIER NAME :</span></td>
                <td style="width: 100px; height: 40px; text-align: left;">
                    <asp:DropDownList ID="ddl1" runat="server">
                    </asp:DropDownList></td>
                <td style="width: 100px; height: 40px">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click"
                        Text="UPDATE" style="background-color: transparent" ForeColor="#FFFFFF" /></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 40px">
                    <asp:Panel ID="Panel1" runat="server">
                        <div style="text-align: center">
                            <table style="width: 278px; height: 167px">
                                <tr>
                                    <td style="width: 100px; text-align: left;">
                                        <span style="color: #ffffff">SUP ID:</span></td>
                                    <td style="width: 100px; text-align: left;">
                                        <asp:TextBox ID="txtid" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left;">
                                        <span style="color: #ffffff">ADDRESS :</span></td>
                                    <td style="width: 100px; text-align: left;">
                                        <asp:TextBox ID="txtadd" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left;">
                                        <span style="color: #ffffff">CONTACT NO:</span></td>
                                    <td style="width: 100px; text-align: left;">
                                        <asp:TextBox ID="txtcon" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left;">
                                        <span style="color: #ffffff">EMAIL :</span></td>
                                    <td style="width: 100px; text-align: left;">
                                        <asp:TextBox ID="txtemail" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px">
                                    </td>
                                    <td style="width: 100px">
                                        <br />
                                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="SAVE" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF" Width="70px" /></td>
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

