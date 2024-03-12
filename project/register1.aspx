<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register1.aspx.cs" Inherits="register1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/register1.jpg)">
    <form id="form1" runat="server">
    <div>
    <table border="0" style="width: 592px; height: 131px; text-align: center;" frame="border">
                <tr>
                    <td colspan="2" style="height: 143px">
                        <strong><span style="font-size: 48pt; color: #ffffff; font-family: Algerian">LOGIN</span></strong></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: center;">
                        <asp:Button ID="btnadmin" runat="server" Font-Bold="True" OnClick="btnadmin_Click"
                            Style="background-color: transparent ; border-radius:30px;" Text="ADMIN" Width="141px" ForeColor="#33FFFF" Height="76px" Font-Size="24pt" /></td>
                    <td style="width: 100px">
                        &nbsp; &nbsp;
                        <asp:Button ID="btnuser" runat="server" Font-Bold="True" OnClick="btnuser_Click"
                            Style="background-color: transparent ; border-radius:30px;" Text="USER" Width="132px" ForeColor="#00FFFF" Height="75px" Font-Size="24pt" /></td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
