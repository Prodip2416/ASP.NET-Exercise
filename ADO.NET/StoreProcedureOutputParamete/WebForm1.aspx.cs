using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreProcedureOutputParamete
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand("spAddEmployee", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeName", txtName.Text);
            cmd.Parameters.AddWithValue("@employeeGender", ddlGender.SelectedValue);
            cmd.Parameters.AddWithValue("@employeeSalary", txtSalary.Text);

            // Most Important Thing ...
            // Output parameter needs 3 thing
            // 1.ParameterName 2.sqlDbType 3.Direction.

            SqlParameter outputParameter= new SqlParameter();
            outputParameter.ParameterName = "@EmployeeId ";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            con.Open();
            cmd.ExecuteNonQuery();
            string empId = outputParameter.Value.ToString();
            lblMessage.Text = "Employee Id = " + empId;

            SqlCommand cmmd = new SqlCommand("Select * from tblEmployee",con);
             GridView1.DataSource= cmmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}