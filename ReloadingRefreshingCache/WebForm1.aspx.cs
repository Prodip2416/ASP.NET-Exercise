using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReloadingRefreshingCache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadCountriesAndCache_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/Data/Countries.xml"));

            CacheItemRemovedCallback onCacheItemRemoved = new CacheItemRemovedCallback(CacheItemRemovedCallbackMethod);
            Cache.Insert("CountriesData", ds, new CacheDependency(Server.MapPath("~/Data/Countries.xml")), DateTime.Now.AddSeconds(60),
                System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, onCacheItemRemoved);
            gvCountries.DataSource = ds;
            gvCountries.DataBind();
            lblMessage.Text = ds.Tables[0].Rows.Count.ToString() + " rows retrieved from XML file.";
        }
        public void CacheItemRemovedCallbackMethod(string key, object value, CacheItemRemovedReason reason)
        {
            
            string dataToStore = "Cache item with key = \"" + key + "\" is no longer present. Reason = " + reason.ToString();
            // Cache the message
            Cache["CacheStatus"] = dataToStore;

            // ADO.NET code to store the message in database
            // string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            // SqlConnection con = new SqlConnection(cs);
            // SqlCommand cmd = new SqlCommand("insert into tblAuditLog values('" + dataToStore + "')", con);
            // con.Open();
            // cmd.ExecuteNonQuery();
            // con.Close();

            // Reload data into cache
            // DataSet ds = new DataSet();
            // ds.ReadXml(Server.MapPath("~/Data/Countries.xml"));

            // CacheItemRemovedCallback onCacheItemRemoved = new CacheItemRemovedCallback(CacheItemRemovedCallbackMethod);
            // Cache.Insert("CountriesData", ds, new CacheDependency(Server.MapPath("~/Data/Countries.xml")), DateTime.Now.AddSeconds(60),
            //    System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, onCacheItemRemoved);
        }

        protected void btnGetCountriesFromCache_Click(object sender, EventArgs e)
        {
            if (Cache["CountriesData"] != null)
            {
                DataSet ds = (DataSet)Cache["CountriesData"];    
                gvCountries.DataSource = ds;
                gvCountries.DataBind();
                lblMessage.Text = ds.Tables[0].Rows.Count.ToString() + " rows retrieved from cache.";
            }
            else
            {
                lblMessage.Text = "Cache item with key CountriesData is not present in cache";
            }
        }

        protected void btnRemoveCachedItem_Click(object sender, EventArgs e)
        {
            // Remove cached item explicitly
            Cache.Remove("CountriesData");
        }

        protected void btnGetCacheStatus_Click(object sender, EventArgs e)
        {
            if (Cache["CountriesData"] != null)
            {
                lblMessage.Text = "Cache item with key \"CountriesData\" is still present in cache";
            }
            else
            {
                if (Cache["CacheStatus"] != null)
                {
                    lblMessage.Text = Cache["CacheStatus"].ToString();
                }
            }
        }
    }
}