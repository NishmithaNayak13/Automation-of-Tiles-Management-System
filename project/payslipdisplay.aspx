<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="payslipdisplay.aspx.cs" Inherits="payslipdisplay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="color: #ffffff">
        <div style="text-align: center">
            <table style="width: 550px">
                <tr>
                    <td style="width: 100px">
                        EMPLOYEE SALARY INFORMATION</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="empno" HeaderText="ID" />
                                <asp:BoundField DataField="name" HeaderText="NAME" />
                                <asp:BoundField DataField="edesig" HeaderText="DESIGNATION" />
                                <asp:BoundField DataField="ebasic" HeaderText="BASIC PAY" />
                                <asp:BoundField DataField="presentdays" HeaderText="PRESENT DAYS" />
                                <asp:BoundField DataField="absentdays" HeaderText="ABSENT DAYS" />
                                <asp:BoundField DataField="bonus" HeaderText="BONUS" />
                                <asp:BoundField DataField="pf" HeaderText="PROVIDENT FUND" />
                                <asp:BoundField DataField="gross" HeaderText="GROSS PAY" />
                                <asp:BoundField DataField="net" HeaderText="NET AMOUNT" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label ID="Label1" runat="server" ForeColor="#FF0033" Text="NO RECORDS FOUND"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BACK" /></td>
                </tr>
            </table>
        </div>
    </span>
</asp:Content>

