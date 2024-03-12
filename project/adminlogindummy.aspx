<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="adminlogindummy.aspx.cs" Inherits="adminlogin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <center >
            <div style="text-align: center">
                <table>
                    <tr>
                        <td colspan="2" style="height: 227px">
                            <asp:Label ID="Label1" runat="server" Text="MEENAKSHI ENTERPRISES" Font-Bold="True" Font-Italic="True" Font-Names="Algerian" Font-Size="32pt" Height="22px" Width="390px" style="background-color: transparent" ForeColor="White"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 82px">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="User Name:" Font-Size="16pt" ForeColor="#FFFFFF"></asp:Label></td>
                        <td style="width: 100px; height: 82px">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="14pt" Text="ADMIN"
            Width="124px" ForeColor="#FFFFFF"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 76px">
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Style="background-color: transparent"
            Text="Password:" Font-Size="16pt" ForeColor="#FFFFFF"></asp:Label></td>
                        <td style="width: 100px; height: 76px">
                            <asp:TextBox ID="txtpass" runat="server" Width="143px" TextMode="Password" style="background-color: transparent" AutoPostBack="True" Font-Bold="True" AutoCompleteType="Disabled" OnTextChanged="txtpass_TextChanged" ForeColor="#FFFFFF"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 54px">
        <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Khaki"
            Text="Show Password" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged1" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 116px">
                            <asp:Button ID="btnlogin" runat="server" Font-Bold="True" Font-Names="Algerian" Font-Size="24pt"
            Height="50px" Style="background-color: transparent; border-radius:30px; text-align: center; visibility: visible; clip: rect(auto auto auto auto);" Text="Login"
            Width="129px" OnClick="btnlogin_Click" ForeColor="#FFFFFF" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 48px">
        <asp:LinkButton ID="lnkforgot" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Gold"
            Style="border-top-style: groove; border-left-style: inset"
            Width="135px" OnClick="lnkforgot_Click" >forgot password?</asp:LinkButton></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 69px">
        <asp:Button ID="btnback" runat="server" Font-Bold="True" Style="background-color: transparent"
            Text="BACK" OnClick="btnback_Click" Font-Size="16pt" ForeColor="#FFFFFF" /></td>
                    </tr>
                </table>
            </div>
        </center><br />
        <br />
        &nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp;<br />
        &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;<br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
  
</asp:Content>

