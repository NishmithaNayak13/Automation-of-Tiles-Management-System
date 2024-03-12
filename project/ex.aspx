<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="ex.aspx.cs" Inherits="ex" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <span style="color: #ffffff">
        <div style="text-align: center">
            <table>
                <tr>
                    <td colspan="4">
                        <span style="font-size: 24pt">PURCHASE BILL</span></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 21px">
                        PURCHASE BILL NO
                    </td>
                    <td style="width: 100px; height: 21px">
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox></td>
                    <td style="width: 100px; height: 21px">
                    </td>
                    <td style="width: 100px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        ORDER NO.</td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl1_SelectedIndexChanged">
                        </asp:DropDownList></td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        SUPPLIER&nbsp; BILL NO</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt2" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        SUPPLIER&nbsp; BILL DATE</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt3" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        RECEIVED DATE</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btnadd_Click" /></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        ITEM ID</td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="ddl2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl2_SelectedIndexChanged">
                        </asp:DropDownList></td>
                    <td style="width: 100px">
                        ITEM NAME</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        QUANTITY</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt6" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        QUANTITY RECEIVED</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt7" runat="server" AutoPostBack="True" OnTextChanged="txt7_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        PRICE</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt8" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        QUANTITY ACCEPTED</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt11" runat="server" OnTextChanged="txt11_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        AMOUNT</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt9" runat="server" OnTextChanged="txt9_TextChanged"></asp:TextBox></td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        GRAND TOTAL</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt10" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <asp:Button ID="btnnext" runat="server" OnClick="btnnext_Click" Text="NEXT" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnaccept" runat="server" OnClick="btnaccept_Click" Text="ACCEPT" /></td>
                    <td colspan="2">
                        <asp:Button ID="btnreturn" runat="server" Text="RETURN" /></td>
                </tr>
            </table>
        </div>
    </span>
</asp:Content>

