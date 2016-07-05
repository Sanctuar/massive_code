<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="panel.aspx.cs" Inherits="massive_code.panel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style47 {
        width: 9px;
    }
    .auto-style48 {
        width: 9px;
        height: 23px;
    }
    .auto-style49 {
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style48"></td>
        <td class="auto-style49">
            <asp:Label ID="Label_error" runat="server" style="color: #CC0000"></asp:Label>
        </td>
        <td class="auto-style49"></td>
        <td class="auto-style49">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style47">&nbsp;</td>
        <td class="auto-style2">
            <asp:Panel ID="Panel_info" runat="server" Visible="False">
                <asp:Label ID="Label_Login" runat="server" style="color: #006699"></asp:Label>
                <br />
                <asp:Label ID="Label_Name" runat="server" style="color: #006699"></asp:Label>
                <br />
                <asp:Label ID="Label_Surname" runat="server" style="color: #006699"></asp:Label>
                <br />
                <asp:Label ID="Label_Permission" runat="server" style="color: #006699"></asp:Label>
                <br />
                <asp:Label ID="Label_RegistrDate" runat="server" style="color: #006699"></asp:Label>
                <br />
                <asp:Label ID="Label_Mail" runat="server" style="color: #006699"></asp:Label>
            </asp:Panel>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton_ShowRegistrBase" runat="server" Visible="False" OnClick="LinkButton_ShowRegistrBase_Click">База регистрации пользователей</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style47">&nbsp;</td>
        <td class="auto-style2" colspan="2">
            <asp:GridView ID="GridView1" runat="server" Height="100%" Visible="False" Width="100%" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#33CCFF" />
                <Columns>
                    <asp:HyperLinkField NavigateUrl="~/information.aspx" Text="Edit">
                    <ControlStyle Font-Underline="True" />
                    </asp:HyperLinkField>
                </Columns>
                <HeaderStyle BackColor="#006699" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </td>
        <td class="auto-style2">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
