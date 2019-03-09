using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class player
    {
        public int id { get; set; }
        public String name { get; set; }
        public DateTime birthday { get; set; }
        public int shirtnbr { get; set; }

        public override bool Equals(object obj)
        {
            var player = obj as player;
            return player != null &&
                   id == player.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + id.GetHashCode();
        }
    }
}
