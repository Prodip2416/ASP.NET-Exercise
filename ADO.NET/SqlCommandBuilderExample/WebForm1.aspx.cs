using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlCommandBuilderExample
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
            string qry = "Select * From tblStudents Where Id = "+ txtId.Text;
            SqlDataAdapter da= new SqlDataAdapter(qry,con);
            DataSet ds = new DataSet();

            da.Fill(ds, "Students");

            ViewState["SQL_Query"] = qry;
            ViewState["DataSet"] = ds;

            if (ds.Tables["Students"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Students"].Rows[0];
                txtName.Text = dr["Name"].ToString();
                ddlGender.SelectedValue = dr["Gender"].ToString();
                txtMarks.Text = dr["Marks"].ToString();
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "No Student record with Id = "+txtId.Text;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter((string) ViewState["SQL_Query"], con);

            SqlCommandBuilder builder= new SqlCommandBuilder(da);
            DataSet ds = (DataSet)ViewState["DataSet"];

            if (ds.Tables["Students"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Students"].Rows[0];
                dr["Name"] = txtName.Text;
                dr["Gender"] = ddlGender.SelectedValue;
                dr["Marks"] = txtMarks.Text;

            }
           int RowUpdate= da.Update(ds, "Students");

            if (RowUpdate > 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = RowUpdate + " row(s) updates.";
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "No row updates.";
            }
        }
    }
}