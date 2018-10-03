<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterLogin.master" AutoEventWireup="true" CodeFile="~/Controller/Registro.aspx.cs" Inherits="View_Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style17 {
            text-align: right;
            width: 463px;
            height: 23px;
        }
        .auto-style18 {
            width: 533px;
            height: 23px;
        }
        .auto-style19 {
            height: 23px;
        }
        .auto-style20 {
            color: #FF0000;
        }
        .auto-style21 {
            text-align: center;
            width: 533px;
        }
        .auto-style22 {
            width: 533px;
        }
        .auto-style23 {
            width: 463px;
        }
        .auto-style24 {
            text-align: right;
            width: 463px;
        }
        .auto-style25 {
            text-align: center;
            width: 533px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_Resgistro" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style23">
                    <br />
                    Campos obligatorios <span class="auto-style20">*</span></td>
                <td class="auto-style21">
                    <h3>REGISTRESE</h3>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="L_apellidos" runat="server" Text="Apellidos"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:TextBox ID="TB_Apellidos" runat="server" Width="234px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Apellidos" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Apellidos" ErrorMessage="APELLIDOS VALIDOS" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="L_Nombres" runat="server" Text="Nombres"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:TextBox ID="TB_nombres" runat="server" Width="234px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_nombres" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_nombres" ErrorMessage="NOMBRES VALIDOS" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="L_Id" runat="server" Text="Numero de identificacion"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:TextBox ID="TB_Identificacion" runat="server" Width="234px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_Identificacion" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_Identificacion" ErrorMessage="FUERA DE RANGO" ForeColor="Red" MaximumValue="1179999999" MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="L_Email" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="TB_Email" runat="server" TextMode="Email" Width="234px"></asp:TextBox>
                    &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TB_Email" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style19"></td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="L_Clave0" runat="server" Text="Clave"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:TextBox ID="TB_Clave" runat="server" TextMode="Password" Width="234px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_Clave" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="L_Foto" runat="server" Text="Foto"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:FileUpload ID="FU_FotoUsuario" runat="server" Width="241px" />
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_Clave" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style22">
                    <asp:Button ID="B_Registrarse0" runat="server" OnClick="B_Registrarse_Click" Text="REGISTRARSE" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </asp:Panel>
</asp:Content>

