<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userlogin.aspx.cs" Inherits="userlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style ="background-image: url(img/userlogin.jpg);">
    <form id="form1" runat="server">
    <div>
        <br />
        <table style="width: 828px; height: 357px">
            <tr>
                <td colspan="2" style="height: 21px">
                    <strong><span style="font-family: Algerian">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 32pt;
                            color: #ffffff">MEENAKSHI ENTERPRISES</span></span></strong></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 65px">
                    &nbsp;<br />
                    <asp:Panel ID="Panel1" runat="server">
                        <div style="text-align: center">
                            <table style="width: 801px; height: 193px">
                                <tr>
                                    <td colspan="2" style="height: 20px">
                                        <span style="font-family: Algerian">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; <span style="font-size: 16pt"><strong>
                                                USER LOGIN</strong></span></span></td>
                                </tr>
                                <tr>
                                    <td style="width: 236px">
                                        <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<span style="font-size: 16pt"> <span
                                                style="color: #ffffff">USER NAME</span></span></strong><span style="font-size: 16pt;
                                                    color: #ffffff"> :</span></td>
                                    <td style="width: 125px; text-align: left">
                                        <asp:DropDownList ID="ddl1" runat="server" Font-Bold="True" Width="146px">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td style="width: 236px">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 16pt; color: #ffffff">&nbsp;&nbsp;
                                            <strong>PASSWORD</strong>:</span></td>
                                    <td style="width: 125px; text-align: left">
                                        <asp:TextBox ID="txt1" runat="server" AutoPostBack="True" TextMode="Password" Width="123px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="height: 26px">
                                        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp;
                                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF0066" Text="Label"></asp:Label>
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Font-Bold="True"
                                            ForeColor="#FFFFFF" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Show password" /></td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp;&nbsp; &nbsp;
                                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="16pt"
                                            OnClick="LinkButton1_Click">forgot password?</asp:LinkButton></td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="height: 33px">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp;
                                        <asp:Button ID="btnlog" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                                            OnClick="btnlog_Click" Style="background-color: transparent; border-radius: 40px"
                                            Text="LOGIN" Width="81px" />
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Button ID="btnbck" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                                            OnClick="btnbck_Click" Style="background-color: transparent" Text="BACK" Width="74px" /></td>
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
                                    <td style="width: 198px; text-align: right">
                                        <asp:Button ID="btnok" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFCCFF"
                                            OnClick="btnok_Click" Style="background-color: transparent" Text="OK" Width="86px" /></td>
                                    <td style="width: 85px; text-align: center">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Button ID="btnclear" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFCCFF"
                                            OnClick="btnclear_Click" Style="background-color: transparent" Text="CLEAR" Width="96px" /></td>
                                    <td style="width: 100px; text-align: left">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Button ID="btnhome" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#FFCCFF"
                                            OnClick="btnhome_Click" Style="background-color: transparent" Text="HOME" Width="81px" /></td>
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
    
    </div>
    </form>
</body>
</html>
