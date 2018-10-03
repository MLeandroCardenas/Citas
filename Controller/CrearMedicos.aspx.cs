﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CrearMedicos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_CrearEspecialidad_Click(object sender, EventArgs e)
    {
        string espe;
        string sesion;
        DAO_Admin especialidad = new DAO_Admin();

        espe = TB_CrearEspecialidad.Text.ToString();
        sesion = Session.SessionID;
        especialidad.CrearEspecialidad(espe,sesion);
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('ESPECILIDAD REGISTRADA');", true);
        TB_CrearEspecialidad.Text = "";
    }

    protected void B_RegistrarMedico_Click(object sender, EventArgs e)
    {
        E_DatosUser user = new E_DatosUser();
        DAO_Admin medico = new DAO_Admin();

        user.Apellidos = TB_Apellidos.Text.ToString();
        user.Nombres = TB_Nombres.Text.ToString();
        user.Numid = int.Parse(TB_identificacion.Text.ToString());
        user.Email = TB_email.Text.ToString();
        user.Clave = TB_Clave.Text.ToString();
        user.Especializacion1 = DDL_Especialidad.SelectedItem.ToString();
        user.Rol = 2;
        user.Session = Session.SessionID;
        user.Estado = 1;

        medico.CrearMedico(user);
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('MEDICO REGISTRADO');", true);

        TB_Apellidos.Text = "";
        TB_Nombres.Text = "";
        TB_identificacion.Text = "";
        TB_email.Text = "";
        TB_Clave.Text = "";
    }
}