<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterLogin.master" AutoEventWireup="true" CodeFile="~/Controller/RecuperarContraseña2.aspx.cs" Inherits="View_RecuperarContraseña2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            text-align: right;
            width: 366px;
        }
        .auto-style9 {
            text-align: center;
            width: 633px;
        }
        .auto-style10 {
            width: 633px;
        }
        .auto-style11 {
            width: 366px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style9">ACTUALIZAR CONTRASEÑA<br />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="L_contraseña" runat="server" Text="Digite su nueva contraseña"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TB_contraseñaUno" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_contraseñaUno" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="L_repetir" runat="server" Text="Repita la contraseña"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TB_repetir" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_repetir" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="B_Guardar" runat="server" Text="Guardar" OnClick="B_Guardar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

