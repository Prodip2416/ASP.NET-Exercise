using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdoDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  
            SqlConnection con = new SqlConnection("data source = AUSHOMAPTO\\SQLEXPRESS; database = ADO; integrated security = SSPI");
            SqlCommand cmd= new SqlCommand("Select * from tblCity", con);

            con.Open();
            SqlDataReader rdr= cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
    }
}