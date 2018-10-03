<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterAdministrador.master" AutoEventWireup="true" CodeFile="~/Controller/CrearMedicos.aspx.cs" Inherits="View_CrearMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            text-align: center;
            width: 481px;
        }
        .auto-style8 {
            width: 481px;
        }
    .auto-style9 {
        height: 53px;
    }
    .auto-style10 {
        text-align: center;
        width: 481px;
        height: 53px;
    }
    .auto-style11 {
        text-align: right;
        width: 380px;
    }
    .auto-style12 {
        height: 53px;
        width: 380px;
    }
    .auto-style13 {
        text-align: right;
        width: 380px;
        height: 30px;
    }
    .auto-style14 {
        width: 481px;
        height: 30px;
    }
    .auto-style16 {
        color: #FF0000;
    }
    .auto-style17 {
        width: 481px;
        text-align: center;
    }
    .auto-style18 {
        width: 137px;
    }
    .auto-style19 {
        width: 137px;
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style12">Campos obligatorios <span class="auto-style16">*</span></td>
            <td class="auto-style10">
                <br />
                REGISTRAR MEDICOS</td>
            <td class="auto-style9">REGISTRAR ESPECIALIDADES</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_apellidos" runat="server" Text="Apellidos"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_Apellidos" runat="server" Width="228px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RFV_apel" runat="server" ControlToValidate="TB_Apellidos" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="form1"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Apellidos" ErrorMessage="APELLIDOS VALIDOS" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
                </td>
            <td rowspan="9">
                <asp:Panel ID="P_especialidade" runat="server">
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style18">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style18">
                                <asp:Label ID="Label1" runat="server" Text="Nombre especialidad"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TB_CrearEspecialidad" runat="server" Width="165px"></asp:TextBox>
                                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_CrearEspecialidad" ErrorMessage="ESPECIALIDAD VALIDA" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="especialidad"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style18">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style19">&nbsp;</td>
                            <td>
                                <asp:Button ID="B_CrearEspecialidad" runat="server" Text="Crear" ValidationGroup="especialidad" OnClick="B_CrearEspecialidad_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="L_nombres" runat="server" Text="Nombres"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:TextBox ID="TB_Nombres" runat="server" Width="228px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TB_Nombres" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="form1"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TB_Apellidos" ErrorMessage="NOMBRES VALIDOS" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_email" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_email" runat="server" TextMode="Email" Width="228px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TB_email" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="form1"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_clave" runat="server" Text="Clave"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_Clave" runat="server" TextMode="Password" Width="228px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TB_Clave" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="form1"></asp:RequiredFieldValidator>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_identificacion" runat="server" Text="Identificacion"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_identificacion" runat="server" Width="228px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TB_identificacion" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="form1"></asp:RequiredFieldValidator>
                &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TB_identificacion" ErrorMessage="FUERA DE RANGO" ForeColor="Red" MaximumValue="1179999999" MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style8">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_especialidad" runat="server" Text="Especialidad"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="DDL_Especialidad" runat="server" Height="39px" Width="166px" DataSourceID="ObjectDataSource1" DataValueField="nombre">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="obtenerespecialidad" TypeName="DAO_Admin"></asp:ObjectDataSource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style8">
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style17">
                <asp:Button ID="B_RegistrarMedico" runat="server" Text="Registrar" ValidationGroup="form1" OnClick="B_RegistrarMedico_Click" />
            &nbsp;</td>
        </tr>
    </table>
</asp:Content>

