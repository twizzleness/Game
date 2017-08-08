using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Archer : IUnit
    {
        public int AttackSpeed { get; set; }
        public int AttackStrength { get; set; }
        public int HitPoints { get; set; }
        public int MovementSpeed { get; set; }
        public int Level { get; set; }

        public Archer(int hitPoints, int attackStrength)
        {
            HitPoints = hitPoints;
            AttackStrength = attackStrength;
            AttackSpeed = 3;
            MovementSpeed = 2;
            Level = 1;
        }

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
