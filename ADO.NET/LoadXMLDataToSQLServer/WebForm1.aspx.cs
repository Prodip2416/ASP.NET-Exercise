using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoadXMLDataToSQLServer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(cs);

            DataSet ds= new  DataSet();
            ds.ReadXml(Server.MapPath("~/Data.xml"));
            DataTable dtDept = ds.Tables["Department"];
            DataTable dtEmp = ds.Tables["Employee"];
            con.Open();

            SqlBulkCopy bc= new SqlBulkCopy(con);

            bc.DestinationTableName = "Departments";
            bc.ColumnMappings.Add("ID", "ID");
            bc.ColumnMappings.Add("Name", "Name");
            bc.ColumnMappings.Add("Location", "Location");
            bc.WriteToServer(dtDept);

            SqlBulkCopy bcc = new SqlBulkCopy(con);

            bcc.DestinationTableName = "Employees";
            bcc.ColumnMappings.Add("ID", "ID");
            bcc.ColumnMappings.Add("Name", "Name");
            bcc.ColumnMappings.Add("Gender", "Gender");
            bcc.ColumnMappings.Add("DepartmentId", "DepartmentId");
            bcc.WriteToServer(dtEmp);
            con.Close();

        }
    }
}