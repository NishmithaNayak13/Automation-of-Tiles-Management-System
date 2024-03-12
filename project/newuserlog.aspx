<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newuserlog.aspx.cs" Inherits="newuserlog" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/userlogin.jpg);">
    <form id="form1" runat="server">
    <div><div style="background-position: center center; background-attachment: fixed; background-repeat: no-repeat">
        <asp:Panel ID="Panel1" runat="server" Height="252px" Width="815px">
            <div style="text-align: center">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <center>
                    <table style="width: 790px; height: 297px">
                        <tr>
                            <td style="width: 302px; height: 41px; text-align: right">
                                &nbsp; &nbsp;<strong> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</strong></td>
                            <td style="width: 100px; height: 41px; text-align: left">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 302px; text-align: right">
                                <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; <span style="font-size: 16pt; color: #ffffff">NEW</span></strong><span style="font-size: 16pt;
                                        color: #ffffff"> <strong>PASSWORD</strong> :</span></td>
                            <td style="width: 100px; text-align: left">
                                <asp:TextBox ID="txt1" runat="server" OnTextChanged="txt1_TextChanged" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 302px; height: 40px; text-align: right">
                                <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; <span style="font-size: 16pt;
                                        color: #ffffff">CONFIRM</span></strong><span style="font-size: 16pt; color: #ffffff">
                                            <strong>PASSWORD</strong> :</span></td>
                            <td style="width: 100px; height: 40px; text-align: left">
                                <asp:TextBox ID="txt2" runat="server" OnTextChanged="txt2_TextChanged" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 302px; height: 40px; text-align: right">
                            </td>
                            <td style="width: 100px; height: 40px; text-align: left">
                                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Font-Bold="True"
                                    ForeColor="#FFCCFF" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Show password"
                                    Width="122px" /></td>
                        </tr>
                        <tr>
                            <td style="width: 302px; height: 40px; text-align: right">
                                <strong><span style="font-size: 16pt; color: #ffffff">SECURITY &nbsp; QUESTION:</span></strong></td>
                            <td style="width: 100px; height: 40px; text-align: left">
                                <asp:Label ID="Label1" runat="server" ForeColor="#FFFFFF" Text="Label"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 302px; height: 40px; text-align: right">
                                <strong><span style="font-size: 16pt; color: #ffffff">SET SECURITY ANSWER:</span></strong></td>
                            <td style="width: 100px; height: 40px; text-align: left">
                                <asp:TextBox ID="txta" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 302px; height: 40px; text-align: right">
                            </td>
                            <td style="width: 100px; height: 40px; text-align: left">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height: 62px; text-align: center">
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFCCFF"
                                    Height="59px" OnClick="btnsave_Click" Style="background-color: transparent" Text="SAVE"
                                    Width="140px" />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                <asp:Button ID="btnbk" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFCCFF"
                                    Height="59px" OnClick="btnbk_Click" Style="background-color: transparent" Text="BACK"
                                    Width="130px" /></td>
                        </tr>
                    </table>
                </center>
                <br />
            </div>
        </asp:Panel>
        &nbsp;<br />
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
        &nbsp;</div>
    
    </div>
    </form>
</body>
</html>
