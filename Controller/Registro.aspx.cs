using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Registrarse_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        string nombreArchivo = System.IO.Path.GetFileName(FU_FotoUsuario.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_FotoUsuario.PostedFile.FileName);
        string saveLocation = "~\\Archivos";


        if ((extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".jpge") || extension.Equals(".png")))
        {
            saveLocation = saveLocation + "\\imagenes\\" + nombreArchivo;
        }
        else if (extension.Equals(".pdf"))
        {
            saveLocation = saveLocation + "\\Pdf\\" + nombreArchivo;
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El formato del archivo es invalido');</script>");
            return;
        }

        if (System.IO.File.Exists(Server.MapPath(saveLocation)))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }

        try
        {
            FU_FotoUsuario.PostedFile.SaveAs(Server.MapPath(saveLocation));
            E_DatosUser archvio = new E_DatosUser();
            archvio.Foto = nombreArchivo;
            archvio.Url = saveLocation;

            archvio.Nombres = TB_nombres.Text.ToString();
            archvio.Clave = TB_Clave.Text.ToString();
            //archvio.Email = TB_Email.Text.ToString();
            archvio.Email = TB_Email.Text.ToString();
            archvio.Apellidos = TB_Apellidos.Text.ToString();
            archvio.Numid = int.Parse(TB_Identificacion.Text.ToString());
            archvio.Session = Session.SessionID;

            DAO_Usuarios daoArchivo = new DAO_Usuarios();
            daoArchivo.CrearUsuarios(archvio);
            //GridView1.DataBind();
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Registro Exitoso');</script>");

            TB_Apellidos.Text = "";
            TB_nombres.Text = "";
            TB_Identificacion.Text = "";
            TB_Email.Text = "";
            TB_Clave.Text = "";

        }
        catch (Exception exc)
        {
            //funcion javascript
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
        }
    }      
    
}