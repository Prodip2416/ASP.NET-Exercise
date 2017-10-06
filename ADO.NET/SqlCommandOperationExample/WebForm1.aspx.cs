using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlCommandOperationExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string CS= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            // ExecuteReader ..................

            //SqlCommand cmd= new SqlCommand("Select ID ,DeptName ,Location, DeptHead from tblDepartment", con);
            //con.Open();
            //GridView1.DataSource = cmd.ExecuteReader();
            //GridView1.DataBind();
            //con.Close();

            //-------------//////---------------------

            // ExecuteScalar....Count Rows.........

            //SqlCommand cmd= new SqlCommand();
            //cmd.CommandText = "Select count(ID) from tblDepartment";
            //cmd.Connection = con;
            //con.Open();
            //int totalRows = (int) cmd.ExecuteScalar();
            //con.Close();
            //Response.Write("Total Rows = "+totalRows.ToString());
           
            //------------------///-----------------

            //ExecuteNonQuery...........Insert, Update, Delete....................................

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "delete from tblDepartment where ID= 7";
            int totalRows = cmd.ExecuteNonQuery();
            Response.Write("Total RowsDeleted = " + totalRows.ToString() + "<br/>");

            cmd.CommandText = "Insert into tblDepartment values (11,'dhdtrfhd','Horirampur','Palash')";
            totalRows = cmd.ExecuteNonQuery();
            Response.Write("Total Inserted Affected = " + totalRows.ToString() + "<br/>");

            cmd.CommandText = "update tblDepartment set DeptName = 'ttttt' where ID = 3";
            totalRows = cmd.ExecuteNonQuery();
            Response.Write("Total Updated Rows Affected = " + totalRows.ToString());

            con.Close();

        }
    }
}