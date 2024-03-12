<%@ Page Language="C#" AutoEventWireup="true" CodeFile="employee.aspx.cs" Inherits="employee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(img/empl.jpg)">
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <br />
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
                &nbsp;</center>
            <center>
            <table style="width: 869px; height: 291px">
                <tr>
                    <td style="width: 86px; text-align: center;">
                        &nbsp;<asp:Button ID="btndt" runat="server" Font-Bold="True" Height="45px" OnClick="btndt_Click"
                            Style="background-color: transparent ; border-radius:30px;" Text="Emp Details" Font-Size="16pt" Width="190px" ForeColor="#FFFFFF" /></td>
                    <td style="width: 91px; text-align: center;">
                        <asp:Button ID="btnat" runat="server" Font-Bold="True" Height="42px" Style="background-color: transparent ; border-radius:30px;"
                            Text="Attendance" OnClick="btnat_Click" Font-Size="16pt" Width="188px" ForeColor="#FFFFFF" /></td>
                    <td style="width: 100px; text-align: center;">
                        &nbsp;<asp:Button ID="btnpay" runat="server" Font-Bold="True" Height="40px" Style="background-color: transparent ; border-radius:30px;"
                            Text="Pay Slip" OnClick="btnpay_Click" Font-Size="16pt" ForeColor="#FFFFFF" Width="124px" /></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:ImageButton ID="ImageButton1" runat="server" Style="background-image: url(img/Lighthouse.jpg)"
                            Width="82px" ImageUrl="~/img/employee.png" Height="64px" OnClick="ImageButton1_Click" /></td>
                </tr>
            </table>
            </center>
        </div>
    
    </div>
    </form>
</body>
</html>
