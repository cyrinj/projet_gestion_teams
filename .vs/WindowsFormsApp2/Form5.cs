using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int y = 0;
            comboBox1.DataSource = Form1.c.Teamnames();
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teamname = comboBox1.Text;
            dataGridView1.DataSource = Form1.c.teamplayers(teamname); 
        }
    }
}
