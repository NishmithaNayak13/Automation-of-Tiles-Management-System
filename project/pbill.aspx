<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="pbill.aspx.cs" Inherits="pbill" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                    <td style="width: 100px">
                        QUANTITY RECEIVED
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt7" runat="server"></asp:TextBox></td>
                    <td style="width: 100px">
                        </td>
                    <td style="width: 100px">
                        </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="item_id" HeaderText="ITEM ID" />
                                <asp:BoundField DataField="it_name" HeaderText="ITEM NAME" />
                                <asp:BoundField DataField="pc_per_box" HeaderText="PC_PER_BOX" />
                                <asp:BoundField DataField="no_of_box" HeaderText="NO_OF_BOX" />
                                <asp:BoundField DataField="tot_no_of_pc" HeaderText="TOT_NO_OF_PC" />
                                <asp:BoundField DataField="price" HeaderText="PRICE" />
                                <asp:BoundField DataField="amt" HeaderText="AMT" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        AMOUNT</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt9" runat="server"></asp:TextBox></td>
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
                    <td colspan="2">
                        <asp:Button ID="btnadd" runat="server" Text="ACCEPT" OnClick="btnadd_Click" /></td>
                    <td colspan="2">
                        <asp:Button ID="btnreturn" runat="server" Text="RETURN" /></td>
                </tr>
            </table>
        </div>
    </span>
</asp:Content>

