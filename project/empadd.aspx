<%@ Page Language="C#" MasterPageFile="~/Mastermenu.master" AutoEventWireup="true" CodeFile="empadd.aspx.cs" Inherits="empadd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table id="TABLE1" border="3"  onclick="return TABLE1_onclick()" style="width: 912px;
        text-align: center; color: #ffffff;">
        <tr>
            <td colspan="3" style="height: 28px">
                <strong><span style="font-size: 24pt; font-family: Algerian; color: #ffffff;">Employee details</span></strong></td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="font-size: 16pt; color: #ffffff">Emp no :</span></strong></td>
            <td style="width: 233px; text-align: left;">
                <asp:TextBox ID="txtempno" runat="server" Style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
            <td style="width: 91px; text-align: center;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtempno"
                    ErrorMessage="Must enter emp no" Font-Bold="True" Font-Size="16pt" Width="175px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="font-weight: bold; color: #000000">
            <td style="width: 100px; text-align: center">
                <span style="font-size: 16pt; color: #ffffff">
                Emp name :</span></td>
            <td style="width: 233px; text-align: left;">
                <asp:TextBox ID="txtempname" runat="server" Style="background-color: transparent" ForeColor="#FFFFFF"></asp:TextBox></td>
            <td style="width: 91px; text-align: left;">
            </td>
        </tr>
        <tr style="font-weight: bold">
            <td style="width: 100px; text-align: center">
                <span style="font-size: 16pt; color: #ffffff">
                Address :</span></td>
            <td style="width: 233px; text-align: left;">
                <asp:TextBox ID="txtadd" runat="server" Style="background-color: transparent" TextMode="MultiLine"
                    Width="155px" ForeColor="#FFFFFF"></asp:TextBox></td>
            <td style="width: 91px">
            </td>
        </tr>
    <tr style="font-weight: bold">
        <td style="width: 100px; text-align: left">
            <span style="font-size: 16pt">Phone no :</span></td>
        <td style="width: 233px; text-align: left">
            <asp:TextBox ID="txtphno" runat="server" Style="background-color: transparent" ForeColor="#FFFFFF" MaxLength="10" OnTextChanged="txtphno_TextChanged"></asp:TextBox></td>
        <td style="width: 91px; text-align: left">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        </td>
    </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="font-size: 16pt; color: #ffffff">Designation </span></strong>
            </td>
            <td style="font-weight: bold; width: 233px; text-align: left;">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
                    <asp:ListItem Value="20000">Manager</asp:ListItem>
                    <asp:ListItem Value="10000">Assistant</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 91px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="font-size: 16pt; color: #ffffff">Email :</span></strong></td>
            <td style="width: 233px; text-align: left;">
                <asp:TextBox ID="txtemail" runat="server" Style="background-color: transparent" ForeColor="#FFFFFF" OnTextChanged="txtemail_TextChanged"></asp:TextBox></td>
            <td style="width: 91px; text-align: left;">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid email-id"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtemail" Font-Bold="True" Font-Size="16pt" Width="233px"></asp:RegularExpressionValidator></td>
        </tr>
        <tr style="color: #000000">
            <td style="width: 100px; text-align: center">
                <span style="font-size: 16pt"><span style="color: #ffffff"><strong>Date of birth </strong>
                    :</span></span></td>
            <td style="width: 233px; text-align: left">
                &nbsp;<asp:DropDownList ID="ddldt" runat="server" OnSelectedIndexChanged="ddldt_SelectedIndexChanged" >
                </asp:DropDownList>&nbsp;<asp:DropDownList ID="ddlmt" runat="server" OnSelectedIndexChanged="ddlmt_SelectedIndexChanged" >
                </asp:DropDownList>
                <asp:DropDownList ID="ddlyr" runat="server" OnSelectedIndexChanged="ddlyr_SelectedIndexChanged">
                </asp:DropDownList><br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
                &nbsp;
                <asp:Button ID="btnset" runat="server" Font-Bold="True" OnClick="btnset_Click" Text="SET" Width="82px" /><br />
                <br />
                &nbsp;
                <asp:TextBox ID="txtdob" runat="server"  Style="background-color: transparent" ForeColor="White" OnTextChanged="txtdob_TextChanged" ></asp:TextBox></td>
            <td style="width: 91px; text-align: left">
                &nbsp;<br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 31px; text-align: center">
                <strong><span style="font-size: 16pt; color: #ffffff">Age :</span></strong></td>
            <td style="width: 233px; height: 31px; text-align: left">
                &nbsp;<asp:TextBox ID="txtage" runat="server" Style="background-color: transparent" OnTextChanged="txtage_TextChanged" ForeColor="#FFFFFF" Width="153px"></asp:TextBox>
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Button ID="btnage" runat="server" Font-Size="12pt" ForeColor="#000033" OnClick="btnage_Click"
                    Text="Calculate Age" Width="124px" /></td>
            <td style="width: 91px; height: 31px; text-align: left">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="font-size: 16pt; color: #ffffff">Date of joining :</span></strong></td>
            <td style="width: 233px; text-align: left;">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" /><br />
                &nbsp;<asp:TextBox ID="txtdoj" runat="server" Style="background-color: transparent" OnTextChanged="txtdoj_TextChanged" ForeColor="#FFFFFF" Width="153px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <br />
                &nbsp;</td>
            <td style="width: 91px; text-align: left;">
                <br />
                &nbsp;&nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                    Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="color: #ffffff">Gender :</span></strong></td>
            <td style="width: 233px; text-align: left">
                <asp:RadioButton ID="male" runat="server" Font-Bold="True" OnCheckedChanged="male_CheckedChanged"
                    Text="Male" GroupName="s" Font-Size="16pt" ForeColor="#FFFFFF" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:RadioButton ID="female" runat="server" Font-Bold="True" OnCheckedChanged="female_CheckedChanged"
                    Text="Female" GroupName="s" Font-Size="16pt" ForeColor="#FFFFFF" />&nbsp;
            </td>
            <td style="width: 91px; text-align: left">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <strong><span style="color: #ffffff">Salary :</span></strong></td>
            <td style="width: 233px; text-align: left;">
                <asp:TextBox ID="txtsalary" runat="server" Style="background-color: transparent" ForeColor="#FFFFFF" ></asp:TextBox></td>
            <td style="width: 91px">
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 49px; text-align: center;">
                &nbsp;<asp:Button ID="btnadd" runat="server" Font-Bold="True" Font-Names="Algerian"
                    Height="41px" OnClick="btnadd_Click" Text="ADD" Width="103px" style="background-color: transparent; border-radius:30px;" ForeColor="#FFFFFF" Font-Size="16pt" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                <asp:Button ID="btnreset" runat="server"
                    Font-Bold="True" Font-Names="Algerian" Height="39px" Text="Reset" OnClick="btnreset_Click" style="background-color: transparent; border-radius:30px;" ForeColor="#FFFFFF" Width="136px" Font-Size="16pt" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Button ID="btnback" runat="server" Font-Bold="True" Font-Names="Algerian" Height="38px"
                    Text="BACK" OnClick="btnback_Click" style="background-color: transparent; border-radius:30px;" ForeColor="#FFFFFF" Width="108px" Font-Size="16pt" /></td>
        </tr>
    </table>
</asp:Content>

