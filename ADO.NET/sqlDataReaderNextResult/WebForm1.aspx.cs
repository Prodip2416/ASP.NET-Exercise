using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sqlDataReaderNextResult
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand("select * from tblProduct; Select * from tblEmployee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();
            while (rdr.NextResult())
            {
                GridView2.DataSource = rdr;
                GridView2.DataBind();
            }
           
            con.Close();
        }
    }
}