using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public int Suma(int a, int b)
    {
        return a+b; 
    }

    public int Resta(int a, int b)
    {
        return a - b;
    }

    [WebMethod]
    public DataSet alumno()
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        con.ConnectionString = "server=(local);user=sa;pwd=123;database=academico";
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.CommandText = "select * from alumno";
        ada.SelectCommand.CommandType = CommandType.Text;
        ada.SelectCommand.Connection = con;
        DataSet ds = new DataSet();
        ada.Fill(ds);
        return ds;
    }


}
