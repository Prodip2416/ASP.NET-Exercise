using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transcation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }

        private void GetData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * From Accounts", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr["AccountNumber"].ToString() == "A1")
                    {
                        lblAccountNumber1.Text = "A1";
                        lblBalance1.Text = rdr["Balance"].ToString();
                        lblName1.Text = rdr["CustomerName"].ToString();
                    }
                    else
                    {

                        lblAccountNumber2.Text = "A2";
                        lblBalance2.Text = rdr["Balance"].ToString();
                        lblName2.Text = rdr["CustomerName"].ToString();
                    }
                }
            }
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "Update Accounts set Balance = Balance - 10 where AccountNumber = 'A1'", con, trans);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update Accounts set Balance = Balance + 10 where AccountNumber = 'A2'", con, trans);
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    lblMessage.Text = "Transaction SuccessFully";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                catch
                {
                    trans.Rollback();
                    lblMessage.Text = "Transaction SuccessFully";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
  
            }
            GetData();
        }
    }
}