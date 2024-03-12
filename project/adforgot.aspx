<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adforgot.aspx.cs" Inherits="adforgot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/adforgot.jpg)">
<center>
    <form id="form1" runat="server">
        <br />
        <div style="text-align: center; background-position: center center; background-attachment: fixed; background-image: url(img/adforgot.jpg); background-repeat: no-repeat;">
            <center ><table style="width: 860px; height: 391px">
                <tr>
                    <td style="width: 107px">
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Panel ID="Panel1" runat="server">
                            <div style="text-align: center">
                                <table style="width: 1012px; height: 141px; text-align: center;">
                                    <tr>
                                        <td style="width: 149px; height: 38px; text-align: right;">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 14pt">
                                                    &nbsp; <span style="color: #ffffff; font-size: 16pt;">Security&nbsp; question :</span></span></span></strong></td>
                                        <td style="width: 100px; height: 38px; text-align: left;">
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                            </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 149px; height: 32px; text-align: center;">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 16pt">
                                                    &nbsp; &nbsp;
                                                <span style="color: #ffffff">
                                                Answer :</span></span></span></strong></td>
                                        <td style="width: 100px; height: 32px; text-align: left;">
                                            <asp:TextBox ID="txt1" runat="server" OnTextChanged="txt1_TextChanged"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnsub" runat="server" Font-Bold="True" Font-Names="Cambria" Style="background-color: transparent"
                                                Text="Submit" OnClick="btnsub_Click" Font-Size="14pt" ForeColor="#FFFFFF" />
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server"
                                                Font-Bold="True" Text="Label" Font-Size="14pt" ForeColor="#FFFFFF"></asp:Label></td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td style="width: 107px; height: 262px;">
                        &nbsp;<asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table style="width: 954px; height: 156px">
                                    <tr>
                                        <td style="width: 209px; height: 31px; text-align: center;">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 14pt; color: #ffffff">
                                                    &nbsp; &nbsp; New password :</span></span></strong></td>
                                        <td style="width: 100px; height: 31px; text-align: left;">
                                            <asp:TextBox ID="txt2" runat="server" AutoPostBack="True" TextMode="Password" OnTextChanged="txt2_TextChanged"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 209px; text-align: center;">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="font-size: 14pt; color: #ffffff">&nbsp; &nbsp;Confirm password :</span></span></strong></td>
                                        <td style="width: 100px; text-align: left;">
                                            <asp:TextBox ID="txt3" runat="server" AutoPostBack="True" TextMode="Password"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Text="Show password" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" Font-Size="14pt" ForeColor="#FFFFFF" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 31px">
                                            <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Names="Cambria" Style="background-color: transparent"
                                                Text="Save" OnClick="btnsave_Click" Font-Size="14pt" ForeColor="#FFFFFF" />
                                            &nbsp; &nbsp; &nbsp;&nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
            </center>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
    </center>
</body>
</html>
