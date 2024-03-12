<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="preturnmview.aspx.cs" Inherits="preturnmview" Title="Untitled Page" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True"
        DisplayGroupTree="False" Height="1039px" ReportSourceID="CrystalReportSource1"
        Width="773px" />
    <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        <Report FileName="CrystalReport4.rpt">
        </Report>
    </CR:CrystalReportSource>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</asp:Content>

