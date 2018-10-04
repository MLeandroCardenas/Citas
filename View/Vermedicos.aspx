<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterAdministrador.master" AutoEventWireup="true" CodeFile="~/Controller/Vermedicos.aspx.cs" Inherits="View_Vermedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style10 {
        width: 324px;
    }
    .auto-style11 {
        width: 525px;
    }
    .auto-style12 {
        width: 525px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style12">MEDICOS REGISTRADOS</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_medicos" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" Visible="False" />
                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="identificacion" HeaderText="Identificacion" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="clave" HeaderText="Clave" />
                    <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
                    <asp:TemplateField HeaderText="Foto">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("url") %>' />
                        </ItemTemplate>
                        <ControlStyle Height="150px" />
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ODS_medicos" runat="server" SelectMethod="obtenermedicos" TypeName="DAO_Admin" DeleteMethod="eliminarMedico">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

