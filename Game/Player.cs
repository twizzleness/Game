using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        String Name { get; set; }
        PlayerArmy Army { get; set; }

        public Player(String name, PlayerArmy army)
        {
            Name = name;
            Army = army;
        }

    }
}
