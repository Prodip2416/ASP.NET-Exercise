using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilrUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension =System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx")
                {
                    lblMessage.Text = "Please select a .doc or .docx file";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblMessage.Text = "Maximum file size (2MB) exceeded.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {

                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        lblMessage.Text = "File Uploaded";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Please select a file";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}