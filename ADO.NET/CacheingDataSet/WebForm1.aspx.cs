using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CacheingDataSet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection con = new SqlConnection(CS);
                SqlDataAdapter da = new SqlDataAdapter("Select * from tblProduct", con);

                DataSet ds = new DataSet();
                da.Fill(ds);

                Cache["Data"] = ds;

                GridView1.DataSource = ds;
                GridView1.DataBind();
                lblMessage.Text = "Data Loaded from DataBase.";
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["Data"];
                GridView1.DataBind();
                lblMessage.Text = "Data Loaded from Cache.";
            }
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] != null)
            {
                Cache.Remove("Data");
                lblMessage.Text = "Data Remove from the Cache.";
            }
            else
            {
                lblMessage.Text = "There is nothing in the cache.";
            }
        }
    }
}