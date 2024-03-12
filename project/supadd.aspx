<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="supadd.aspx.cs" Inherits="supadd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 470px">
            <caption>
                <span style="font-size: 24pt; color: #ffffff"><strong>Supplier Details</strong></span></caption>
            <tr>
                <td style="width: 100px; text-align: left;">
                    <span style="color: #ffffff"><strong>Supplier_id</strong></span></td>
                <td style="width: 100px; text-align: left;">
                    <asp:TextBox ID="txtsupid" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left;">
                    <span style="color: #ffffff"><strong>Supplier Name</strong></span></td>
                <td style="width: 100px; text-align: left;">
                    <asp:TextBox ID="txtsupname" runat="server" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left;">
                    <span style="color: #ffffff"><strong>Address</strong></span></td>
                <td style="width: 100px; text-align: left;">
                    <asp:TextBox ID="txtsupadd" runat="server" TextMode="MultiLine" style="background-color: transparent" ForeColor="#FFFFFF" Width="151px"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left;">
                    <span style="color: #ffffff"><strong>Contact No</strong></span></td>
                <td style="width: 100px; text-align: left;">
                    <asp:TextBox ID="txtcontact" runat="server" MaxLength="10" OnTextChanged="txtcontact_TextChanged" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
                <td style="width: 120px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: left;">
                    <span style="color: #ffffff"><strong>Email</strong></span></td>
                <td style="width: 100px; text-align: left;">
                    <asp:TextBox ID="txtemail" runat="server" OnTextChanged="txtemail_TextChanged" style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
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
                        OnClick="btnclear_Click" Style="background-color: transparent" Text="Clear" Width="72px" /></td>
            </tr>
        </table>
    </div>
</asp:Content>

