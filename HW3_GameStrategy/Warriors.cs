using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_GameStrategy
{
    public class Swordsman : Unit
    {
        public string unitClass = "Swordsman";
        public string weapon = "Two Sword";
        public int penetrationAttack;
        public void Print()
        {
            Console.WriteLine($"Class: {unitClass} | Use: {weapon} | Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Penetration Attack: {penetrationAttack} | Cost: {cost}");
        }
    }
    public class Protector : Unit
    {
        public string unitClass = "Protector";
        public string weapon = "Sword and Shield";        
        public void Print()
        {
            Console.WriteLine($"Class: {unitClass} | Use: {weapon} | Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Cost: {cost}");
        }
    }
}
