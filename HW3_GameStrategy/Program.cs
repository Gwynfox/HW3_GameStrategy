namespace HW3_GameStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //GoToUnitSeller(); // - dont work
            CheckArmy();
        }
        public static UnitArcher СreateArcher()
        {
            var archer = new UnitArcher();
                        
            archer.healthPoint = 4;
            archer.defense = 2;
            archer.attack = 5;
            archer.cost = 30;

            return archer;
        }
        public static EliteUnitArcher СreateEliteArcher()
        {
            var eliteArcher = new EliteUnitArcher();

            eliteArcher.healthPoint = 5;
            eliteArcher.defense = 4;
            eliteArcher.attack = 5;
            eliteArcher.fireAttack = 4;
            eliteArcher.cost = 60;

            return eliteArcher;
        }
        public static Swordsman СreateSwordsman()
        {
            var swordsman = new Swordsman();

            swordsman.healthPoint = 6;
            swordsman.defense = 3;
            swordsman.attack = 6;
            swordsman.penetrationAttack = 3;
            swordsman.cost = 40;

            return swordsman;
        }
        public static Protector СreateProtector()
        {
            var protector = new Protector();

            protector.healthPoint = 9;
            protector.defense = 6;
            protector.attack = 4;
            protector.cost = 70;

            return protector;
        }
        // GoToUnitSeller  dont work
        static void GoToUnitSeller()
        {
            Console.WriteLine("- Hello, my Lord. " +
                "\nIn my barracks you can buy units for your army.");
            Console.ReadLine();

            Console.WriteLine($"- This is what I can offer to you:");
            var archer = СreateArcher();
            var eliteArcher = СreateEliteArcher();
            var swordsman = СreateSwordsman();
            var protector = СreateProtector();

            Console.WriteLine("1:"); archer.Print();
            Console.WriteLine("2:"); eliteArcher.Print();
            Console.WriteLine("3:"); swordsman.Print();
            Console.WriteLine("4:"); protector.Print();
            
            Console.WriteLine("\nWhat units do you want to buy today?");

            GetArmy(archer,eliteArcher,swordsman,protector);
        }
        // GetArmy dont work
        static void GetArmy(UnitArcher archer, UnitArcher eliteArcher, Swordsman swordsman, Protector protector)
        {
            Random rndCapital = new Random();
            int capital = rndCapital.Next(200, 1000);            
            Console.WriteLine($"(You have {capital} coins)");            
            while (capital > 0)
            {
                var choise = int.Parse(Console.ReadLine());
                var resultCapital = capital;
                switch (choise)
                {
                    case 1:
                        resultCapital = capital - archer.cost;
                        Console.WriteLine($"{resultCapital}"); // return resultCapital??
                        continue;
                    case 2:
                        resultCapital = capital - eliteArcher.cost;
                        Console.WriteLine($"{resultCapital}"); // return resultCapital??
                        continue;
                    case 3:
                        resultCapital = capital - swordsman.cost;
                        Console.WriteLine($"{resultCapital}"); // return resultCapital??
                        continue;
                    case 4:
                        resultCapital = capital - protector.cost;
                        Console.WriteLine($"{resultCapital}"); // return resultCapital??
                        continue;
                    default:
                        Console.WriteLine("Please, enter the unit 1-4");
                        break;
                }

            }
            //static void CalculateCost(UnitArcher archer, ref capital)
            //{
            //    var resultCapital = capital - archer.cost;
            //    return resultCapital;
            //}       
        }
        static void CheckArmy()
        {
            Console.WriteLine("It's types of units in you Army:");

            var archer = СreateArcher();
            var eliteArcher = СreateEliteArcher();
            var swordsman = СreateSwordsman();
            var protector = СreateProtector();
            
            Console.WriteLine("1:"); archer.Print();
            Console.WriteLine("2:"); eliteArcher.Print();
            Console.WriteLine("3:"); swordsman.Print();
            Console.WriteLine("4:"); protector.Print();

            Console.ReadLine();

            Console.WriteLine("It's you Army:");

            Random rndNombers = new Random();
            int nomberOfArchers = rndNombers.Next(1, 10);
            int nomberOfEliteArcher = rndNombers.Next(1, 10);
            int nomberOfSwordsman = rndNombers.Next(1, 10);
            int nomberOfProtector = rndNombers.Next(1, 10);

            Console.WriteLine($"\nNow you have:" +
                $"\n {nomberOfArchers} Archers" +
                $"\n {nomberOfEliteArcher} Elite Archers" +
                $"\n {nomberOfSwordsman} Swordsmens" +
                $"\n {nomberOfProtector} Protectors");

            Console.ReadLine();

            Console.WriteLine($"Cost of your army: {archer.cost * nomberOfArchers + eliteArcher.cost * nomberOfEliteArcher + swordsman.cost * nomberOfSwordsman + protector.cost * nomberOfProtector}");

            Console.ReadLine();
            //int[] costArmy = {archer.cost, eliteArcher.cost, swordsman.cost, protector.cost};
            //
            //Array.Sort(costArmy);
            //
            //Console.WriteLine($"{archer.cost}");
            //
            //Console.WriteLine (costArmy);
        }
    }
}