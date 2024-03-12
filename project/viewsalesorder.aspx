<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="viewsalesorder.aspx.cs" Inherits="viewsalesorder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="width: 518px; color: #ffffff; height: 155px">
            <tr>
                <td style="width: 100px">
                    <strong><span style="font-size: 14pt">SALES ORDER</span></strong></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    <br />
                    <br />
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

