using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public String Name { get; set; }
        public Army Army { get; set; }

        public Player(String name, Army army)
        {
            Name = name;
            Army = army;
        }

    }
}
