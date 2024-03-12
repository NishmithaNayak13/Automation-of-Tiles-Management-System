<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminoptions.aspx.cs" Inherits="adminoptions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/adminoption.jpg)">
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center; background-image: none;">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;
            <table style="width: 219px; height: 1px; text-align: left;">
                <tr>
                    <td style="width: 394px; height: 97px; text-align: left;">
                        &nbsp; 
                        <asp:Button ID="btnadd" runat="server" Font-Bold="True" OnClick="btnadd_Click" Text="ADD USER" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /><br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 394px; height: 97px; text-align: left">
                        <asp:Button ID="btndlt" runat="server" Font-Bold="True" Text="DELETE USER" Width="144px" OnClick="btndlt_Click" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                </tr>
                <tr>
                    <td style="width: 394px; height: 97px; text-align: left">
                        <asp:Button ID="btnunblk" runat="server" Font-Bold="True" Text="UNBLOCK" OnClick="btnunblk_Click" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                </tr>
                <tr>
                    <td style="width: 394px; height: 97px; text-align: left">
                        <asp:Button ID="btnemp" runat="server" Font-Bold="True" OnClick="btnemp_Click" Text="EMPLOYEE" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                </tr>
                <tr>
                    <td style="width: 394px; height: 97px; text-align: left">
                        <asp:Button ID="btnexit" runat="server" Font-Bold="True" Text="EXIT" OnClick="btnexit_Click" Width="75px" style="background-color: transparent" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
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
        </div>
    
    </div>
    </form>
</body>
</html>
