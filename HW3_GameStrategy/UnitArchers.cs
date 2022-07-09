using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3_GameStrategy
{
    public class UnitArcher : Unit, IComparable<Unit>
    {
        //public string unitClass = "Archer";
        public string weapon = "Bow";
        public override void Print()
        {
            Console.WriteLine($"Class: {unitClass} | Use: {weapon} | Health: {healthPoint} | Defence: {defense} | Attack: {attack} | Cost: {cost}");         
        }        
    }    
}
