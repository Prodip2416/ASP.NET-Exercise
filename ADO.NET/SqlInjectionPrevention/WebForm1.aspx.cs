using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjectionPrevention
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand();
            //first way,,to avoid sqlInjection...
            // cmd.CommandText = "Select * from tblProduct where productName like @productName";
            // cmd.Parameters.AddWithValue("@productName", TextBox1.Text + "%");

            // 2nd Way to avoid SQL Injection,,,,,,,,,,,,,,,,,,

            #region CreateProcedure
            //Create procedure spGetProductByName
            //@productName nvarchar(50)
            //as
            //Begin
            // Select * from tblProduct where productName like @productName + '%'
            //End

            // i';Delete From tblProduct--
            #endregion

            cmd.CommandText = "spGetProductByName";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productName",TextBox1.Text+"%");

            cmd.Connection = con;
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}