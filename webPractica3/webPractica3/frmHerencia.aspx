<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="webPractica3.frmHerencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Práctica #3 - Herencia y Polimorfismo</title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            border-left-style: solid;
            border-left-width: 2px;
            border-right: 2px solid #C0C0C0;
            border-top-style: solid;
            border-top-width: 2px;
            border-bottom: 2px solid #C0C0C0;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            width: 80%;
            border: 3px solid #000000;
        }
        .auto-style4 {
            font-size: medium;
            height: 26px;
            font-family: Arial, Helvetica, sans-serif;
            text-align: right;
        }
        .auto-style5 {
            height: 26px;
            width: 390px;
            text-align: left;
        }
        .auto-style6 {
            width: 35%;
            height: 22px;
            text-align: right;
        }
        .auto-style7 {
            height: 22px;
            text-align: left;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            text-align: right;
            height: 22px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style12 {
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style13 {
            font-size: medium;
        }
        .auto-style14 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style16 {
            width: 80%;
            border: 2px solid #000000;
        }
        .auto-style17 {
            width: 35%;
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
        }
        .auto-style19 {
            font-size: medium;
            font-weight: bold;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style20 {
            height: 23px;
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style21 {
            height: 23px;
            text-align: right;
        }
        .auto-style22 {
            width: 390px;
            text-align: left;
        }
        .auto-style23 {
            text-align: left;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="4" class="auto-style1" style="border-width: 2px">
                <tr>
                    <td class="auto-style2" style="text-align: center"><strong style="font-family: Arial, Helvetica, sans-serif">Cálculos Figuras Geométricas 3D</strong></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center"><strong>
                        <asp:RadioButtonList ID="rblFiguras" runat="server" CssClass="auto-style14" RepeatDirection="Horizontal" RepeatLayout="Flow" style="text-align: center" AutoPostBack="True" OnSelectedIndexChanged="rblFiguras_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="opcEsf">Esfera</asp:ListItem>
                            <asp:ListItem Value="opcCil">Cilindro</asp:ListItem>
                            <asp:ListItem Value="opcPar">Paralelepípedo</asp:ListItem>
                        </asp:RadioButtonList>
                        </strong></td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Image ID="imgFigura" runat="server" Height="150px" Width="150px" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="lblMsj" runat="server" Font-Bold="True" ForeColor="Red" Width="90%"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Panel ID="pnlEsfera" runat="server">
                            <table align="center" class="auto-style3" aria-checked="undefined" aria-disabled="False" border="0" style="background-color: #fffaa3; border-width: 2px">
                                <tr>
                                    <td style="width: 35%">&nbsp;</td>
                                    <td class="auto-style22">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4"><strong style="text-align: left">Radio:</strong></td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="txtRadioEsf" runat="server" style="text-align: left" Width="188px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td class="auto-style22">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlCilindro" runat="server" Visible="False">
                            <table align="center" class="auto-style3" style="border-width: 2px; background-color: #fffaa3">
                                <tr>
                                    <td class="auto-style6"></td>
                                    <td class="auto-style7"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style4"><strong><span class="auto-style13">Radio:</span></strong></td>
                                    <td class="auto-style23">
                                        <asp:TextBox ID="txtRadioCil" runat="server" Width="185px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style10"><strong>Altura:</strong></td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtAltura" runat="server" Width="185px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style12">&nbsp;</td>
                                    <td class="auto-style9">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlParalele" runat="server" Visible="False">
                            <div class="auto-style15">
                                <table align="center" class="auto-style16" style="background-color: #fffaa3; border-width: 2px">
                                    <tr>
                                        <td class="auto-style17"></td>
                                        <td class="auto-style18"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4"><strong>Lado A:</strong></td>
                                        <td class="auto-style23">
                                            <asp:TextBox ID="txtLadoA" runat="server" Width="185px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style12"><strong>Lado B:</strong></td>
                                        <td class="auto-style9">
                                            <asp:TextBox ID="txtLadoB" runat="server" Width="184px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4"><strong>Lado C:</strong></td>
                                        <td class="auto-style23">
                                            <asp:TextBox ID="txtLadoC" runat="server" Width="185px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15"><strong>
                        <asp:Button ID="btnCalcular" runat="server" CssClass="auto-style19" Text="Calcular" OnClick="btnCalcular_Click" />
                        </strong></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Panel ID="pnlRpta" runat="server" Visible="False">
                            <table align="center" class="auto-style3" style="border-width: 2px">
                                <tr>
                                    <td class="auto-style20" style="width: 35%"><strong>Área:</strong></td>
                                    <td class="auto-style21">
                                        <asp:Label ID="lblArea" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style20"><strong>Volumen:</strong></td>
                                    <td class="auto-style21">
                                        <asp:Label ID="lblVolumen" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2"><strong>
                                        <asp:Button ID="btnLimpiar" runat="server" CssClass="auto-style19" Text="Limpiar" OnClick="btnLimpiar_Click" />
                                        </strong></td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
