using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CacheDependencyOnFiles
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["CountriesData"] != null)
            {
                DataSet ds = (DataSet) Cache["CountriesData"];
                // Set the dataset as the datasource
                gvCountries.DataSource = ds;
                gvCountries.DataBind();
                // Retrieve the total rows count
                lblMessage.Text = ds.Tables[0].Rows.Count.ToString() + " rows retrieved from cache.";
            }
            else
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Data/Countrys.xml"));
                Cache.Insert("CountriesData", ds, null, DateTime.Now.AddSeconds(20), System.Web.Caching.Cache.NoSlidingExpiration);
                gvCountries.DataSource = ds;
                gvCountries.DataBind();
                lblMessage.Text = ds.Tables[0].Rows.Count.ToString() + " rows retrieved from the file.";
            }
        }
    }
}