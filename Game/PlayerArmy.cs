using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class PlayerArmy
    {
        public List<IUnit> Army { get; set; }

        public PlayerArmy()
        {
            Army = new List<IUnit>();
        }

        public PlayerArmy(List<IUnit> army)
        {
            Army = army;
        }

        public void AddUnit(IUnit unit)
        {
            Army.Add(unit);
        }

        public void RemoveUnit(IUnit unit)
        {
            var unitToRemove = Army.First(a => a.GetType() == unit.GetType());
            Army.Remove(unitToRemove);
        }
    }
}
