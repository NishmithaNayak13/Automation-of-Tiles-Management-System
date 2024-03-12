<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="searchorder.aspx.cs" Inherits="searchorder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 604px; height: 125px">
        <tr>
            <td style="width: 100px">
                <span style="font-size: 16pt; color: #ffffff"><strong>Supplier name to search</strong></span></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnsubmit" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#FFFFFF"
                    OnClick="btnsubmit_Click" Style="background-color: transparent" Text="Submit" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp;
                <asp:Button ID="Button1" runat="server" Font-Size="14pt" ForeColor="#FFFFFF" OnClick="Button1_Click"
                    Style="background-color: transparent" Text="Back" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" Font-Bold="True" ForeColor="#FFFFFF" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="sup_id" HeaderText="SUPPLIER_ID" />
                        <asp:BoundField DataField="name" HeaderText="NAME" />
                        <asp:BoundField DataField="po_no" HeaderText="PURCHASE_ORDER_NO" />
                        <asp:BoundField DataField="p_date" HeaderText="PURCHASE_DATE" />
                        <asp:BoundField DataField="due_date" HeaderText="DUE_DATE" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

