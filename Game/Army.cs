using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Army
    {
        public List<IUnit> Units { get; set; }

        public Army()
        {
            Units = new List<IUnit>();
        }

        public Army(List<IUnit> units)
        {
            Units = units;
        }

        public void AddUnit(IUnit unit, Player player)
        {
            if(Units.Count() > player.MaxArmySize)
                Units.Add(unit);
        }

        public void RemoveUnit(IUnit unit)
        {
            var unitToRemove = Units.First(a => a.GetType() == unit.GetType());
            Units.Remove(unitToRemove);
        }

        public IUnit GetFirstUnit()
        {
            return Units.First();
        }
    }
}
