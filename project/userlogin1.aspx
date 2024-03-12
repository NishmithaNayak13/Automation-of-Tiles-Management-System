<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="userlogin1.aspx.cs" Inherits="userlogin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel3" runat="server" Height="392px" Width="821px">
                <br />
            <table style="width: 828px; height: 357px">
                <tr>
                    <td colspan="2" style="height: 21px">
                        <strong><span style="font-family: Algerian">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 32pt; color: #ffffff;">
                                MEENAKSHI ENTERPRISES</span></span></strong></td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 65px">
                        &nbsp;<br />
                        <asp:Panel ID="Panel1" runat="server">
                            <div style="text-align: center">
                                <table style="width: 801px; height: 193px">
                                    <tr>
                                        <td colspan="2" style="height: 20px">
                                            <strong><span style="font-family: Algerian">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; <span style="font-size: 16pt">
                                                    USER LOGIN</span></span></strong></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 236px">
                                            <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<span style="font-size: 16pt"> <span
                                                    style="color: #ffffff">USER NAME</span></span></strong><span style="font-size: 16pt;
                                                        color: #ffffff"> :</span></td>
                                        <td style="width: 125px; text-align: left;">
                        <asp:DropDownList ID="ddl1" runat="server" Font-Bold="True" Width="146px">
                        </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 236px">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 16pt; color: #ffffff">&nbsp;&nbsp; <strong>PASSWORD</strong>:</span></td>
                                        <td style="width: 125px; text-align: left;">
                        <asp:TextBox ID="txt1" runat="server" Width="123px" AutoPostBack="True" TextMode="Password" ></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 26px">
                                            &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp;
                                            <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF0066" Font-Bold="True"></asp:Label>
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                                            <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Text="Show password" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" ForeColor="#FFFFFF" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp;&nbsp; &nbsp;
                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" OnClick="LinkButton1_Click" Font-Size="16pt">forgot password?</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 33px">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp;
                        <asp:Button ID="btnlog" runat="server" Font-Bold="True" Text="LOGIN" OnClick="btnlog_Click" style="background-color: transparent; border-radius:40px;" Width="81px" Font-Size="16pt" ForeColor="#FFFFFF" />
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:Button ID="btnbck" runat="server" Font-Bold="True" OnClick="btnbck_Click" Text="BACK" Width="74px" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                        </td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 21px">
                        <br />
                        <br />
                        <asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table style="width: 808px; height: 126px">
                                    <tr>
                                        <td colspan="3">
                                            <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 16pt"> <span style="color: #ffccff">
                                                    &nbsp;&nbsp; Answer Below Questions </span></span></strong>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True">
                                            </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            <asp:TextBox ID="txt2" runat="server" Font-Bold="True"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 198px; text-align: right;">
                                            <asp:Button ID="btnok" runat="server" Font-Bold="True" Text="OK" Width="86px" OnClick="btnok_Click" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFCCFF" /></td>
                                        <td style="width: 85px; text-align: center;">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:Button ID="btnclear" runat="server" Font-Bold="True" Text="CLEAR" OnClick="btnclear_Click" Width="96px" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFCCFF" /></td>
                                        <td style="width: 100px; text-align: left;">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:Button ID="btnhome" runat="server" Font-Bold="True" OnClick="btnhome_Click"
                                                Text="HOME" Width="81px" style="background-color: transparent" Font-Size="14pt" ForeColor="#FFCCFF" /></td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 33px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp;&nbsp;
                    </td>
                </tr>
            </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
</asp:Content>

