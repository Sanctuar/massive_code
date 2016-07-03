<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="massive_code.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style32 {
            width: 100%;
            height: 270px;
        }
        .auto-style43 {
            width: 531px;
            height: 34px;
            color: #006600;
            font-size: large;
        }
        .auto-style48 {
            width: 531px;
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
            width: 17px;
            height: 34px;
        }
        .auto-style59 {
            height: 34px;
            color: #006699;
        }
        .auto-style61 {
            color: #CC0000;
        }
        .auto-style62 {
            width: 17px;
        }
        .auto-style63 {
            width: 88px;
        }
        .auto-style64 {
            width: 88px;
            color: #006600;
        }
        .auto-style65 {
            width: 100%;
            height: 161px;
        }
        .auto-style66 {
            cursor: pointer;
            color: #FFFFFF;
            font-size: small;
            background-color: #006699;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style32">
        <tr>
            <td class="auto-style58"></td>
            <td class="auto-style43">РЕГИСТРАЦИЯ В СИСТЕМЕ<br />
                введите учетные данные</td>
            <td class="auto-style59">АВТОРИЗАЦИЯ<br />
                введите логин и пароль</td>
        </tr>
        <tr>
            <td class="auto-style62"></td>
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
                            <asp:TextBox ID="TextBox_mail" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="292px" OnTextChanged="TextBox_mail_TextChanged" TextMode="Email"></asp:TextBox>
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
            <td>
                <table class="auto-style65">
                    <tr>
                        <td class="auto-style64">Логин</td>
                        <td>
                            <asp:TextBox ID="TextBox_SignIn_Login" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="239px" OnTextChanged="TextBox_SignIn_Login_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style64">Пароль</td>
                        <td>
                            <asp:TextBox ID="TextBox_SignIn_Pass" runat="server" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style56" Width="239px" OnTextChanged="TextBox_SignIn_Pass_TextChanged" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style63">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label_SignIn_Error" runat="server" CssClass="auto-style61"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style63">&nbsp;</td>
                        <td>
                    <asp:Button ID="butt_SignIn" runat="server" BackColor="#006699" BorderStyle="None" BorderWidth="0px" CssClass="auto-style66" Font-Names="Times New Roman" ForeColor="White" Height="26px" Text="авторизация" Width="101px" OnClick="butt_SignIn_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style48">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
</asp:Content>
