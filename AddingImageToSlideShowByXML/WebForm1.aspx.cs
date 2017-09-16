using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddingImageToSlideShowByXML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadImageData();
            }
        }
        private void LoadImageData()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da= new SqlDataAdapter("spGetImageData", con);
            da.SelectCommand.CommandType=CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Images");

            ViewState["ImageData"] = ds;

            ViewState["ImageDisplayed"] = 1;
            DataRow imageDataRow = ds.Tables["Images"].Select().FirstOrDefault(x => x["order"].ToString() == "1");
            image.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["name"].ToString();
            Label2.Text = imageDataRow["order"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                Button1.Text = "StartSlideBar";
            }
            else
            {
                timer.Enabled = true;
                Button1.Text = "StopSlideBar";
            }
        }

        protected void timer_Tick(object sender, EventArgs e)
        {
            int i = (int)ViewState["ImageDisplayed"];
            i = i + 1;
            ViewState["ImageDisplayed"] = i;

            DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["Images"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
            if (imageDataRow != null)
            {
                image.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
                Label1.Text = imageDataRow["name"].ToString();
                Label2.Text = imageDataRow["order"].ToString();
            }
            else
            {
                LoadImageData();
            }
        }
    }
}