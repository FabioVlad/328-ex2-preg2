using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
        this.GridView1.DataSource = ws.alumno().Tables[0];
        this.GridView1.DataBind();
    }
}