using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaveImageToDataBase
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            SqlCommand cmd = new SqlCommand("spGetImageId", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = Request.QueryString["Id"]
            };
            cmd.Parameters.Add(param);
            con.Open();
          
            byte[] bytes=(byte[]) cmd.ExecuteScalar();
            string strBase64 = Convert.ToBase64String(bytes);
            Image1.ImageUrl = "data:Image/png;base64," + strBase64;
            con.Close();
        }
    }
}