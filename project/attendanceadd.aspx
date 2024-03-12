<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="attendanceadd.aspx.cs" Inherits="attendanceadd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
            <table style="width: 524px; height: 321px" border="3">
                <caption>
                    <strong><span style="font-size: 24pt; text-decoration: underline; color: #ffffff;">Attendance</span></strong></caption>
                <tr>
                    <td style="width: 100px; height: 21px; text-align: center;">
                        <strong><span style="color: #ffffff">
                        Select empname</span></strong></td>
                    <td style="width: 100px; height: 21px">
                        <asp:DropDownList ID="ddl1" runat="server" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 21px">
                        <strong><span style="color: #ffffff">Eno</span></strong></td>
                    <td style="width: 100px; height: 21px">
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 21px; text-align: center;">
                        <strong><span style="color: #ffffff">&nbsp; &nbsp; &nbsp;
                        Name</span></strong></td>
                    <td style="width: 100px; height: 21px">
                        <asp:TextBox ID="txt2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Month</span></strong></td>
                    <td style="width: 100px">
                        &nbsp;<asp:TextBox ID="txt3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Year</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Total days</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">leave given</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt6" runat="server" OnTextChanged="txt6_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Leave taken</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Extra leave</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt8" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Working days</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txt9" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong><span style="color: #ffffff">Status</span></strong></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="txtstatus" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 36px">
                        <asp:Button ID="btnclear" runat="server" Font-Bold="True" Text="Clear" OnClick="btnclear_Click"  />
                        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnsave"
                            runat="server" Font-Bold="True" Text="Save" Width="72px" OnClick="btnsave_Click" />
                        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;<asp:Button
                            ID="btncal" runat="server" Font-Bold="True" OnClick="btncal_Click" Text="calculate" /></td>
                </tr>
            </table>
            </center>
</asp:Content>

