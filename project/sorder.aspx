<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="sorder.aspx.cs" Inherits="sorder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        
            <div style="text-align: center">
             <center>   <table style="width: 676px; color: #ffffff; height: 221px">
                    <tr>
                        <td style="width: 100px; height: 1133px; text-align: center;">
                            <span style="font-size: 24pt">SALES O<span style="text-decoration: underline">RDER
                            <br />
                        </span></span>
                            <asp:Button ID="btnnewcust" runat="server" Text="NEW CUSTOMER" OnClick="btnnewcust_Click" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF" />
                            &nbsp;
                            <br />
                            <asp:Panel ID="Panel5" runat="server">
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                    <table style="width: 540px; height: 154px">
                                        <tr>
                                            <td style="width: 100px; height: 40px">
                                                SALES ORDER NO :</td>
                                            <td style="width: 100px; height: 40px">
                                                <asp:TextBox ID="TextBox1" runat="server" ForeColor="White" Style="background-color: transparent"></asp:TextBox></td>
                                            <td style="width: 100px; height: 40px">
                                                ORDER DATE :</td>
                                            <td style="width: 100px; height: 40px">
                                                <asp:TextBox ID="TextBox2" runat="server" ForeColor="White" Style="background-color: transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td colspan="4" style="height: 290px; text-align: center">
                                                <div style="text-align: left">
                                                    <table style="height: 75px">
                                                        <tr>
                                                            <td style="width: 100px">
                                                                DUE DATE :</td>
                                                            <td style="width: 100px">
                                                                <asp:TextBox ID="TextBox3" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 100px">
                                                            </td>
                                                            <td style="width: 100px">
                                                                <asp:ImageButton ID="ImageButton1" runat="server" ForeColor="#00CC00" OnClick="ImageButton1_Click"  /><br />
                                                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                                                                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                                                                    Font-Size="8pt" ForeColor="#003399" Height="196px" 
                                                                    Width="216px" OnSelectionChanged="Calendar1_SelectionChanged">
                                                                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                                                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                                                    <WeekendDayStyle BackColor="#CCCCFF" />
                                                                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                                                    <OtherMonthDayStyle ForeColor="#999999" />
                                                                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                                                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                                                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                                                                        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                                                </asp:Calendar>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                                <br />
                            <asp:Panel ID="Panel2" runat="server">
                                <div style="text-align: center">
                                    &nbsp;&nbsp;
                                    <table style="width: 424px">
                                        <tr>
                                            <td style="width: 100px; height: 40px">
                                                CUSTOMER &nbsp;DETAILS</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100px; height: 51px">
                                                NAME : &nbsp;
                                                <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True"
                                                    DataTextField="name" DataValueField="name" Font-Bold="True" ForeColor="#003366" OnSelectedIndexChanged="ddl1_SelectedIndexChanged"
                                                    >
                                                </asp:DropDownList>
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
                                                &nbsp; &nbsp; &nbsp;&nbsp;<br />
                                                &nbsp;&nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp;&nbsp;<br />
                                                CUSTOMER ID:&nbsp; &nbsp;
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
                                                <br />
                                                <asp:Button ID="Button7" runat="server" Text="SAVE " OnClick="Button7_Click" style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF" Width="76px" /></td>
                                        </tr>
                                    </table>
                                    &nbsp;</div>
                            </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
                            </asp:Panel>
                            <br />
                            <asp:Panel ID="Panel6" runat="server">
                                <table style="width: 628px; height: 61px">
                                    <tr>
                                        <td colspan="3">
                                            <span style="font-size: 16pt; color: #ffffff">SALES ORDER DETAILS</span></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 245px">
                                            <span style="color: #ffffff">
                                                <table style="width: 236px; height: 73px">
                                                    <tr>
                                                        <td style="width: 100px">
                                                            CATEGORY ID :</td>
                                                        <td style="width: 100px">
                                                            <asp:DropDownList ID="ddl2" runat="server" AutoPostBack="True" DataTextField="cat_id"
                                                                DataValueField="cat_id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                                            </asp:DropDownList></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 100px">
                                                            ITEM NAME :</td>
                                                        <td style="width: 100px">
                                                            <asp:DropDownList ID="ddl3" runat="server" AutoPostBack="True" DataTextField="it_name"
                                                                DataValueField="it_name" OnSelectedIndexChanged="ddl3_SelectedIndexChanged" >
                                                            </asp:DropDownList></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 100px">
                                                            ITEM ID:</td>
                                                        <td style="width: 100px">
                                                            <asp:Label ID="Label2" runat="server" ForeColor="#FFFFFF" Text="Label"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 100px">
                                                            HSN :</td>
                                                        <td style="width: 100px">
                                                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                                                    </tr>
                                                </table>
                                            </span>
                                            </td>
                                        <td style="width: 125px">
                                            <span style="color: #ffffff">QUANTITY : </span>
                                            <asp:TextBox ID="TextBox4" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                        <td style="width: 100px">
                                            <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#FFCC66" 
                                                Style="background-color: transparent" Text="NEXT PURCHASE" OnClick="Button1_Click" /></td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <br />
                        <asp:Panel ID="Panel4" runat="server">
                            <div style="text-align: center">
                                <table style="width: 410px; height: 57px">
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF" >
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                            <table style="width: 600px">
                                <tr>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="#FFCC66" 
                                            Style="background-color: transparent" Text="PLACE ORDER" OnClick="Button3_Click" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button4" runat="server" Font-Bold="True" ForeColor="#FFCC66" Style="background-color: transparent"
                                            Text="BILL" Width="79px" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button5" runat="server" Font-Bold="True" ForeColor="#FFCC66" 
                                            Style="background-color: transparent" Text="VEIW ORDER" OnClick="Button5_Click1" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button6" runat="server" Font-Bold="True" ForeColor="#FFCC66" Style="background-color: transparent"
                                            Text="SEARCH ORDER" /></td>
                                </tr>
                            </table>
                            <br />
                        </td>
                    </tr>
                </table> </center>
            </div>
       
       
        
    </div>
</asp:Content>

