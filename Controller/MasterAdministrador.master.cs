using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_MasterAdministrador : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void B_CerrarSesion_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Session["identificacion"] = null;
        Session["id"] = null;


        DAO_Usuarios user = new DAO_Usuarios();
        E_usuario datos = new E_usuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);

        Response.Redirect("Login.aspx");
    }
}
