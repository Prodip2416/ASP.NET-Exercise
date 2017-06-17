using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TracingInRealTimeExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("GetAllEmployee() started");
            GetAllEmployee();
            Trace.Warn("GetAllEmployee() Complete");
            Trace.Warn("GetGender() started");
            GetGender();
            Trace.Warn("GetGender() Complete");
            Trace.Warn("GetDepartment() started");
            GetDepartment();
            Trace.Warn("GetDepartment() Complete");
        }

        private void GetAllEmployee()
        {
            GridView1.DataSource = ExecuteStoredProcedure("spGetssEmployees");
            GridView1.DataBind();
        }

        private void GetGender()
        {
            GridView2.DataSource = ExecuteStoredProcedure("spGetEmployeesByGender");
           GridView2.DataBind();
        }

        private void GetDepartment()
        {
            GridView3.DataSource = ExecuteStoredProcedure("spGetEmployeesByDepartment");
           GridView3.DataBind();
        }

        private DataSet ExecuteStoredProcedure(string SPparam )
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter(SPparam,con);
            da.SelectCommand.CommandType=CommandType.StoredProcedure;
            DataSet ds= new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}