using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CopyDataOneToAnother
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sourceCS = ConfigurationManager.ConnectionStrings["SourceCS"].ConnectionString;
            string destinationCS = ConfigurationManager.ConnectionStrings["DestinationCS"].ConnectionString;

            using (SqlConnection sourceCon = new SqlConnection(sourceCS))
            {
                SqlCommand cmd = new SqlCommand("Select * from Departments", sourceCon);
                sourceCon.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    using (SqlConnection destinationCon = new SqlConnection(destinationCS))
                    {
                        using (SqlBulkCopy bc = new SqlBulkCopy(destinationCon))
                        {
                            bc.DestinationTableName = "Departments";
                            destinationCon.Open();
                            bc.WriteToServer(rdr);
                        }
                    }
                }
                cmd = new SqlCommand("Select * from Employees", sourceCon);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    using (SqlConnection destinationCon = new SqlConnection(destinationCS))
                    {
                        using (SqlBulkCopy bc = new SqlBulkCopy(destinationCon))
                        {
                            bc.DestinationTableName = "Employees";
                            destinationCon.Open();
                            bc.WriteToServer(rdr);
                        }
                    }
                }

            }
        }
    }
}