<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wf_UnionClientDownload.aspx.cs" Inherits="wa_MASSIVE_CODE.wf_UnionClientDownload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style16 {
        width: 634px;
    }
    .auto-style18 {
        width: 634px;
        height: 46px;
    }
    .auto-style17 {
        height: 46px;
            width: 126px;
        }
        .button_mouse_out1_1 {
          
        background-color: #006666;
            color: white;
        }  
        
        .button_mouse_over1_1 {
          cursor: pointer;
        background-color: white;
            color: #006666;
            border-color: #006666;
            
        }  
        .auto-style25 {
            width: 136px;
            height: 46px;
        }
        .auto-style26 {
            width: 136px;
        }
        .auto-style28 {
            width: 311px;
            height: 46px;
        }
        .auto-style29 {
            width: 311px;
        }
        .auto-style38 {
        height: 23px;
        width: 138px;
    }
    .auto-style39 {
        width: 230px;
        height: 23px;
    }
    .auto-style43 {
        height: 29px;
    }
    .auto-style44 {
        height: 28px;
        text-align: justify;
    }
    .auto-style46 {
        height: 28px;
        text-align: justify;
        width: 13px;
    }
    .auto-style50 {
        height: 29px;
        text-align: center;
        color: #006699;
        font-size: large;
    }
    .auto-style51 {
        height: 28px;
        text-align: left;
        color: #009999;
    }
    .auto-style53 {
        width: 13px;
        height: 33px;
    }
    .auto-style56 {
        width: 13px;
        height: 81px;
    }
    .auto-style57 {
        height: 81px;
    }
    .auto-style58 {
        height: 33px;
    }
    .auto-style59 {
        color: #006699;
    }
    .auto-style60 {
        height: 81px;
        color: #009999;
    }
    .auto-style61 {
        height: 33px;
        color: #009999;
    }
    .auto-style63 {
        width: 13px;
        height: 67px;
    }
    .auto-style64 {
        height: 67px;
        color: #006600;
    }
    .auto-style65 {
        height: 67px;
    }
        .auto-style66 {
            height: 29px;
            width: 13px;
            text-align: left;
        }
        .auto-style67 {
            width: 5281px;
        }
        .auto-style68 {
            width: 5281px;
            height: 46px;
        }
        .auto-style69 {
            width: 10404px;
        }
        .auto-style70 {
            width: 10404px;
            height: 46px;
        }
        .auto-style71 {
            width: 126px;
        }
        .auto-style72 {
            width: 763px;
        }
        .auto-style73 {
            width: 763px;
            height: 46px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="auto-style38" colspan="4"></td>
        <td class="auto-style39" colspan="3" rowspan="1"></td>
    </tr>
    <tr>
        <td class="auto-style69"></td>
        <td class="auto-style26">
            <a target="_blank" href="images/client/Cl_1.PNG">
            <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/images/client/Cl_1.PNG" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" Width="170px" />
                </a>
        </td>
        <td class="auto-style29">
            <a target="_blank" href="images/client/Cl_3.PNG">
            <asp:Image ID="Image2" runat="server" Height="300px" ImageUrl="~/images/client/Cl_3.PNG" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" Width="220px" />
            </a>
        </td>
        <td class="auto-style67">
            <a target="_blank" href="images/client/Cl_4.PNG">
            <asp:Image ID="Image3" runat="server" Height="230px" ImageUrl="~/images/client/Cl_4.PNG" Width="250px" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" />
                </a>
        </td>
        <td class="auto-style16">
            <asp:Panel ID="Panel1" runat="server">
                <table style="width: 100%; height: 323px;">
                    <tr>
                        <td class="auto-style66">&nbsp;</td>
                        <td class="auto-style50">
                            <asp:Button ID="Button_Download_UnionClient" runat="server" BorderStyle="Solid" CssClass="button_mouse_out1_1" Font-Names="Times New Roman" Height="42px" OnClick="Button_Download_UnionClient_Click" style="font-size: large; text-align: center;" Text="DOWNLOAD" Width="244px" />
                        </td>
                        <td class="auto-style43">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style66"></td>
                        <td class="auto-style50">UNION CLIENT</td>
                        <td class="auto-style43"></td>
                    </tr>
                    <tr>
                        <td class="auto-style46"></td>
                        <td class="auto-style51">Часть клиент-серверной системы корпоративного общения между сотрудниками</td>
                        <td class="auto-style44"></td>
                    </tr>
                    <tr>
                        <td class="auto-style53"></td>
                        <td class="auto-style61">Воспользуйтесь бесплатной версией программы с частично открытым исходным кодом. </td>
                        <td class="auto-style58"></td>
                    </tr>
                    <tr>
                        <td class="auto-style56"></td>
                        <td class="auto-style60">Пройдите вместе со мной все этапы разработки программного продукта. Вместе мы рассмотрим каким образом работают системы социального общения от баз данных до работы в сети.</td>
                        <td class="auto-style57"></td>
                    </tr>
                    <tr>
                        <td class="auto-style63"></td>
                        <td class="auto-style64"><span class="auto-style59"><strong>Системные требования: Windows 7 и выше</strong></span><strong><br class="auto-style59" /> </strong><span class="auto-style59"><strong>NET Framework 4.0 </strong></span><strong>
                            <br class="auto-style59" />
                            </strong><span class="auto-style59"><strong>Подключение к локальной сети либо к сети Интернет</strong></span></td>
                        <td class="auto-style65"></td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td class="auto-style72"></td>
        <td class="auto-style71">
            </td>
    </tr>
    <tr>
        <td class="auto-style70">&nbsp;</td>
        <td class="auto-style25">
            &nbsp;</td>
        <td class="auto-style28">
            &nbsp;</td>
        <td class="auto-style68">
            &nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style73">&nbsp;</td>
        <td class="auto-style17">
            &nbsp;</td>
    </tr>
    </table>
<br />
</asp:Content>
