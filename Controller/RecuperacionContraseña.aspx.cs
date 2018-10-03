using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RecuperacionContraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_enviar_Click(object sender, EventArgs e)
    {
        DAO_Usuarios dao = new DAO_Usuarios();
        System.Data.DataTable validez = dao.generarToken(int.Parse(TB_Recuperacion.Text));

        if (int.Parse(validez.Rows[0]["id"].ToString()) > 0)
        {
            EUserToken token = new EUserToken();
            token.Id = int.Parse(validez.Rows[0]["id"].ToString());
            token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());
            token.Correo = validez.Rows[0]["email"].ToString();
            token.Fecha = DateTime.Now.ToFileTimeUtc();

            String userToken = encriptar(JsonConvert.SerializeObject(token));
            dao.almacenarToken(userToken, token.Id);

            correo correo = new correo();

            String mensaje = "su link de acceso es: " + "http://localhost:51068/View/RecuperarContraseña2.aspx?" + userToken;
            

            correo.enviarCorreo(token.Correo, userToken, mensaje);

            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Su nueva contraseña ha sido enviada por correo');", true);
            TB_Recuperacion.Text = "";
        }
        else if (int.Parse(validez.Rows[0]["id"].ToString()) == -2)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Ya existe un token por favor verifique su correo');", true);
            TB_Recuperacion.Text = "";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('El usuario digitado no existe');", true);
            TB_Recuperacion.Text = "";
        }

        //Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('SE HA ENVIADO UN ENLACE A SU EMAIL');", true);
        //TB_Recuperacion.Text = "";
    }

    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }
}