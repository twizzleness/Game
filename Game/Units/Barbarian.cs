using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    public interface IUnit
    {
        int HitPoints { get; set; }
        int AttackStrength { get; set; }
        int AttackSpeed { get; set; }
        int MovementSpeed { get; set; }
        int Level { get; set; }

        void TakeDamage(int amount);
        void DealDamage(IUnit enemy);
        void Die();
    }

    public class Barbarian : IUnit
    {
        public int HitPoints { get; set; }
        public int AttackStrength { get; set; }
        public int AttackSpeed { get; set; }
        public int MovementSpeed { get; set; }
        public int Level { get; set; }

        public Barbarian(int hitPoints, int attackStrength)
        {
            HitPoints = hitPoints;
            AttackStrength = attackStrength;
            AttackSpeed = 5;
            MovementSpeed = 5;
            Level = 1;
        }

        public void TakeDamage(int amount)
        {
            if (HitPoints - amount <= 0)
                Die();
            else
                HitPoints -= amount;
        }

        public void DealDamage(IUnit enemy)
        {
            enemy.TakeDamage(AttackStrength);
        }

        public void Die()
        {
            System.Console.WriteLine("Troop has died");
        }
    }
}
