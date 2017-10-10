using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnViewDataBase_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand("Select * from Student",con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd=new SqlCommand("spInsertStudent", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
            cmd.Parameters.AddWithValue("@Dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@Campus", ddlCampus.SelectedValue);

           SqlParameter outParameter= new SqlParameter();
            outParameter.ParameterName = "@StudentId";
            outParameter.SqlDbType = System.Data.SqlDbType.Int;
            outParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outParameter);
            con.Open();
            cmd.ExecuteNonQuery();
            String ID = outParameter.Value.ToString();
            lblMessage.Text = "Student Id " + ID + " Inserted";

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("ssDeleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId ",txtDelete.Text);

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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            try
            {
                SqlCommand cmd = new SqlCommand("spGetUpdateStudents", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Dept", txtDept.Text);
                cmd.Parameters.AddWithValue("@Campus", ddlCampus.SelectedValue);
                cmd.Parameters.AddWithValue("@StudentId", txtUpdate.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Update Student Sucessfully.";
            }
            catch
            {
                lblMessage.Text = "Update Not SucessFully.";
            }
            finally
            {
                con.Close();
            }
        }


        protected void btnId_OnClick(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("spGetViewtudent", con);
            con.Open();
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@StudentId ", txtId.Text);

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            if (ds.Tables["Students"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Students"].Rows[0];
                txtName.Text = dr["Name"].ToString();
                ddlGender.SelectedValue = dr["Gender"].ToString();
                txtDept.Text = dr["Dept"].ToString();
                ddlCampus.SelectedValue = dr["Campus"].ToString();
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "No Student Record with Id " + txtId.Text;
            }


            con.Close();



        }
    }
}