using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascadingDropdwonlist
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlContinent.DataSource = GetData("spGetContinents", null);
                ddlContinent.DataBind();

                ddlCountry.Enabled = false;
                ddlCity.Enabled = false;

                ListItem liContinent= new ListItem("Selected Continent","-1");
                ddlContinent.Items.Insert(0,liContinent);

                ListItem liCountry = new ListItem("Selected Country", "-1");
                ddlCountry.Items.Insert(0, liCountry);

                ListItem liCity = new ListItem("Selected City", "-1");
                ddlCity.Items.Insert(0, liCity);

            }
        }

        private DataSet GetData(string SPstring, SqlParameter sqlParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter(SPstring,con);
            da.SelectCommand.CommandType=CommandType.StoredProcedure;
            if (sqlParameter != null)
            {
                da.SelectCommand.Parameters.Add(sqlParameter);
            }
            DataSet ds= new DataSet();
            da.Fill(ds);
            return ds;

        }

        protected void ddlContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinent.SelectedValue == "-1")
            {
                ddlCountry.Enabled = false;
                ddlCountry.SelectedIndex = 0;

                ddlCity.Enabled = false;
                ddlCity.SelectedIndex = 0;
            }
            else
            {
                ddlCountry.Enabled = true;
                SqlParameter param= new SqlParameter("@ContinentId",ddlContinent.SelectedValue);
                DataSet ds = GetData("spGetCountriesByContinentId", param);
                ddlCountry.DataSource = ds;
                ddlCountry.DataBind();

                ListItem liCountry = new ListItem("Selected Country", "-1");
                ddlCountry.Items.Insert(0, liCountry);

                ddlCity.SelectedIndex = 0;
                ddlCity.Enabled = false;

            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountry.SelectedIndex == 0)
            {
                ddlCity.Enabled = false;
                ddlCity.SelectedIndex = 0;
            }
            else
            {
                ddlCity.Enabled = true;
                ddlCity.SelectedIndex = 0;
                SqlParameter param = new SqlParameter("@CountryId", ddlCountry.SelectedValue);
                DataSet ds = GetData("spGetCitiesByCountryId", param);
                ddlCity.DataSource = ds;
                ddlCity.DataBind();

                ListItem liCountry = new ListItem("Selected City", "-1");
                ddlCity.Items.Insert(0, liCountry);


            }
        }
    }
}