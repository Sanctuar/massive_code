<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="massive_code.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style32 {
            width: 100%;
            height: 270px;
        }
        .auto-style43 {
            width: 665px;
            height: 6px;
            color: #006600;
            font-size: large;
        }
        .auto-style48 {
            width: 665px;
            }
        .auto-style54 {
            width: 215px;
            color: #006699;
        }
        .auto-style56 {
            background-color: #CCCCCC;
        }
        .auto-style57 {
            cursor: pointer;
            color: #FFFFFF;
            font-size: small;
            background-color: #009933;
        }
        .auto-style58 {
            width: 94px;
            height: 6px;
        }
        .auto-style59 {
            height: 6px;
        }
        .auto-style60 {
            width: 94px;
        }
        .auto-style61 {
            color: #CC0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style32">
        <tr>
            <td class="auto-style58"></td>
            <td class="auto-style43"><strong>Зарегистрироваться в системе</strong></td>
            <td class="auto-style59"></td>
        </tr>
        <tr>
            <td class="auto-style60"></td>
            <td class="auto-style48">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style54">Имя</td>
                        <td>
                            <asp:TextBox ID="TextBox_name" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_name_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">Фамилия</td>
                        <td>
                            <asp:TextBox ID="TextBox_surname" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_surname_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">Логин</td>
                        <td>
                            <asp:TextBox ID="TextBox_login" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_login_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">Адрес электронной почты</td>
                        <td>
                            <asp:TextBox ID="TextBox_mail" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_mail_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">Пароль</td>
                        <td>
                            <asp:TextBox ID="TextBox_pass" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_pass_TextChanged" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">Подтверждение пароля</td>
                        <td>
                            <asp:TextBox ID="TextBox_repass" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_repass_TextChanged" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label_Registr_Error" runat="server" CssClass="auto-style61"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style54">&nbsp;</td>
                        <td>
                    <asp:Button ID="butt_regist" runat="server" BackColor="#009933" BorderStyle="None" BorderWidth="0px" CssClass="auto-style57" Font-Names="Times New Roman" ForeColor="White" Height="26px" Text="регистрация" Width="101px" OnClick="butt_regist_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td></td>
        </tr>
        </table>
</asp:Content>
