using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataReaderExercise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1st Way.......
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(CS);
            //SqlCommand cmd = new SqlCommand("Select * from tblProduct", con);
            //con.Open();

            // SqlDataReader rdr = cmd.ExecuteReader();

            // DataTable dt= new DataTable();
            // dt.Columns.Add("ID");
            // dt.Columns.Add("Name");
            // dt.Columns.Add("Price");
            // dt.Columns.Add("Discountprice");

            // while (rdr.Read())
            // {
            //     DataRow dataRow = dt.NewRow();

            //     int OrginalPrice = Convert.ToInt32(rdr["qtyAvaiable"]);
            //     double discountPrice = OrginalPrice * 0.9;

            //     dataRow["Id"] = rdr["id"];
            //     dataRow["Name"] = rdr["productName"];
            //     dataRow["Price"] = OrginalPrice;
            //     dataRow["DiscountPrice"] = discountPrice;
            //     dt.Rows.Add(dataRow);
            // }
            // GridView1.DataSource =dt;
            //GridView1.DataBind();

            //2nd and best way........

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("Select id as ProductId,productName as ProductName,qtyAvaiable as Price,(qtyAvaiable*.9) as DiscountPrice from tblProduct", con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}