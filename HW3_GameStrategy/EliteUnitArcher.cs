using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_GameStrategy
{
    public class EliteUnitArcher : UnitArcher, IComparable<Unit>
    {
        //public string unitClass = "Elite Archer";
        public string weapon = "Fire Bow";
        public int fireAttack;
        public override void Print()
        {
            Console.WriteLine($"Class: {unitClass} | Use: {weapon} | Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Fire Attac: {fireAttack} | Cost: {cost}");
        }
    }
}
