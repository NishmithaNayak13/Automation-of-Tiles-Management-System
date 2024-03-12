<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="purbill.aspx.cs" Inherits="purbill" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <div style="text-align: center">
            <table style="width: 629px; color: #ffffff; height: 241px; font-weight: bold;">
                <tr>
                    <td colspan="6" style="height: 7px">
                        <span style="font-size: 24pt">PURCHASE BILL</span></td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Panel ID="Panel1" runat="server">
                            <div style="text-align: center">
                                <br />
                                <br />
                                &nbsp; &nbsp;
                                <br />
                                <table style="width: 716px; height: 171px">
                                    <tr>
                                        <td style="width: 100px; height: 31px">
                                        </td>
                                        <td style="width: 100px; height: 31px">
                                        </td>
                                        <td style="width: 100px; height: 31px">
                                        </td>
                                        <td style="width: 100px; height: 31px">
                                        </td>
                                        <td style="width: 100px; height: 31px">
                                            BILL NO
                                        </td>
                                        <td style="width: 100px; height: 31px">
                                            <asp:TextBox ID="TextBox1" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                            BILL DATE</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox2" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            ORDER NO.</td>
                                        <td style="width: 100px">
                                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ForeColor="#000033">
                                            </asp:DropDownList></td>
                                        <td style="width: 100px">
                                            SUPPLIER ID</td>
                                        <td style="width: 100px">
                                            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                            </asp:DropDownList></td>
                                        <td style="width: 100px">
                                            SUPPLIER NAME</td>
                                        <td style="width: 100px">
                                            &nbsp; &nbsp; &nbsp;
                                            <asp:TextBox ID="TextBox3" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            ORDER DATE</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox5" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            PRICE</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox6" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            &nbsp;
                            <br />
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False" Width="82px"></asp:Label>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label><br />
                            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                            <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label></asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DONE" Width="97px" /><br />
                        <asp:GridView ID="GridView1" runat="server" Width="543px">
                        </asp:GridView>
                        <br />
                        <br />
                        <br />
                        <asp:GridView ID="GridView2" runat="server">
                            <Columns>
                                <asp:BoundField DataField="item_id" HeaderText="ITEM ID" />
                                <asp:BoundField DataField="item_name" HeaderText="item name" />
                                <asp:BoundField DataField="tot_no_of_pc" HeaderText="tot_no_of_pc" />
                            </Columns>
                        </asp:GridView>
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                        <br />
                        <asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table style="width: 684px; height: 125px">
                                    <tr>
                                        <td style="width: 100px">
                                            ITEM ID
                                        </td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox9" runat="server" style="background-color: transparent" ForeColor="White"></asp:TextBox></td>
                                        <td style="width: 100px">
                                            ITEM NAME</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox7" runat="server" style="background-color: transparent"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            NO_OF_PC</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="TextBox8" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 26px">
                                            TOT AMT</td>
                                        <td style="width: 100px; height: 26px">
                                        </td>
                                        <td style="width: 100px; height: 26px">
                                        </td>
                                        <td style="width: 100px; height: 26px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            GRAND TOTAL</td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                        <td style="width: 100px">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

