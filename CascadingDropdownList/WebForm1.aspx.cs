using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CascadingDropdownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlContinent.DataSource= GetData("spGetContinents", null);
                ddlContinent.DataBind();

                ListItem liContinent = new ListItem("Select Continent", "-1");
                ddlContinent.Items.Insert(0, liContinent);

                ListItem liCountry = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, liCountry);

                ListItem liCities = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCities);

                ddlCountries.Enabled = false;
                ddlCities.Enabled = false;
            }
        }
        private DataSet GetData(string SPName,SqlParameter SPParameter)
        {
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(SPParameter !=null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        protected void ddlContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinent.SelectedIndex == 0)
            {
                ddlCountries.SelectedIndex = 0;
                ddlCountries.Enabled = false;

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
            else
            {
                ddlCountries.Enabled = true;
                SqlParameter parameter = new SqlParameter("@ContinentId", ddlContinent.SelectedValue);
                DataSet ds= GetData("spGetCountriesByContinentId", parameter);

                ddlCountries.DataSource = ds;
                ddlCountries.DataBind();

                ListItem liCountry = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, liCountry);

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedIndex == 0)
            {

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
            else
            {
                ddlCities.Enabled = true;
                SqlParameter parameter = new SqlParameter("@CountryId", ddlCountries.SelectedValue);
                DataSet ds = GetData("spGetCitiesByCountryId", parameter);
                 
                ddlCities.DataSource = ds;
                ddlCities.DataBind();

                ListItem liCountry = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCountry);
            }
        }
    }
}