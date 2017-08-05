using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingMultipleResponse
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetProductName("All");
            }
            Label1.Text = DateTime.Now.ToString();
        }

        protected void GetProductName(string ProductName)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter("spGetProductsByName", con);
            da.SelectCommand.CommandType=CommandType.StoredProcedure;

            SqlParameter parameterName= new SqlParameter();
            parameterName.ParameterName = "@ProductName";
            parameterName.Value = ProductName;
            da.SelectCommand.Parameters.Add(parameterName);

            DataSet ds= new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductName(DropDownList1.SelectedValue);
        }
    }
}