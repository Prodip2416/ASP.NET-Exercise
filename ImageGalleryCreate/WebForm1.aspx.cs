using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageGalleryCreate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadImage();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                  string fileName = FileUpload1.FileName;
                  FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/" +fileName));
            }
            Response.Redirect("~/WebForm1.aspx");
        }

        private void UploadImage()
        {
            foreach (string  strFileName in Directory.GetFiles(Server.MapPath("~/Data/")))
            {
                ImageButton image = new ImageButton();
                FileInfo fi = new FileInfo(strFileName);
                image.ImageUrl = "~/Data/" + fi.Name;
                image.Width = Unit.Pixel(100);
                image.Height = Unit.Pixel(100);
                image.Style.Add("padding", "5px");
                image.Click += new ImageClickEventHandler(Image_Click);
                Panel1.Controls.Add(image);
            }
        }

        private void Image_Click(object sender, ImageClickEventArgs e)
        {
           Response.Redirect("~/WebForm2.aspx?ImageURL="+((ImageButton)sender).ImageUrl);
        }
    }
}