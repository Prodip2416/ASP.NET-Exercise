using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationFromByUsingReCaptche
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try {
                    string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    SqlConnection con = new SqlConnection(CS);
                    SqlCommand cmd = new SqlCommand("spGetDataByRegistration", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@ConfigrPass", txtConfirmPassword.Text);
                    cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                    cmd.Parameters.AddWithValue("@Dept", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Campus", ddlCampus.SelectedValue);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Registration Sucessfully.";
                    Clear();
                }
                catch
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Unknown Problem";
                }
            } 
        }
        private void Clear()
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtEmail.Text = string.Empty;
            ddlCampus.SelectedIndex = -1;
            ddlGender.SelectedIndex = -1;
        }
    }
}