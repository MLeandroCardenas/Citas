<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterAdministrador.master" AutoEventWireup="true" CodeFile="~/Controller/ReporteMedicos.aspx.cs" Inherits="View_ReporteMedicos" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
    <tr>
        <td>
            <CR:CrystalReportViewer ID="CRV_medicos" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_medicos" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
            <CR:CrystalReportSource ID="CRS_medicos" runat="server">
                <Report FileName="C:\Users\Toshiba\Desktop\Personal\IngSoftware\IngSoftwre2018-ll\ProyectoCitas\A su salud\A su salud\Reportes\reporteMedico.rpt">
                </Report>
            </CR:CrystalReportSource>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

