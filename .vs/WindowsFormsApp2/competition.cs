using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class competition
    {
        public List<team>teams { get; set; }
        public competition()
        {
            teams = new List<team>();

        }
        public List<String> Teamnames()
        {
            List<string> lstnames = new List<string>();
            for (int i = 0; i < teams.Count; i++)
            {
                lstnames.Add(teams[i].name); 

            }
            //foreach (team t in teams)
            //{ lstnames.Add(t.name); }
           
            return lstnames;


        }
        public bool AddPlayerToTeam(player p, String teamname)
        { team t = new team();
            t.name = teamname;

            int index = teams.IndexOf(t); 
            teams[index].AddPlayer(p);
           return true;

            
        }
        public List<player> teamplayers(string Teamname) {
            List<player> lstplayers = new List<player>();
           
            team tt = new team();
            tt.name = Teamname;
            int index = teams.IndexOf(tt);
            if (index == -1) { System.Windows.Forms.MessageBox.Show("this team is unavailable ");  }
            else { lstplayers=teams[index].lstplayers;  }
            return lstplayers; 

        }

        public player playerofteam(String teamName, int idplayer) {
            player p = new player();
            p.id = idplayer;
            team t = new team();

            t.name = teamName;
            int i = 0;
            int index = teams.IndexOf(t);
            int index2 = teams[index].lstplayers.IndexOf(p);


            return teams[index].lstplayers[index2]; 
        }
        public List<int> teamplayersids(String teamname)
        { List<int> lstids = new List <int> ();
            team t = new team();
            t.name = teamname;
            int index1 = teams.IndexOf(t);
            foreach (player p in teams[index1].lstplayers)
            {
                lstids.Add(p.id);
            }
            return lstids;

        }
        public bool deleteplayerofteam(string teamname, int idplayer)
        {
            bool ok = true;
            team t = new team();
            t.name = teamname;
            int index1 = teams.IndexOf(t);
            player p = new player();
            p.id = idplayer;
            ok = teams[index1].lstplayers.Remove(p);
            return ok;

        }

    }
}
