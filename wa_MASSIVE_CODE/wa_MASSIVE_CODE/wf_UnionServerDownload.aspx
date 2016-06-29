<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wf_UnionServerDownload.aspx.cs" Inherits="wa_MASSIVE_CODE.wf_UnionServerDownload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style  type="text/css">
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
        .auto-style38 {
        height: 55px;
        width: 138px;
    }
    .auto-style39 {
        width: 230px;
        height: 55px;
    }
    .auto-style40 {
        width: 311px;
        height: 55px;
    }
    .auto-style41 {
        width: 249px;
        height: 55px;
    }
    .auto-style42 {
        width: 634px;
        height: 55px;
    }
        .auto-style23 {
            width: 138px;
            height: 348px;
        }
        .auto-style26 {
            width: 230px;
            height: 348px;
        }
        .auto-style29 {
            width: 311px;
            height: 348px;
        }
        .auto-style37 {
            width: 249px;
            height: 348px;
        }
    .auto-style16 {
            width: 634px;
            height: 348px;
        }
    .auto-style45 {
        height: 29px;
        width: 10px;
        text-align: left;
    }
    .auto-style50 {
        height: 29px;
        text-align: center;
        color: #006699;
        font-size: large;
    }
    .auto-style43 {
        height: 29px;
    }
    .auto-style46 {
        height: 28px;
        text-align: justify;
        width: 10px;
    }
    .auto-style51 {
        height: 28px;
        text-align: left;
        color: #009999;
    }
    .auto-style44 {
        height: 28px;
        text-align: justify;
    }
    .auto-style53 {
        width: 10px;
        height: 33px;
    }
    .auto-style61 {
        height: 33px;
        color: #009999;
    }
    .auto-style58 {
        height: 33px;
    }
    .auto-style56 {
        width: 10px;
        height: 81px;
    }
    .auto-style60 {
        height: 81px;
        color: #009999;
    }
    .auto-style57 {
        height: 81px;
    }
    .auto-style63 {
        width: 10px;
        height: 67px;
    }
    .auto-style64 {
        height: 67px;
        color: #006600;
    }
    .auto-style59 {
        color: #006699;
    }
    .auto-style65 {
        height: 67px;
    }
    .auto-style20 {
        height: 46px;
        width: 138px;
    }
        .auto-style25 {
            width: 230px;
            height: 46px;
        }
        .auto-style28 {
            width: 311px;
            height: 46px;
        }
        .auto-style36 {
            width: 249px;
            height: 46px;
        }
        .auto-style18 {
        width: 634px;
        height: 46px;
    }
    .auto-style17 {
        height: 46px;
    }
        .auto-style66 {
            height: 348px;
        }
        .auto-style67 {
            height: 45px;
            width: 138px;
        }
        .auto-style68 {
            width: 230px;
            height: 45px;
        }
        .auto-style69 {
            width: 311px;
            height: 45px;
        }
        .auto-style70 {
            width: 249px;
            height: 45px;
        }
        .auto-style71 {
            width: 634px;
            height: 45px;
        }
        .auto-style72 {
            height: 45px;
        }
        .auto-style73 {
        width: 100%;
        height: 55px;
    }
        .auto-style74 {
        width: 100%;
        margin-right: 0px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style74">
        <tr>
            <td class="auto-style38" colspan="3"></td>
            <td class="auto-style39" rowspan="1"></td>
        </tr>
        <tr>
            <td class="auto-style26"><a target="_blank" href="images/server/Se_1.PNG">
                <asp:Image ID="Image1" runat="server" Height="230px" ImageUrl="~/images/server/Se_1.PNG" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" Width="300px" />
                </a></td>
            <td class="auto-style29"><a target="_blank" href="images/server/Se_2.PNG">
                <asp:Image ID="Image2" runat="server" Height="230px" ImageUrl="~/images/server/Se_2.PNG" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" Width="300px" />
                </a></td>
            <td class="auto-style37"><a target="_blank" href="images/server/Se_3.PNG">
                <asp:Image ID="Image3" runat="server" Height="230px" ImageUrl="~/images/server/Se_3.PNG" Width="300px" BorderColor="#006699" BorderStyle="Solid" BorderWidth="1px" />
                </a></td>
            <td class="auto-style16">
                <asp:Panel ID="Panel1" runat="server">
                    <table style="width: 100%; height: 323px;">
                        <tr>
                            <td class="auto-style45">&nbsp;</td>
                            <td class="auto-style50">
                                <asp:Button ID="Button_Download_UnionServer" runat="server" BorderStyle="Solid" CssClass="button_mouse_out1_1" Font-Names="Times New Roman" Height="42px" OnClick="Button_Download_UnionServer_Click" style="font-size: large; text-align: center;" Text="DOWNLOAD" Width="244px" />
                            </td>
                            <td class="auto-style43">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style45"></td>
                            <td class="auto-style50">UNION SERVER</td>
                            <td class="auto-style43"></td>
                        </tr>
                        <tr>
                            <td class="auto-style46"></td>
                            <td class="auto-style51">Основная часть клиент-серверной системы корпоративного общения между сотрудниками</td>
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
                            <td class="auto-style64"><span class="auto-style59"><strong>Системные требования: Windows 7 Windows 2008 Server и выше</strong></span><strong><br class="auto-style59" /> </strong><span class="auto-style59"><strong>NET Framework 4.5
                                <br />
                                SQL Compact Edition 4.0</strong></span><strong><br class="auto-style59" /> </strong><span class="auto-style59"><strong>Подключение к локальной сети либо к сети Интернет</strong></span></td>
                            <td class="auto-style65"></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style68"></td>
            <td class="auto-style69"></td>
            <td class="auto-style70"></td>
            <td class="auto-style71">
            </td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
