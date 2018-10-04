<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterAdministrador.master" AutoEventWireup="true" CodeFile="~/Controller/PrincipalAdmin.aspx.cs"
    Inherits="View_PrincipalAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style6 {
        margin-left: 413px;
    }
    .auto-style7 {
        height: 22px;
    }
        .auto-style9 {
            height: 22px;
            text-align: right;
            width: 704px;
        }
        .auto-style10 {
            text-align: center;
            margin-left: 116px;
        }
        .auto-style13 {
            width: 113px;
        }
        .auto-style16 {
            width: 363px;
        }
        .auto-style17 {
        width: 704px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_DatosAdmin" runat="server">
        <br /><br />
        <h3 class="auto-style1">MI PERFIL</h3>
        <table class="auto-style2">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <table class="auto-style2">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style17">
                    <asp:GridView ID="GV_DatosAdmin" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style10" DataKeyNames="id" ForeColor="#333333" GridLines="None" AllowSorting="True" DataSourceID="ODS_Perfiles">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="ID" Visible="False" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="identificacion" HeaderText="Identificacion" ReadOnly="True"/>
                            <asp:BoundField DataField="email" HeaderText="Email" />
                            <asp:BoundField DataField="clave" HeaderText="Clave" />
                            <asp:TemplateField HeaderText="Foto">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("foto") %>' ReadOnly="true"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl='<%# Eval("url") %>'/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ODS_Perfiles" runat="server" DataObjectTypeName="E_DatosUser" SelectMethod="obtenerUsuarios" TypeName="DAO_Usuarios" UpdateMethod="editarperfil">
                        <SelectParameters>
                            <asp:SessionParameter Name="userid" SessionField="id" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style7"></td>
            </tr>
        </table>
        <br />

    </asp:Panel>
</asp:Content>

