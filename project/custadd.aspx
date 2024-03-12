<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="custadd.aspx.cs" Inherits="custadd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 470px">
            <caption>
                <span style="font-size: 24pt; color: #ffffff"><strong>Customer Details</strong></span></caption>
            <tr>
                <td style="width: 100px; text-align: left">
                    <span style="color: #ffffff"><strong>Customer_id</strong></span></td>
                <td style="width: 100px; text-align: left">
                    <asp:TextBox ID="txtcustid" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left">
                    <span style="color: #ffffff"><strong>Customer Name</strong></span></td>
                <td style="width: 100px; text-align: left">
                    <asp:TextBox ID="txtcustname" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left">
                    <span style="color: #ffffff"><strong>Address</strong></span></td>
                <td style="width: 100px; text-align: left">
                    <asp:TextBox ID="txtcustadd" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"
                        TextMode="MultiLine" Width="151px"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left">
                    <span style="color: #ffffff"><strong>Contact No</strong></span></td>
                <td style="width: 100px; text-align: left">
                    <asp:TextBox ID="txtcontact" runat="server" ForeColor="#FFFFFF" MaxLength="10" OnTextChanged="txtcontact_TextChanged"
                        Style="background-color: transparent"></asp:TextBox></td>
                <td style="width: 120px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcontact"
                        ErrorMessage="Enter valid phone no" ValidationExpression="^([6-9]{1})([0-9]{9})$"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left">
                    <span style="color: #ffffff"><strong>Email</strong></span></td>
                <td style="width: 100px; text-align: left">
                    <asp:TextBox ID="txtemail" runat="server" ForeColor="#FFFFFF" OnTextChanged="txtemail_TextChanged"
                        Style="background-color: transparent"></asp:TextBox></td>
                <td style="width: 120px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail"
                        ErrorMessage="Enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        Width="117px"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnsave" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#FFFFFF"
                        OnClick="btnsave_Click" Style="background-color: transparent" Text="Save" Width="65px" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btnclear" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#FFFFFF"
                        OnClick="btnclear_Click" Style="background-color: transparent" Text="Clear" Width="72px" />&nbsp;
                    <asp:Button ID="btnneworder" runat="server" ForeColor="#FFFFFF" Height="28px" Style="background-color: transparent"
                        Text="New order" Width="121px" Font-Bold="True" Font-Size="12pt" OnClick="btnneworder_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>

