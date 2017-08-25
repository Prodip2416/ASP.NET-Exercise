using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CacheDependancyOnSQLServer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            if (Cache["ProductsData"] != null)
            {
                gvProducts.DataSource = Cache["ProductsData"];
                gvProducts.DataBind();

                lblStatus.Text = "Data retrieved from cache @ " + DateTime.Now.ToString();
            }
            else
            {
                // Read connection string from web.config file
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                System.Web.Caching.SqlCacheDependencyAdmin.EnableNotifications(CS);
                System.Web.Caching.SqlCacheDependencyAdmin.EnableTableForNotifications(CS, "Products");

                SqlConnection con = new SqlConnection(CS);
                SqlDataAdapter da = new SqlDataAdapter("select * from Products", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                SqlCacheDependency sqlDependency = new SqlCacheDependency("Sample", "Products");

                Cache.Insert("ProductsData", ds, sqlDependency);

                gvProducts.DataSource = ds;
                gvProducts.DataBind();
                lblStatus.Text = "Data retrieved from database @ " + DateTime.Now.ToString();
            }
        }
    }
}