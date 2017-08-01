using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Units
{
    public class Wizard : IUnit
    {
        public int AttackSpeed { get; set; }

        public int AttackStrength { get; set; }
        public int HitPoints { get; set; }

        public int MovementSpeed { get; set; }

        public void DealDamage(IUnit enemy)
        {
            enemy.TakeDamage(AttackStrength);
        }

        public void Die()
        {
            System.Console.WriteLine("Troop has died");
        }

        public void TakeDamage(int amount)
        {
            if (HitPoints - amount <= 0)
                Die();
            else
                HitPoints -= amount;
        }
    }
}
