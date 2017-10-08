using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSetExercise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("spGetproductEmployee", con);
            da.SelectCommand.CommandType=CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            GridView2.DataSource = ds.Tables[1];
            GridView2.DataBind();
        }
    }
}