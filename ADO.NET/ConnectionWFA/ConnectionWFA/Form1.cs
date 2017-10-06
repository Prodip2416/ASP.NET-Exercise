using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using  System.Configuration;

namespace ConnectionWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string CS= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con= new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand("Select * from tblCity", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
             BindingSource source= new BindingSource();
            source.DataSource = rdr;
            dataGridView1.DataSource = source;
           con.Close();
        }
    }
}
