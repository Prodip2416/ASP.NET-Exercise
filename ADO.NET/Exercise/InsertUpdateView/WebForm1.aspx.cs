using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsertUpdateView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("seNameByStudent", con);
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
            lblMessage.Text = "Student Id = " + id;
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spUpdateStudents", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
            cmd.Parameters.AddWithValue("@Id", txtUpdateId.Text);

            con.Open();
            cmd.ExecuteNonQuery();
           // string id = outputParameter.Value.ToString();
            lblMessage.Text = "Update Student Sucessfully.";
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id ", txtDelete.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Delete Successfully.";
            }
            catch
            {
                lblMessage.Text = "Error";
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd= new SqlCommand("Select * from tblStudents",con);
            con.Open();
            GridView1.DataSource= cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}