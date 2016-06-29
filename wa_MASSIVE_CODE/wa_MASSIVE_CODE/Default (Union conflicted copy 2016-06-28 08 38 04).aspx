<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wa_MASSIVE_CODE.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style23 {
            height: 174px;
        }
        .auto-style24 {
            width: 311px;
            text-align: center;
        }
        .auto-style25 {
            height: 174px;
            width: 311px;
            text-align: left;
        }
        .auto-style26 {
            color: #FFFFFF;
        }
        .auto-style30 {
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style24">
                    <div style="border-style: none; border-color: #006666; background-color: #669999;">
                        <asp:Label ID="Label_mini_code_description" runat="server" CssClass="auto-style26" Text="Mini code description"></asp:Label>
                    </div>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <div style="border: 1px solid #006699; height: 100%; margin-top: 0px; background-color: #FFFFFF;">
                        <asp:Label ID="Label_mini_code" runat="server" CssClass="auto-style30" Text="Mini code"></asp:Label>
                    </div>
                </td>
                <td class="auto-style23"></td>
            </tr>
            <tr>
                <td class="auto-style24">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
