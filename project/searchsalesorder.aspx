<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="searchsalesorder.aspx.cs" Inherits="searchsalesorder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 604px; height: 125px">
        <tr>
            <td style="width: 100px">
                <span style="font-size: 16pt; color: #ffffff"><strong>Sales order number to search</strong></span></td>
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
                &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Font-Bold="True"
                    ForeColor="White">
                    <Columns>
                        <asp:BoundField DataField="cust_id" HeaderText="CUSTOMER_ID" />
                        <asp:BoundField DataField="name" HeaderText="NAME" />
                        <asp:BoundField DataField="so_no" HeaderText="SALES_ORDER_NO" />
                        <asp:BoundField DataField="s_date" HeaderText="SALES_DATE" />
                        <asp:BoundField DataField="due_date" HeaderText="DUE_DATE" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

