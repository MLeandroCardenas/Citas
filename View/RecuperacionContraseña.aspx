<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterLogin.master" AutoEventWireup="true" CodeFile="~/Controller/RecuperacionContraseña.aspx.cs" Inherits="View_RecuperacionContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            text-align: right;
            width: 460px;
        }
        .auto-style9 {
            width: 460px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_Recuperacion" runat="server">
        <h2 class="auto-style2">RECUPERACION DE CONTRASEÑA</h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="L_Correo" runat="server" Text="Digite su numero de identificacion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TB_Recuperacion" runat="server" Width="235px"></asp:TextBox>
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Recuperacion" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_Recuperacion" ErrorMessage="FUERA DE RANGO" ForeColor="Red" MaximumValue="1179999999" MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td>
                    <br />
                    <asp:Button ID="B_enviar" runat="server" OnClick="B_enviar_Click" Text="ENVIAR" />
                    &nbsp;</td>
            </tr>
        </table>
        <br />

    </asp:Panel>
</asp:Content>

