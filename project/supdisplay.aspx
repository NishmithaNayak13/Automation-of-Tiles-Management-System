<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="supdisplay.aspx.cs" Inherits="supdisplay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 241px">
            <caption>
                <span style="font-size: 24pt; color: #ffffff; text-decoration: underline"><strong>Supplier
                    Display</strong></span></caption>
            <tr>
                <td style="width: 109px">
                    <span style="font-size: 14pt; color: #ffffff">
                        <asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table>
                                    <tr>
                                        <td style="width: 100px">
                                            <br />
                                            A<strong>ctive Supplier</strong></td>
                                    </tr>
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
            <tr>
                <td style="width: 109px">
                    <span style="font-size: 14pt; color: #ffffff"><strong>
                        <br />
                        <asp:Panel ID="Panel1" runat="server">
                            <div style="text-align: center">
                                <br />
                                <table>
                                    <tr>
                                        <td style="width: 100px">
                                            <br />
                                            Inactive Supplier</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <br />
                                            <asp:GridView ID="GridView2" runat="server" ForeColor="#FFFFFF">
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </strong></span>
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

