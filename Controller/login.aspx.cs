using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void LinkB_Registrarse_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }

    protected void LinkB_olividecontraseña_Click(object sender, EventArgs e)
    {
        Response.Redirect("RecuperacionContraseña.aspx");
    }

    protected void B_Ingresar_Click(object sender, EventArgs e)
    {
        E_DatosUser usuario = new E_DatosUser();
        DAO_Usuarios datos = new DAO_Usuarios();

        usuario.Numid = Int64.Parse(TB_documento.Text.ToString());
        usuario.Clave = TB_Contraseña.Text.ToString();

        DataTable registro = datos.loggin(usuario);

        if (registro.Rows.Count > 0)
        {
          //  Session["identificacion"] = registro.Rows[0]["identificacion"].ToString();
            Session["id"] = registro.Rows[0]["id"].ToString();

            E_usuario datosUsuario = new E_usuario();
            MAC datosConexion = new MAC();

            datosUsuario.UserId = int.Parse(Session["id"].ToString());
            datosUsuario.Ip = datosConexion.ip();
            datosUsuario.Mac = datosConexion.mac();
            datosUsuario.Session = Session.SessionID;
            datosUsuario.RolId = int.Parse(registro.Rows[0]["id_rol"].ToString());
            Session["user"] = datosUsuario;
            datos.guardadoSession(datosUsuario);

            switch (int.Parse(registro.Rows[0]["id_rol"].ToString()))
            {
                
                case 1:
                    Response.Redirect("PrincipalAdmin.aspx");
                    break;
                case 2:
                    
                    break;
                case 3:
                   
                    break;
                default:
                    Response.Redirect("login.aspx");
                    break;
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('NO SON CORRECTOS');", true);
            Session["user"] = null;
        }

        
    }
}
