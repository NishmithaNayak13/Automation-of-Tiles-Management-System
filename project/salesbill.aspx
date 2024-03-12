<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="salesbill.aspx.cs" Inherits="salesbill" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="color: #ffffff"><strong>&nbsp; </strong></span>
    <div style="text-align: center">
        <center><table style="width: 562px; color: #ffffff; height: 219px; font-weight: bold;">
            <tr>
                <td style="width: 100px; height: 32px">
                    <asp:Label ID="Label1" runat="server" Text="DATE"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>:
                    <br />
                </td>
                <td style="width: 100px; height: 32px; text-align: left;">
                    <span style="font-size: 32pt; font-family: Algerian">
                    MEENAKSHI ENTERPRISES</span></td>
                <td style="width: 100px; height: 32px">
                    <asp:Label ID="Label3" runat="server" Text="PH NO"></asp:Label>&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="9845127695" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="3">
                    <span style="font-size: 16pt">SALES BILL</span></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 52px">
                    <asp:Button ID="btnnew" runat="server" Font-Bold="True" Font-Names="Cambria" OnClick="btnnew_Click"
                        Text="NEW" style="background-color: transparent" ForeColor="#FFFFFF" Height="43px" Width="115px" />
                    &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnhome" runat="server" Font-Bold="True" Font-Names="Cambria" OnClick="btnhome_Click"
                        Text="HOME" style="background-color: transparent" ForeColor="#FFFFFF" Height="43px" Width="121px" /></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 25px">
                    <br />
                    <asp:Panel ID="Panel1" runat="server">
                        <table style="width: 692px">
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    BILL NO</td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="txtbillno" runat="server" AutoPostBack="True" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF" OnTextChanged="txtbillno_TextChanged"></asp:TextBox></td>
                                <td style="width: 100px; text-align: left">
                                    BILL DATE</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:TextBox ID="txtbilldate" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    ORDER NO</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:DropDownList ID="ddlorderno" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlorderno_SelectedIndexChanged">
                                    </asp:DropDownList></td>
                                <td style="width: 100px; text-align: left">
                                    ORDER DATE</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:TextBox ID="txtorderdate" runat="server" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    CUSTOMER ID
                                </td>
                                <td style="width: 100px; text-align: left">
                                    <asp:TextBox ID="txtcustid" runat="server" style="background-color: transparent" ForeColor="#FFFFFF" AutoPostBack="True" OnTextChanged="txtcustid_TextChanged"></asp:TextBox></td>
                                <td style="width: 100px; text-align: left">
                                    CUSTOMER NAME</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:TextBox ID="txtcustname" runat="server" style="background-color: transparent" ForeColor="#FFFFFF" AutoPostBack="True"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    ITEM ID</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:DropDownList ID="ddlproid" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlproid_SelectedIndexChanged">
                                    </asp:DropDownList></td>
                                <td style="width: 100px; text-align: left">
                                    ITEM&nbsp; NAME</td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="txtitname" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    UNIT PRICE</td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="txtprice" runat="server" AutoPostBack="True" OnTextChanged="txtprice_TextChanged" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF"></asp:TextBox></td>
                                <td style="width: 100px; text-align: left">
                                    PAYMENT MODE</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:DropDownList ID="ddlpmode" runat="server">
                                        <asp:ListItem>select</asp:ListItem>
                                        <asp:ListItem>Cheque</asp:ListItem>
                                        <asp:ListItem>Card</asp:ListItem>
                                        <asp:ListItem>Cash</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td style="width: 100px; text-align: left">
                                    QUANTITY</td>
                                <td style="width: 100px; text-align: left">
                                    &nbsp;&nbsp;
                                    <asp:TextBox ID="txtqty" runat="server" AutoPostBack="True" OnTextChanged="txtqty_TextChanged" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF"></asp:TextBox></td>
                                <td style="width: 100px; text-align: left">
                                    DISCOUNT</td>
                                <td style="width: 100px; text-align: left">
                                    <asp:TextBox ID="txtdiscount" runat="server" AutoPostBack="True" OnTextChanged="txtdiscount_TextChanged" style="background-color: transparent" Font-Bold="False" ForeColor="#FFFFFF"></asp:TextBox>
                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="16pt" Text="%"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="1" style="text-align: left; height: 26px;">
                                    PRICE
                                </td>
                                <td colspan="1" style="text-align: left; height: 26px;">
                                    <asp:TextBox ID="txttotal" runat="server" AutoPostBack="True" OnTextChanged="txttotal_TextChanged" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF"></asp:TextBox>&nbsp;</td>
                                <td colspan="4" style="text-align: left; width: 95px; height: 26px;">
                                    GRAND TOTAL &nbsp; 
                                    <asp:TextBox ID="txtgtotal" runat="server" AutoPostBack="True" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF"></asp:TextBox>
                                    &nbsp;&nbsp;
                                </td>
                                <td colspan="1" style="width: 6px; height: 26px; text-align: center">
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <br />
                    <br />
                    <div style="text-align: center">
                        &nbsp;</div>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;<asp:Panel ID="Panel2" runat="server" Width="279px">
                        <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Names="Cambria" OnClick="btnsave_Click"
                            Text="ACCEPT" style="background-color: transparent" ForeColor="#FFFFFF" Height="38px" Width="89px" />
                        <asp:Button ID="btnnext" runat="server" Font-Bold="True" Font-Names="Cambria" Text="NEXT" OnClick="btnnext_Click" style="background-color: transparent" ForeColor="#FFFFFF" Height="37px" Width="87px" />
                        <br />
                    </asp:Panel>
                    &nbsp; &nbsp; &nbsp; &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        </center>
    </div>
</asp:Content>

