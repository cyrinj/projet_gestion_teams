using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class team
    {
        public List<player> lstplayers { get; set; }
        public int code { get; set; }
        public String name { get; set; }
        public DateTime creationdate { get; set; }
        public int nbrsubscribers { get; set; }
       public team ()
        { lstplayers = new List<player>();

        }
        public bool AddPlayer (player p)
        {
            
      
                if (lstplayers.Contains(p) == false)
                { lstplayers.Add(p);
                    return true; 
                }
                else return false; 
        }

        public override bool Equals(object obj)
        {
            var team = obj as team;
            return team != null &&
                   name == team.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
