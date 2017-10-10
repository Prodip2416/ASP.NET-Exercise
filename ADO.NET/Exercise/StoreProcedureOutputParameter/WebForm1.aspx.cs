using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreProcedureOutputParameter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            string Cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(Cs);
            SqlCommand cmd= new SqlCommand("seNameByStudent", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);

            SqlParameter outputParameter= new SqlParameter();
            outputParameter.ParameterName = "@Id";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);
            con.Open();
            cmd.ExecuteNonQuery();
            string id = outputParameter.Value.ToString();
            lblMessage.Text = "Student Id= " + id;

            SqlCommand cmmd = new SqlCommand("Select * from tblStudent",con);
           GridView1.DataSource= cmmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}