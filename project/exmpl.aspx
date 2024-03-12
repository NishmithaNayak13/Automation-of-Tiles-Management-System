<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="exmpl.aspx.cs" Inherits="exmpl" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView2" runat="server" ForeColor="White" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="item_id" HeaderText="ITEM ID" />
            <asp:BoundField DataField="it_name" HeaderText="item name" />
            <asp:BoundField DataField="tot_no_of_pc" HeaderText="tot_no_of_pc" />
        </Columns>
    </asp:GridView>
</asp:Content>

