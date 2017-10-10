using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StronglyTypedDataSet.StudentDataSetTableAdapters;

namespace StronglyTypedDataSet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StudentDataSetTableAdapters.StudentsTableAdapter STA= new 
                    StudentDataSetTableAdapters.StudentsTableAdapter();
               StudentDataSet.StudentsDataTable SDT= new
                    StudentDataSet.StudentsDataTable();
                STA.Fill(SDT);
                Session["DATATABLE"] = SDT;
                GridView1.DataSource = from student in SDT
                    select new
                    {
                        student.Id,
                        student.Name,
                        student.Gender,
                        student.Marks
                    };

                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDataSet.StudentsDataTable sdt=(StudentDataSet.StudentsDataTable)Session["DATATABLE"];
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                GridView1.DataSource = from student in sdt
                                       select new
                                       {
                                           student.Id,
                                           student.Name,
                                           student.Gender,
                                           student.Marks
                                       };

                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = from student in sdt
                                       where student.Name.ToUpper().ToString().StartsWith(TextBox1.Text.ToUpper())
                                       select new
                                       {
                                           student.Id,
                                           student.Name,
                                           student.Gender,
                                           student.Marks
                                       };

                GridView1.DataBind();
            }
        }
    }
}