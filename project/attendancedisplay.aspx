<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="attendancedisplay.aspx.cs" Inherits="attendancedisplay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
            <table style="width: 240px; height: 115px">
                <tr>
                    <td style="width: 100px">
                        <strong><span style="font-size: 16pt; font-family: Cambria; color: #ffffff;">Attendance details</span></strong></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 154px">
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#FFFFFF">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            </center>
</asp:Content>

