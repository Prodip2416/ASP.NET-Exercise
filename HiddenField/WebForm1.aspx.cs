using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace HiddenField
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }
        private void LoadEmployee()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "Select Id, Name, Gender, DeptName from tblEmployees where Id=202";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtName.Text = rdr["Name"].ToString();
                        txtGender.Text = rdr["Gender"].ToString();
                        txtDept.Text = rdr["DeptName"].ToString();
                        HiddenField1.Value = rdr["Id"].ToString();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "Update tblEmployees set Name=@Name, Gender=@Gender, DeptName=@DeptName where Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DeptName", txtDept.Text);
                cmd.Parameters.AddWithValue("@Id", HiddenField1.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtName.Text = "";
                txtDept.Text = "";
                txtGender.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}