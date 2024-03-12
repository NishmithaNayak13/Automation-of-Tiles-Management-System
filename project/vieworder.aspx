<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="vieworder.aspx.cs" Inherits="vieworder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 518px; color: #ffffff; height: 155px">
            <tr>
                <td style="width: 100px">
                    PURCHASE ORDER</td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center;">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    <br />
                    <br />
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp;
                    <asp:Button ID="Button1" runat="server" Font-Size="14pt" ForeColor="#FFFFFF" OnClick="Button1_Click"
                        Style="background-color: transparent" Text="BACK" />&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

