<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deleteuser.aspx.cs" Inherits="deleteuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-position: center center; background-attachment: fixed; background-image: url(img/meenakshi.jpeg); background-repeat: no-repeat">
        <asp:Panel ID="Panel1" runat="server" Height="232px" Width="772px">
            <div style="text-align: center">
                <br />
                <table style="width: 598px; height: 301px">
                    <tr>
                        <td colspan="2" style="height: 40px">
                            <strong><span style="font-size: 14pt"><span style="font-size: 16pt">
                                <br />
                                <br />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; DELETE USER</span></span></strong></td>
                    </tr>
                    <tr>
                        <td style="width: 397px; height: 25px; text-align: right;">
                            <strong>Enter user name to delete: </strong>
                        </td>
                        <td style="width: 80px; height: 25px;">
                            <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 32px">
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                            <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" Text="SUBMIT" OnClick="btnsubmit_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                            <asp:Button ID="btnback" runat="server" Font-Bold="True" OnClick="btnback_Click"
                                Text="BACK" /></td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
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
