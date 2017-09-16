using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PassingDataMasterPageToContentPages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData(null);
            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Master.SearchButton.Click += new EventHandler(SearchButton_Click);
        }
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            GetData(Master.SearchTerm);
        }
        private void GetData(string searchTerm)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGETSearch", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter searchParameter = new SqlParameter("@SearchTerm", searchTerm ?? string.Empty);
                cmd.Parameters.Add(searchParameter);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}