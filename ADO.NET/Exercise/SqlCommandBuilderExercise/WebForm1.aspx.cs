using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlCommandBuilderExercise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadStudent_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string qry = "Select * From tblStudents Where Id = " + txtId.Text;
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "Student");

            ViewState["SQL_QUERY"] = qry;
            ViewState["DataSet"] = ds;

            if (ds.Tables["Student"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Student"].Rows[0];

                txtName.Text = dr["Name"].ToString();
                ddlGender.SelectedValue = dr["Gender"].ToString();
                txtMarks.Text = dr["Marks"].ToString();
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "No Student Record Id with " + txtId.Text;
            }



        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter((string)ViewState["SQL_QUERY"],con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = (DataSet) ViewState["DataSet"];


            if (ds.Tables["Student"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Student"].Rows[0];
                dr["Name"] = txtName.Text;
                dr["Gender"] = ddlGender.SelectedValue;
                dr["Marks"] = txtMarks.Text;
            }
            int rowUpdate = da.Update(ds, "Student");

            if (rowUpdate > 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = rowUpdate+"Row(s) Update";
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "No Row Update.";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Not Working this code......Some Problem.....Deleted Not Successfully.

            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(CS);
            //SqlDataAdapter da = new SqlDataAdapter((string)ViewState["SQL_QUERY"], con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //DataSet ds = (DataSet)ViewState["DataSet"];

            //if (ds.Tables["Student"].Rows.Count > 0)
            //{
            //     ds.Tables["Student"].Rows[0].Delete();
            //    lblStatus.ForeColor = System.Drawing.Color.Green;
            //    lblStatus.Text = "Deleted Successfully.";
            //}
            //else
            //{
            //    lblStatus.ForeColor = System.Drawing.Color.Red;
            //    lblStatus.Text = "Deleted Not Successfully.";
            //}
           

        }
    }
}