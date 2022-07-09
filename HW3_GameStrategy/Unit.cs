using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_GameStrategy
{
    public class Unit : IComparable<Unit>
    {
        public string unitClass;
        public int healthPoint;
        public int attack;
        public int defense;
        public int cost;

        public virtual void Print()
        {
            Console.WriteLine($"Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Cost: {cost}");
        }

        
        public virtual int CompareTo(Unit u)
        {
            return this.cost.CompareTo(u.cost);
        }
        public virtual int CompareToDamage(Unit u)
        {
            return this.attack.CompareTo(u.attack);
        }
    }
}
