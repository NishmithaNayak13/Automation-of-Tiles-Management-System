<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="purchaseorder.aspx.cs" Inherits="purchaseorder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <div style="text-align: center">
            <center><table style="font-weight: bold; width: 841px; height: 584px; background-color: transparent">
                <tr>
                    <td colspan="4" style="height: 68px">
                        <span style="color: #ffffff; font-size: 16pt;">PURCHASE ORDER</span></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 105px">
                        <span style="color: #ffffff">DATE :</span></td>
                    <td style="width: 100px">
                        <asp:Label ID="Label1" runat="server" ForeColor="#FFFFFF" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 105px">
                        <span style="color: #ffffff"><strong>PURCHASE ID :</strong></span></td>
                    <td style="width: 100px">
                        <asp:Label ID="Label2" runat="server" ForeColor="#FFFFFF" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">PURCHASE ORDER_NO :</span></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtorder" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                    <td style="width: 105px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">SUPPLIER NAME :</span></td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="ddlname" runat="server" style="background-color: transparent" ForeColor="#FFFFFF">
                        </asp:DropDownList></td>
                    <td style="width: 105px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 33px;">
                        <span style="color: #ffffff">SUPPLIER ID :</span></td>
                    <td style="width: 100px; height: 33px;">
                        <asp:TextBox ID="txtid" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                    <td style="width: 105px; height: 33px;">
                    </td>
                    <td style="width: 100px; height: 33px;">
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="height: 82px">
                        <span style="color: #ffffff; font-size: 16pt;">PURCHASE ORDER DESCRIPTION </span>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">CATEGORY </span>
                    </td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="ddlcat" runat="server" style="background-color: transparent" ForeColor="#FFFFFF">
                        </asp:DropDownList></td>
                    <td style="width: 105px">
                        <span style="color: #ffffff">ITEM NAME </span>
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtitemname" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">CATEGORY ID</span></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtcatid" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                    <td style="width: 105px">
                        <span style="color: #ffffff">Pcs PER BOX&nbsp;</span></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtppb" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">PRICE</span></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtprice" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                    <td style="width: 105px">
                        <span style="color: #ffffff">No OF BOX</span></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtnob" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 44px;">
                    </td>
                    <td style="width: 100px; height: 44px;">
                    </td>
                    <td style="width: 105px; height: 44px; text-align: left;">
                        <span style="color: #ffffff">TOTAL No OF Pcs</span></td>
                    <td style="width: 100px; height: 44px;">
                        <asp:TextBox ID="txttnop" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 21px">
                    </td>
                    <td style="width: 100px; height: 21px">
                        <span style="color: #ffffff">ITEM ID</span></td>
                    <td style="width: 105px; height: 21px">
                        <asp:TextBox ID="txtitemid" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                    <td style="width: 100px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                        <span style="color: #ffffff">DUE DATE </span>
                    </td>
                    <td style="width: 105px">
                        <asp:TextBox ID="txtduedt" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox>&nbsp;
                        <br />
                        <br />
                        <br />
                        <asp:ImageButton ID="ImageButton1" runat="server" /></td>
                    <td style="width: 100px">
                        &nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999"
                            CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                            ForeColor="Black" Height="106px" Width="200px">
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="btnorder" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"
                            Text="ORDER" OnClick="btnorder_Click" />&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="btnclear" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"
                            Text="CLEAR" />
                        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp;&nbsp;
                        <asp:Button ID="btndisplay" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"
                            Text="DISPLAY" OnClick="btndisplay_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" Text="Button" /></td>
                </tr>
            </table>
            </center>
        </div>
    </div>
</asp:Content>

