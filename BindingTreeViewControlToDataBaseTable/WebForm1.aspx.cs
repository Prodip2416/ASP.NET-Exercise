using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BindingTreeViewControlToDataBaseTable
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetTreeViewItems();
            }
        }

        private void GetTreeViewItems()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("spGetTreeViewItems", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ds.Relations.Add("ChildRows", ds.Tables[0].Columns["ID"],
                ds.Tables[0].Columns["ParentId"]);

            foreach (DataRow level1DataRow in ds.Tables[0].Rows)
            {
                if (string.IsNullOrEmpty(level1DataRow["ParentId"].ToString()))
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = level1DataRow["TreeViewText"].ToString();
                    treeNode.NavigateUrl = level1DataRow["NavigateURL"].ToString();

                    DataRow[] level2DataRows = level1DataRow.GetChildRows("ChildRows");
                    foreach (DataRow level2DataRow in level2DataRows)
                    {
                        TreeNode childTreeNode = new TreeNode();
                        childTreeNode.Text = level2DataRow["TreeViewText"].ToString();
                        childTreeNode.NavigateUrl = level2DataRow["NavigateURL"].ToString();
                        treeNode.ChildNodes.Add(childTreeNode);
                    }
                    TreeView1.Nodes.Add(treeNode);
                }
            }
        }
    }
}