<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="custdisplay.aspx.cs" Inherits="custdisplay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 397px; height: 324px;">
            <caption>
                <span style="font-size: 24pt; color: #ffffff; text-decoration: underline"><strong>Customer
                    Display</strong></span></caption>
            <tr>
                <td style="width: 109px; text-align: center;">
                    <span style="font-size: 14pt; color: #ffffff">
                        <asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table>
                                    <tr>
                                        <td style="width: 100px">
                                            <br />
                                            <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </span>
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

