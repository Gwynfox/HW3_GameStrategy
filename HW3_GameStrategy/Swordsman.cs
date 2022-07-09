using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_GameStrategy
{
    public class Swordsman : Unit, IComparable<Unit>
    {
        //public string unitClass = "Swordsman";
        public string weapon = "Two Sword";
        public int penetrationAttack;
        public override void Print()
        {
            Console.WriteLine($"Class: {unitClass} | Use: {weapon} | Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Penetration Attack: {penetrationAttack} | Cost: {cost}");
        }
    }    
}
