using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RecuperarContraseña2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Request.QueryString.Count > 0)
        {
            DAO_Usuarios user = new DAO_Usuarios();
            DataTable info = user.obtenerUsusarioToken(Request.QueryString[0]);

            if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"login.aspx\"</script>");
            else if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"login.aspx\"</script>");
            else
                Session["user_id"] = int.Parse(info.Rows[0][0].ToString());
        }
        else
            Response.Redirect("login.aspx");
    }

    protected void B_Guardar_Click(object sender, EventArgs e)
    {
        DAO_Usuarios user = new DAO_Usuarios();
        E_usuario eUser = new E_usuario();

        eUser.UserId = int.Parse(Session["user_id"].ToString());
        eUser.Clave = TB_contraseñaUno.Text;

        user.actualizarContrasena(eUser);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su Contraseña ha sido actualizada.');window.location=\"login.aspx\"</script>");
    }
}