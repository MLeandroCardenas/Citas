using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_PrincipalAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        if (Session["user"] == null)
            Response.Redirect("Login.aspx");
    }


    /*protected void B_subirfoto_Click(object sender, EventArgs e)
    {
        
        string nombreArchivo = System.IO.Path.GetFileName(FU_subirfoto.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_subirfoto.PostedFile.FileName);
        string saveLocation = "~\\Archivos";

        if ((extension.Equals(".jpg")) || (extension.Equals(".gif"))||(extension.Equals(".jpge"))||(extension.Equals(".png")))
        {
            saveLocation = saveLocation + "\\imagenes\\" + nombreArchivo;
            //Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('FOTO CARGADA');", true);
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('FORMATO INVALIDO');", true);
            return;
        }
        if (System.IO.File.Exists(Server.MapPath(saveLocation)))
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('YA EXISTE');", true);
            return;
        }
        try
        {
            FU_subirfoto.PostedFile.SaveAs(Server.MapPath(saveLocation));
            E_Archivo archivo = new E_Archivo();
            archivo.Url = saveLocation;

            DAO_Usuarios foto = new DAO_Usuarios();
            foto.CargarFoto(archivo);
            GV_DatosAdmin.DataBind();
        }
        catch (Exception exc)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('ERROR');", true);
        }
    }*/
}
