using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayDataTwoOrMoreTable
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataReaderData();
              //  LoadDataFromDataBase();
            }
        }

        private void LoadDataFromDataBase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("select * from tblRates", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.Tables[0].Columns
               .Add("CurrencyAndRate", typeof(string), "Currency + ' ' + Rate");

            ddlPrice.DataTextField = "CurrencyAndRate";
            ddlPrice.DataValueField = "Id";
            ddlPrice.DataSource = ds;
            ddlPrice.DataBind();
        }
        private void BindDataReaderData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblRates", con);
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListItem li= new ListItem(rdr["Currency"]+""+rdr["Rate"],rdr["Id"].ToString());
                    ddlPrice.Items.Add(li);
                }
            }
        }
    }
}