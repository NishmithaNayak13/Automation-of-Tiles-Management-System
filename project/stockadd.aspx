<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="stockadd.aspx.cs" Inherits="stockadd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 16pt; color: #ffffff"><strong>&nbsp;</strong></span><div
        style="text-align: center">
        <table style="font-weight: bold; font-size: 16pt; color: #ffffff">
            <tr>
                <td colspan="4">
                    <span style="font-size: 24pt">
                    STOCK
                        <br />
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 40px">
                    CATEGORY ID:</td>
                <td style="width: 100px; height: 40px">
                    <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl1_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 100px; height: 40px">
                    CATEGORY TYPE :</td>
                <td style="width: 100px; height: 40px">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    ITEM ID</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    HSN</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox7" runat="server" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    ITEM NAME</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="color: white;
                        background-color: transparent" OnTextChanged="TextBox2_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    PRICE</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnTextChanged="TextBox3_TextChanged"
                        Style="background-color: transparent"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px">
                    PC_PER_BOX</td>
                <td colspan="3" style="height: 21px">
                    <asp:TextBox ID="TextBox4" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    NO OF BOX</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox5" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    REORDER LEVEL
                </td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox6" runat="server" Font-Bold="True" ForeColor="#FFFFFF" Style="background-color: transparent"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="Button1_Click"
                        Style="background-color: transparent" Text="ADD" /></td>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="#FFFFFF" OnClick="Button2_Click"
                        Style="background-color: transparent" Text="RESET" /></td>
            </tr>
        </table>
    </div>
</asp:Content>

