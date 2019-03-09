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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

           DialogResult res  = MessageBox.Show("exit confirmation ", "would you want to exit ? ",MessageBoxButtons.YesNo , MessageBoxIcon.Question );
            if (res == DialogResult.Yes )
             Application.Exit();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            
            f1.MdiParent = this;

            f1.Show();



        }

        private void showPlayersOfTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
