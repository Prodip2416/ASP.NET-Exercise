using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StronglyTypedDataSet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
               SqlConnection con= new SqlConnection(CS);
                string qry = "select * from tblStudents";
                SqlDataAdapter da= new SqlDataAdapter(qry,con);

                DataSet ds= new DataSet();
                da.Fill(ds, "Students");

                Session["DATASET"] = ds;

                GridView1.DataSource = from dataRow in ds.Tables["Students"].AsEnumerable()
                    select new Student
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString(),
                        Gender = dataRow["Gender"].ToString(),
                        Marks = Convert.ToInt32(dataRow["Marks"])
                    };
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)Session["DATASET"];
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                GridView1.DataSource = from dataRow in ds.Tables["Students"].AsEnumerable()
                    select new Student
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString(),
                        Gender = dataRow["Gender"].ToString(),
                        Marks = Convert.ToInt32(dataRow["Marks"])
                    };
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = from dataRow in ds.Tables["Students"].AsEnumerable()
                                       where dataRow["Name"].ToString().ToUpper().StartsWith(TextBox1.Text.ToUpper())
                                       select new Student
                                       {
                                           Id = Convert.ToInt32(dataRow["Id"]),
                                           Name = dataRow["Name"].ToString(),
                                           Gender = dataRow["Gender"].ToString(),
                                           Marks = Convert.ToInt32(dataRow["Marks"])
                                       };
                GridView1.DataBind();
            }
        }
    }
}