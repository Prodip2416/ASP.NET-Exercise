using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingApplicationData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetProductsData()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("spProductName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet dsProducts = new DataSet();
            da.Fill(dsProducts);

            return dsProducts;
        }
        protected void btnGetProducts_Click(object sender, EventArgs e)
        {
            DateTime dtStartDateTime = DateTime.Now;
            System.Text.StringBuilder sbMessage = new System.Text.StringBuilder();
            // Check if the data is already cached
            if (Cache["ProductsData"] != null)
            {
                // If data is cached, retrieve data from Cache using the key "ProductsData"
                DataSet ds = (DataSet)Cache["ProductsData"];
                // Set the dataset as the datasource
                gvProducts.DataSource = ds;
                gvProducts.DataBind();
                // Retrieve the total rows count
                sbMessage.Append(ds.Tables[0].Rows.Count.ToString() + " rows retrieved from cache.");
            }
            // If the data is not cached
            else
            {
                // Get the data from the database
                DataSet ds = GetProductsData();
                // Cache the dataset using the key "ProductsData"
                Cache["ProductsData"] = ds;
                // Set the dataset as the datasource
                gvProducts.DataSource = ds;
                gvProducts.DataBind();
                sbMessage.Append(ds.Tables[0].Rows.Count.ToString() + " rows retrieved from database.");
            }
            DateTime dtEndDateTime = DateTime.Now;
            sbMessage.Append((dtEndDateTime - dtStartDateTime).Seconds.ToString() + " Seconds Load Time");
            lblMessage.Text = sbMessage.ToString();
        }

    }
}