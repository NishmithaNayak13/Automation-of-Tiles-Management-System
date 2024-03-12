<%@ Page Language="C#" AutoEventWireup="true" CodeFile="unblock.aspx.cs" Inherits="unblock" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/unblock.jpeg);">
<center>
    <form id="form1" runat="server">
    <div style="background-position: center center; background-attachment: fixed;  background-repeat: no-repeat">
        <asp:Panel ID="Panel1" runat="server" Height="368px" Width="980px">
            <div style="text-align: center">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <center >
                <table style="width: 762px; height: 280px" frame="box">
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <strong><span style="font-size: 16pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 36pt"> <span style="color: #ffffff">UNBLOCK USER</span></span></span></strong></td>
                    </tr>
                    <tr>
                        <td style="width: 252px; height: 56px; text-align: center;">
                            <span style="font-family: Cambria; font-size: 16pt; color: #ffffff;"><strong><span
                                style="font-size: 24pt">Enter user name to unlock</span> :</strong></span></td>
                        <td style="width: 67px; height: 56px; text-align: center;">
                            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 252px; height: 56px; text-align: center">
                        <asp:Button ID="btnunblk" runat="server" Font-Bold="True" Font-Names="Cambria" Style="background-color: transparent"
                                Text="Unblock" OnClick="btnunblk_Click" Font-Size="16pt" ForeColor="#FFFFFF" Height="78px" Width="208px" />
                            &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        </td>
                        <td style="width: 67px; height: 56px; text-align: center">
                            &nbsp; &nbsp;<asp:Button ID="btnback" runat="server" Font-Bold="True" Font-Names="Cambria" Height="76px"
                                OnClick="btnback_Click" Style="background-color: transparent" Text="Back" Width="205px" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp;&nbsp;
                            &nbsp;</td>
                    </tr>
                </table>
                </center>
            </div>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;</div>
    </form>
    </center>
</body>
</html>
