<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="payslip.aspx.cs" Inherits="payslip" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <div style="text-align: center">
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="btnnew" runat="server" OnClick="btnnew_Click" Text="NEW" />
            <asp:Button ID="btncompute" runat="server" OnClick="btncompute_Click" Text="COMPUTE" /><br />
                    <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="SAVE" /><br />
                    <asp:Button ID="btndisplay" runat="server" OnClick="btndisplay_Click" Text="DISPLAY" /></asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server">
            <table>
                <tr>
                    <td style="width: 100px">
                        <span style="color: #ffffff">Select employee name </span>
                    </td>
                    <td style="width: 100px">
                    <asp:DropDownList ID="ddl1" runat="server" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="SUBMIT" /></td>
                </tr>
            </table>
        </asp:Panel>
        <div style="text-align: center">
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="no record found"
                Width="274px"></asp:Label>&nbsp;</div>
        <br />
        <asp:Panel ID="Panel3" runat="server">
        <table style="color: #ffffff">
            <tr>
                <td style="height: 21px;" colspan="2">
                    <span>SALARY</span></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    ID</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px;">
                    <span>NAME :</span></td>
                <td style="width: 100px; height: 21px;">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    DESIGNATION</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtdesig" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span>BASIC PAY: </span>
                </td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtbasic" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span>WORK DAYS</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtwork" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span>EXTRA LEAVE</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtleave" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span>BONUS</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtbonus" runat="server"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label1" runat="server" ForeColor="#FF0033" Text="*"></asp:Label></td>
            </tr>
            <tr style="font-weight: bold; color: #ffffff">
                <td style="width: 100px; height: 21px;">
                    <span>PF :</span></td>
                <td style="width: 100px; height: 21px;">
                    <asp:TextBox ID="txtpf" runat="server"></asp:TextBox></td>
            </tr>
            <tr style="font-weight: bold">
                <td style="width: 100px">
                    <span>GROSS PAY</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtgross" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span>NET PAY :</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtnet" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp; &nbsp; &nbsp;
                </td>
            </tr>
        </table>
        </asp:Panel>
        <br />
        <br />
        <br />
    </div>
            </center>
</asp:Content>

