using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ReporteMedicos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            infoMedicos medicos = obtenerInforme();
            CRS_medicos.ReportDocument.SetDataSource(medicos);
            CRV_medicos.ReportSource = CRS_medicos;

        }
        catch (Exception)
        {
            throw;
        }
    }

    protected infoMedicos obtenerInforme()
    {
        DataRow fila;
        DataTable informacionMedico = new DataTable();
        infoMedicos medico = new infoMedicos();

        informacionMedico = medico.Tables["medicos"];

        DAO_Admin admin = new DAO_Admin();
        DataTable intermedio = admin.obtenermedicos();

        for(int i=0; i<intermedio.Rows.Count; i++)
        {
            fila = informacionMedico.NewRow();

            fila["apellidos"] = intermedio.Rows[i]["apellidos"].ToString();
            fila["nombres"] = intermedio.Rows[i]["nombres"].ToString();
            fila["identificacion"] = Int64.Parse(intermedio.Rows[i]["identificacion"].ToString());
            fila["email"] = intermedio.Rows[i]["email"].ToString();
            fila["especialidad"] = intermedio.Rows[i]["especialidad"].ToString();
            fila["foto"] =  obtenerImagen(intermedio.Rows[i]["url"].ToString());
            informacionMedico.Rows.Add(fila);
        }

        return medico;
    }

    protected byte[] obtenerImagen(String url)
    {
        string urlImagen = Server.MapPath(url);

        byte[] fileBytes = System.IO.File.ReadAllBytes(urlImagen);

        return fileBytes;
    }
}