<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterLogin.master" AutoEventWireup="true" CodeFile="~/Controller/login.aspx.cs" Inherits="View_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            width: 388px;
        }
        .auto-style11 {
            text-align: right;
            width: 572px;
        }
        .auto-style12 {
            width: 572px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_Login" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style8">
                <br />
                <h4 class="auto-style9">INICIAR SESION</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Campos obligatorios <span class="auto-style15">*</span></td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_documento" runat="server" Text="Numero de documento"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_documento" runat="server" Width="158px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_documento" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_documento" ErrorMessage="FUERA DE RANGO" ForeColor="Red" MaximumValue="1179999999" MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
            </td>
            <td class="auto-style14"></td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_Contraseña" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="TB_Contraseña" runat="server" TextMode="Password" Width="158px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_Contraseña" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="B_Ingresar" runat="server" Text="INGRESAR" OnClick="B_Ingresar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">
                <asp:LinkButton ID="LinkB_Registrarse" runat="server" CausesValidation="False" OnClick="LinkB_Registrarse_Click">REGISTRARSE</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">
                <asp:LinkButton ID="LinkB_olividecontraseña" runat="server" CausesValidation="False" OnClick="LinkB_olividecontraseña_Click">¿OLVIDE MI CONTRASEÑA?</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
  </asp:Panel>
</asp:Content>

