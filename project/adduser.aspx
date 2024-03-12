<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="adduser.aspx.cs" Inherits="img_adduser" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<center>
        <form id="form1" runat="server">
            <div>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
                &nbsp; &nbsp;<asp:Panel ID="Panel1" runat="server" BorderStyle="None" Height="1px"
                    Width="361px">
                    <div style="background-color: transparent; text-align: center">
                        <br />
                        <center>--%>
                            <table style="width: 1px; height: 1px">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <span style="color: #ffffff"><span style="color: #000000">AD</span><span style="color: #000000">D
                                            NEW ACCOUNT</span></span></td>
                                </tr>
                                <tr>
                                    <td style="width: 7px; height: 45px; text-align: center">
                                        <strong>
                                            
                                            <span style="font-size: 16pt;
                                                color: #ffffff"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;USER
                                                NAME</span> :</strong></td>
                                    <td style="width: 36px; height: 45px; background-color: transparent; text-align: left">
                                        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 7px; height: 48px; text-align: right">
                                    </td>
                                    <td style="width: 36px; height: 48px; background-color: transparent; text-align: left">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 7px; text-align: center">
                                        <strong><span style="font-size: 16pt; color: #ffffff">PASSWORD :</span></strong></td>
                                    <td style="width: 36px; text-align: left">
                                        <asp:TextBox ID="txtpass" runat="server" Enabled="False">user</asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 7px; height: 15px; text-align: center">
                                        <strong>
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; <span style="font-size: 16pt; color: #ffffff">
                                                STATUS</span> :<span style="font-size: 16pt; color: #ffffff">:</span></strong></td>
                                    <td style="width: 36px; height: 15px; text-align: left">
                                        <asp:TextBox ID="txtstatus" runat="server" Enabled="False" Font-Bold="True">open</asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="text-align: right">
                                        <asp:Label ID="Label1" runat="server" ForeColor="#FF0066" Text="."></asp:Label></td>
                                </tr>
                                <tr>
                                    <td colspan="1" style="text-align: center">
                                        <span style="color: #ffffff"><span style="font-size: 16pt"><strong>SECURITY QUESTION</strong></span></span></td>
                                    <td colspan="1" style="text-align: right">
                                        <asp:TextBox ID="txtques" runat="server" Font-Size="14pt" ForeColor="#FFCC00" Style="background-color: transparent">Which is your fav place?</asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="height: 26px">
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        <asp:Button ID="btnadd" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                                            OnClick="btnadd_Click" Style="background-color: transparent" Text="ADD" Width="80px" />
                                        &nbsp; &nbsp; &nbsp; &nbsp;
                                        <asp:Button ID="btnb" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                                            OnClick="btnb_Click" Style="background-color: transparent" Text="BACK" Width="112px" />
                                        &nbsp;&nbsp; &nbsp;
                                        <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#FFFFFF"
                                            OnClick="btnsave_Click" Style="background-color: transparent" Text="SAVE" Width="98px" /></td>
                                </tr>
                            </table>
                        <%--</center>
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
                &nbsp;<br />
                <br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            </div>
        </form>
    </center>--%>
</asp:Content>

