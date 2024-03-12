<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userforgot.aspx.cs" Inherits="userforgot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style ="background-image: url(img/userforgot.jpg);">
    <form id="form1" runat="server">
    <div>
        <div style="background-position: center center; background-attachment: fixed; background-repeat: no-repeat">
            <table style="width: 860px; height: 391px">
                <tr>
                    <td style="width: 107px">
                        <br />
                        <asp:Panel ID="Panel1" runat="server">
                            <div style="text-align: center">
                                <table style="width: 1012px; height: 141px">
                                    <tr>
                                        <td style="width: 149px; height: 38px">
                                            <span style="font-family: Cambria">&nbsp; &nbsp;<strong> &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<span style="color: #cc9966"> <span style="font-size: 16pt">
                                                    Security question :</span></span></strong></span></td>
                                        <td style="width: 100px; height: 38px; text-align: left">
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                            </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 149px; height: 32px">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 16pt">
                                                    &nbsp; &nbsp; &nbsp; &nbsp; <span style="color: #cc9966">Answer :</span></span></span></strong></td>
                                        <td style="width: 100px; height: 32px; text-align: left">
                                            <asp:TextBox ID="txt1" runat="server" OnTextChanged="txt1_TextChanged"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 26px">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="btnsub" runat="server"
                                                Font-Bold="True" Font-Names="Cambria" Font-Size="16pt" ForeColor="#CC9966" OnClick="btnsub_Click"
                                                Style="background-color: transparent" Text="Submit" />
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server"
                                                Font-Bold="True" Font-Size="16pt" ForeColor="#CC9966" Text="Label"></asp:Label></td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td style="width: 107px; height: 262px">
                        &nbsp;<asp:Panel ID="Panel2" runat="server">
                            <div style="text-align: center">
                                <table style="width: 954px; height: 156px">
                                    <tr>
                                        <td style="width: 209px; height: 31px">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="color: #cc9966">
                                                    <span style="font-size: 16pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; New <span>password :</span></span></span></span></strong></td>
                                        <td style="width: 100px; height: 31px; text-align: left">
                                            <asp:TextBox ID="txt2" runat="server" AutoPostBack="True" OnTextChanged="txt2_TextChanged"
                                                TextMode="Password"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 209px">
                                            <strong><span style="font-family: Cambria">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 16pt; color: #cc9966"> &nbsp;
                                                    &nbsp;Confirm password :</span></span></strong></td>
                                        <td style="width: 100px; text-align: left">
                                            <asp:TextBox ID="txt3" runat="server" AutoPostBack="True" TextMode="Password"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 209px">
                                        </td>
                                        <td style="width: 100px; text-align: left">
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt2"
                                                ControlToValidate="txt3" ErrorMessage="both passwords should be same">.</asp:CompareValidator></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Font-Bold="True"
                                                Font-Size="16pt" ForeColor="#CC9966" OnCheckedChanged="CheckBox1_CheckedChanged"
                                                Text="Show password" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 31px">
                                            <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Names="Cambria" Font-Size="16pt"
                                                ForeColor="#FFCC66" OnClick="btnsave_Click" Style="background-color: transparent"
                                                Text="Save" Width="132px" />
                                            &nbsp; &nbsp; &nbsp;&nbsp;
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
    </form>
</body>
</html>
