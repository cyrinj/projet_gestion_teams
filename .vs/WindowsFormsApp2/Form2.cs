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
    public partial class Form2 : Form
    {
        team t = new team();
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            competition c = new competition();
           
            t.code = int.Parse( Text_id.Text) ;
            t.name = text_name.Text;
            t.nbrsubscribers = int.Parse(comboBox_nbrj.Text);
            t.creationdate = dateTimePicker_cr.Value;
            c.teams.Add(t);
            dataGridView1.DataSource = Form1.c.teamplayers(t.name); 




            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(text_name.Text);
            f1.Show(); 


        }
    }

        
    }

