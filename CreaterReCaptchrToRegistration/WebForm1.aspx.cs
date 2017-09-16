using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreaterReCaptchrToRegistration
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
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramName = new SqlParameter("@Name", txtName.Text);
                    SqlParameter paramEmail = new SqlParameter("@Email", txtEmail.Text);
                    SqlParameter paramPassword = new SqlParameter("@Password", txtPassword.Text);

                    cmd.Parameters.Add(paramName);
                    cmd.Parameters.Add(paramEmail);
                    cmd.Parameters.Add(paramPassword);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                lblMessage.Text = "Registration Successful";
            }
            else
            {
                lblMessage.Text = "Word verification failed";
            }
        }
    }

}