using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaveImageToDataBase
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Visible = false;
                HyperLink1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string fileName = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp"
                || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binary= new BinaryReader(stream);
                byte[] bytes = binary.ReadBytes((int)stream.Length);

                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection con= new SqlConnection(CS);

                SqlCommand cmd= new SqlCommand("spUploadImage", con);
                cmd.CommandType=CommandType.StoredProcedure;

                SqlParameter param= new SqlParameter()
                {
                    ParameterName = "@Name",
                Value= fileName
                };
                cmd.Parameters.Add(param);
                SqlParameter paramSize=new SqlParameter()
                {
                    ParameterName = "@Size",
                    Value = fileSize
                };
                cmd.Parameters.Add(paramSize);
                SqlParameter paramImage= new SqlParameter()
                {
                    ParameterName = "@ImageData",
                    Value = bytes
                };
                cmd.Parameters.Add(paramImage);
                SqlParameter paramNewId= new SqlParameter()
                {
                    ParameterName = "@NewId",
                    Value = -1,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramNewId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Upload Successfully.";
                HyperLink1.Visible = true;
                HyperLink1.NavigateUrl = "~/WebForm2.aspx?Id=" + cmd.Parameters["@NewId"].Value.ToString();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Only '.jpg' , '.png' , '.bmp', '.gif' file are uploaded.";
                HyperLink1.Visible = false;
            }
        }
    }
}