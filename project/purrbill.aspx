<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="purrbill.aspx.cs" Inherits="purrbill" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="color: #ffffff">&nbsp; </span>
    <div style="text-align: center">
        <center>
            <table style="width: 562px; color: #ffffff; height: 219px">
                <tr>
                    <td style="width: 100px; height: 32px">
                        <asp:Label ID="Label1" runat="server" Text="DATE"></asp:Label><span> </span>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><span style="font-size: 24pt;
                            font-family: Algerian"><strong>:
                                <br />
                            </strong></span>
                    </td>
                    <td style="font-weight: bold; font-size: 24pt; width: 100px; font-family: Algerian;
                        height: 32px; text-align: center">
                        <span>
                    MEENAKSHI ENTERPRISES</span></td>
                    <td style="font-size: 12pt; width: 100px; font-family: Times New Roman; height: 32px">
                        <asp:Label ID="Label3" runat="server" Text="PH NO"></asp:Label><span>&nbsp; </span>
                        <asp:Label ID="Label4" runat="server" Text="9845127695"></asp:Label></td>
                </tr>
                <tr style="font-size: 12pt; font-family: Times New Roman">
                    <td colspan="3" style="text-align: center">
                        <span>
                            <br />
                            <span style="font-family: Algerian"><span style="font-size: 24pt"><span>PURCHASE</span><strong>
                                BILL</strong></span></span></span></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="btnnew" runat="server" Font-Bold="True" Font-Names="Cambria" ForeColor="#FFFFFF"
                            Height="31px" OnClick="btnnew_Click" Style="background-color: transparent" Text="NEW"
                            Width="91px" />
                        <asp:Button ID="btnhome" runat="server" Font-Bold="True" Font-Names="Cambria" ForeColor="#FFFFFF"
                            Height="33px" OnClick="btnhome_Click" Style="background-color: transparent" Text="HOME"
                            Width="107px" /></td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 25px">
                        <br />
                        <asp:Panel ID="Panel1" runat="server">
                            <table style="width: 692px">
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        BILL NO</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtbillno" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                        SUPPLIER BILL NO</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtsbno" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" AutoPostBack="True" OnTextChanged="txtsbno_TextChanged1"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        BILL DATE</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtbilldate" runat="server" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                        SUPPLIER BILL DATE
                                    </td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtsbdate" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" Enabled="False"></asp:TextBox>&nbsp;<asp:ImageButton
                                            ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
                                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
                                            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                                            ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged"
                                            ShowGridLines="True" Width="220px">
                                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                            <SelectorStyle BackColor="#FFCC66" />
                                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                            <OtherMonthDayStyle ForeColor="#CC9966" />
                                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                        </asp:Calendar>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        ORDER NO</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:DropDownList ID="ddlorderno" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlorderno_SelectedIndexChanged">
                                        </asp:DropDownList></td>
                                    <td style="width: 100px; text-align: left">
                                        ORDER DATE</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtorderdate" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        SUPPLIER ID</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtsid" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                        ITEM ID</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:DropDownList ID="ddlproid" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlproid_SelectedIndexChanged">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                    ITEM NAME</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtname" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                    UNIT PRICE</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtprice" runat="server" AutoPostBack="True" BorderStyle="Ridge"
                                            Font-Bold="True" ForeColor="#FFFFFF" OnTextChanged="txtprice_TextChanged" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        QUANTITY</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtqty" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                    SELLING PRICE</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtsp" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        QUANTITY RECIVED</td>
                                    <td style="width: 132px; text-align: left">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="txtqr" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            OnTextChanged="txtqr_TextChanged" Style="background-color: transparent"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                    QUANTITY ACCEPTED</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtqa" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            OnTextChanged="txtqa_TextChanged" Style="background-color: transparent"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        RECIVED DATE</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txtrdate" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" Enabled="False"></asp:TextBox>
                                        <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" />
                                        <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
                                            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                                            ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar2_SelectionChanged"
                                            ShowGridLines="True" Width="220px">
                                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                            <SelectorStyle BackColor="#FFCC66" />
                                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                            <OtherMonthDayStyle ForeColor="#CC9966" />
                                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                        </asp:Calendar>
                                    </td>
                                    <td style="width: 100px; text-align: left">
                                    QUANTITY REJECTED</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtrej" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; text-align: left">
                                        PRICE</td>
                                    <td style="width: 132px; text-align: left">
                                        <asp:TextBox ID="txttotal" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                    <td style="width: 100px; text-align: left">
                                        TOTAL</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtgtotal" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px">
                                    </td>
                                    <td style="width: 132px">
                                    </td>
                                    <td style="width: 100px; text-align: left">
                                    GST</td>
                                    <td style="width: 100px; text-align: left">
                                        <asp:TextBox ID="txtgst" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" OnTextChanged="txtgst_TextChanged"></asp:TextBox>
                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="14pt" Text="%"></asp:Label>&nbsp;
                                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px; height: 21px">
                                    </td>
                                    <td style="width: 132px; height: 21px">
                                    </td>
                                    <td style="width: 100px; height: 21px; text-align: left">
                                    GRAND&nbsp; TOTAL</td>
                                    <td style="width: 100px; height: 21px; text-align: left">
                                        <asp:TextBox ID="txtgrandtotal" runat="server" AutoPostBack="True" ForeColor="#FFFFFF"
                                            Style="background-color: transparent" Enabled="False"></asp:TextBox></td>
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
                        &nbsp;<asp:Panel ID="Panel2" runat="server" Width="461px">
                            <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Names="Cambria" ForeColor="#FFFFFF"
                                Height="36px" OnClick="btnsave_Click" Style="background-color: transparent" Text="ACCEPT"
                                Width="99px" />
                            <asp:Button ID="btnnext" runat="server" Font-Bold="True" Font-Names="Cambria" Font-Size="12pt"
                                ForeColor="#FFFFFF" Height="35px" OnClick="btnnext_Click" Style="background-color: transparent"
                                Text="NEXT" Width="86px" />
                            <asp:Button ID="btncancel" runat="server" Font-Bold="True" Font-Names="Cambria" Font-Size="12pt"
                                ForeColor="#FFFFFF" Height="34px" OnClick="btncancel_Click" Style="background-color: transparent"
                                Text="CANCEL" Width="87px" />
                            <asp:Button ID="btnreject" runat="server" Font-Bold="True" Font-Names="Cambria" ForeColor="#FFFFFF"
                                Height="34px" OnClick="btnreject_Click" Style="background-color: transparent"
                                Text="RETURN" Width="90px" /><br />
                        </asp:Panel>
                        &nbsp; &nbsp; &nbsp; &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
                        <br />
                        <div style="text-align: center">
                            <asp:Panel ID="Panel6" runat="server">
                                <table id="Table2" style="width: 606px; color: #ffffff">
                                    <tr>
                                        <td colspan="4">
                                            <strong><span style="font-size: 16pt; font-family: Algerian">PURCHASE RETURN</span></strong></td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
                                                <Columns>
                                                    <asp:BoundField DataField="slno" HeaderText="SLNO" />
                                                    <asp:BoundField DataField="preturnno" HeaderText="PURCHASE RETURN NO" />
                                                    <asp:BoundField DataField="bill_no" HeaderText="BILLNO" />
                                                    <asp:BoundField DataField="date" HeaderText="DATE" />
                                                    <asp:BoundField DataField="tot_no_of_pc" HeaderText="QTY" />
                                                    <asp:BoundField DataField="gtot" HeaderText="GRANDTOTAL" />
                                                    <asp:BoundField DataField="price" HeaderText="PRICE" />
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <asp:Button ID="btnret" runat="server" ForeColor="#FFFFFF" Height="39px" OnClick="btnret_Click"
                                                Style="background-color: transparent" Text="RETURN" Width="114px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                            <asp:TextBox ID="txtret" runat="server" AutoPostBack="True" ForeColor="Black" Style="background-color: transparent; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;"></asp:TextBox></td>
                                        <td style="width: 100px; height: 28px">
                                            <asp:TextBox ID="txtbill" runat="server" ForeColor="Black" Style="background-color: transparent; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;"></asp:TextBox></td>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                            </td>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                            </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                            <asp:TextBox ID="txtslno" runat="server" style="border-top-style: none; border-right-style: none; border-left-style: none; background-color: transparent; border-bottom-style: none" ForeColor="#000000"></asp:TextBox></td>
                                        <td style="width: 100px; height: 28px">
                                            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" ForeColor="Black"
                                                Style="background-color: transparent; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;"></asp:TextBox></td>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                        </td>
                                        <td style="width: 100px; height: 28px; text-align: left">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 26px; text-align: left">
                                            <asp:TextBox ID="txtdate" runat="server" ForeColor="Black" Style="background-color: transparent; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;"></asp:TextBox></td>
                                        <td style="width: 100px; height: 26px">
                                            <asp:TextBox ID="txtt" runat="server" AutoPostBack="True" ForeColor="Black" Style="background-color: transparent; border-top-style: none; border-right-style: none; border-left-style: none; border-bottom-style: none;" Font-Bold="False"></asp:TextBox></td>
                                        <td style="width: 100px; height: 26px">
                                            </td>
                                        <td style="width: 100px; height: 26px">
                                            </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </div>
                        <br />
                    </td>
                </tr>
            </table>
        </center>
    </div>
</asp:Content>

