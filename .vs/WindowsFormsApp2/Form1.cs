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
    public partial class Form1 : Form
    { internal static competition c  ;        
            competition c1 = new competition();
        
        public Form1()
        { 
            InitializeComponent();
        }

        public Form1(string text)
        {
            int i1 = 0;
            InitializeComponent();
            Text = text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_team.DataSource = c1.Teamnames();
            cmb_team.Hide();
            comboBox_team.Hide(); 


        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            player P = new player();
            P.id = int.Parse(txt_id.Text);
            P.name = txt_name.Text;
            P.birthday = dateTimePicker_birthday.Value;
            string teamname = comboBox_team.Text;
            bool res = c1.AddPlayerToTeam(P, teamname);
            if (res == true)
                MessageBox.Show("player added");
            else MessageBox.Show("player not added");

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }
    }
    
        } 

