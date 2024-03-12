<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="porder.aspx.cs" Inherits="porder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>

   <div style="text-align: center">
        <span></span>
           <div style="text-align: center">
            <center>   <table style="color: #ffffff">
                   <tr>
                       <td style="width: 100px; text-align: center;">
                                    <br />
                                    <span style="font-size: 24pt"><span style="font-family: Algerian">PURCHASE O</span><span><span
                                        style="font-family: Algerian">RDER</span></span></span></td>
                   </tr>
                   <tr>
                       <td style="width: 100px">
                           <br />
                            <asp:Panel ID="Panel1" runat="server" Width="705px">
                                <div style="text-align: center">
                                    <br />
                                    <table style="width: 722px; height: 209px">
                                        <tr>
                                            <td style="width: 100px; height: 40px">
                                                PURCHASE ORDER NO :</td>
                                            <td style="width: 100px; height: 40px">
                                                <asp:TextBox ID="TextBox1" runat="server" ForeColor="White" Style="background-color: transparent"></asp:TextBox></td>
                                            <td style="width: 100px; height: 40px">
                                                ORDER DATE :</td>
                                            <td style="width: 100px; height: 40px">
                                                <asp:TextBox ID="TextBox2" runat="server" ForeColor="White" Style="background-color: transparent"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td colspan="4" style="height: 222px; text-align: center">
                                                <div style="text-align: center">
                                                    <table style="height: 75px; width: 491px;">
                                                        <tr>
                                                            <td style="width: 100px; height: 169px;">
                                                                DUE DATE :</td>
                                                            <td style="width: 100px; height: 169px; text-align: justify;">
                                                                <asp:TextBox ID="TextBox3" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                                                                <asp:ImageButton ID="ImageButton1" runat="server" ForeColor="#00CC00" OnClick="ImageButton1_Click" />
                                                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                                                                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                                                                    Font-Size="8pt" ForeColor="#003399" Height="85px" OnSelectionChanged="Calendar1_SelectionChanged"
                                                                    Width="216px">
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
                                                                <span style="font-size: 16pt; font-family: Algerian">SUPPLIER DETAILS</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" style="height: 71px; text-align: center">
                                                NAME : &nbsp;
                                                <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True" 
                                                    DataTextField="name" DataValueField="name" Font-Bold="True" ForeColor="#003366"
                                                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
                                                &nbsp; &nbsp; SUPPLIER ID:&nbsp; &nbsp;
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                                <br />
                                                <br />
                                                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="SAVE " style="background-color: transparent" Font-Bold="True" ForeColor="#FFFFFF" Height="42px" Width="112px" /><br />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </asp:Panel>
                           <br />
                            <asp:Panel ID="Panel2" runat="server">
                                <div style="text-align: center">
                                <table style="width: 628px; height: 61px">
                                    <tr>
                                        <td colspan="3">
                                            <span style="font-size: 16pt; color: #ffffff">PURCHASE ORDER DETAILS</span></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 245px; height: 139px;">
                                            <span style="color: #ffffff">&nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp;&nbsp;<br />
                                                <asp:Panel ID="Panel5" runat="server">
                                                    <div style="text-align: center">
                                                        <table style="width: 236px; height: 73px">
                                                            <tr>
                                                                <td style="width: 100px">
                                                                    CATEGO<span>RY</span> ID :</td>
                                                                <td style="width: 100px">
                                                <asp:DropDownList ID="ddl2" runat="server" 
                                                    DataTextField="cat_id" DataValueField="cat_id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged1" AutoPostBack="True">
                                                </asp:DropDownList></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 100px">
                                                                    ITEM NAME :</td>
                                                                <td style="width: 100px">
                                                                    <asp:DropDownList ID="ddl3" runat="server"
                                                        DataTextField="it_name" DataValueField="it_name" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged1" AutoPostBack="True">
                                                    </asp:DropDownList></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 100px">
                                                                    ITEM ID:</td>
                                                                <td style="width: 100px">
                                                                    <asp:Label ID="Label2" runat="server" ForeColor="#FFFFFF"
                                                    Text="Label"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 100px">
                                                                    HSN :</td>
                                                                <td style="width: 100px">
                                                                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </asp:Panel>
                                                &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;</span><span style="color: #ffffff"> </span></td>
                                        <td style="width: 125px; height: 139px;">
                                            <span style="color: #ffffff">QUANTITY : </span>
                                            <asp:TextBox ID="TextBox4" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                                        <td style="width: 100px; height: 139px;">
                                            <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#FFCC66" OnClick="Button1_Click"
                                                Style="background-color: transparent" Text="NEXT PURCHASE" /></td>
                                    </tr>
                                </table>
                            </div>
                            </asp:Panel>
                           <br />
                                <table style="width: 186px; height: 5px">
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            <table style="width: 600px">
                                <tr>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="#FFCC66" OnClick="Button3_Click"
                                            Style="background-color: transparent" Text="PLACE ORDER" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button4" runat="server" Font-Bold="True" ForeColor="#FFCC66" Style="background-color: transparent"
                                            Text="BILL" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button5" runat="server" Font-Bold="True" ForeColor="#FFCC66" OnClick="Button5_Click"
                                            Style="background-color: transparent" Text="VEIW ORDER" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Button6" runat="server" Font-Bold="True" ForeColor="#FFCC66" Style="background-color: transparent"
                                            Text="SEARCH ORDER" OnClick="Button6_Click" /></td>
                                </tr>
                            </table>
                       </td>
                   </tr>
               </table> </center>
           </div>
    </div>
</asp:Content>

