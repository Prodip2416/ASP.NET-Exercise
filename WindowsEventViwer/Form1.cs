using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEventViwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != String.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource(textBox1.Text, textBox2.Text);
                MessageBox.Show("Event Log are created.");
            }
            else
            {
                MessageBox.Show("Event log are Required.");
            }
        }
    }
}
