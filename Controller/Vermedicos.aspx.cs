using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Vermedicos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Reportemedicos_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReporteMedicos.aspx");
    }
}