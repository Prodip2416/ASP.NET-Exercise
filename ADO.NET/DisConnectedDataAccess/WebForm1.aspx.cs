using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisConnectedDataAccess
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetDataFromDB()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string qry = "Select * From tblStudents";
            SqlDataAdapter da = new SqlDataAdapter(qry,con);
            DataSet ds= new DataSet();

            da.Fill(ds, "Student");

            ds.Tables["Student"].PrimaryKey = new DataColumn[] { ds.Tables["Student"].Columns["Id"] };
            Cache.Insert("DataSet", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

            gvStudent.DataSource = ds;
            gvStudent.DataBind();
            lblMessage.Text = "Data Loaded From DataBase.";
        }

        private void GetDataFromCache()
        {
            if (Cache["DataSet"] != null)
            {
                DataSet ds = (DataSet)Cache["DataSet"];

                gvStudent.DataSource = ds;
                gvStudent.DataBind();
                lblMessage.Text = "Data loaded From Cache";
            }
        }

        protected void btnGetDataFromDB_Click(object sender, EventArgs e)
        {
            GetDataFromDB();
        }

        protected void btnUpdateData_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string qry = "Select * From tblStudents";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);

            DataSet ds = (DataSet) Cache["DataSet"];


            string updateCommand = "Update tblStudents set Name=@Name,Gender=@Gender,Marks=@Marks where Id=@Id";
            SqlCommand cmd= new SqlCommand(updateCommand,con);

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 20, "Gender");
            cmd.Parameters.Add("@Marks", SqlDbType.Int, 0, "Marks");
            cmd.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            da.UpdateCommand = cmd;

            string deleteCommand = "Delete from tblStudents where Id=@Id";
            SqlCommand cmmd = new SqlCommand(deleteCommand, con);

            cmmd.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            da.DeleteCommand = cmmd;

            da.Update(ds, "Student");
            lblMessage.Text = "Data Updated.";

        }

        protected void gvStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (Cache["DataSet"] != null)
            {
                DataSet ds = (DataSet) Cache["DataSet"];
                DataRow dr = ds.Tables["Student"].Rows.Find(e.Keys["Id"]);
                dr["Name"] = e.NewValues["Name"];
                dr["Gender"] = e.NewValues["Gender"];
                dr["Marks"] = e.NewValues["Marks"];

                Cache.Insert("DataSet",ds,null,DateTime.Now.AddHours(24),System.Web.Caching.Cache.NoSlidingExpiration);

                gvStudent.EditIndex = -1;
                GetDataFromCache();
            }
        }

        protected void gvStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudent.EditIndex = e.NewEditIndex;
            GetDataFromCache();
        }

        protected void gvStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudent.EditIndex = -1;
            GetDataFromCache();
        }

        protected void gvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Cache["DataSet"] != null)
            {
                DataSet ds = (DataSet)Cache["DataSet"];
                DataRow dr = ds.Tables["Student"].Rows.Find(e.Keys["Id"]);
                dr.Delete();

                Cache.Insert("DataSet", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

                gvStudent.EditIndex = -1;
                GetDataFromCache();
            }
        }
    }
}