using System;

namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeScreen();
            MainMenu();
            ClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 34,
                Name = "Susie",
                Age = 473,
                HasGills = true,
                HomeSea = "Baltic Sea"
            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 56,
                Name = "Sid",
                Age = 18,
                Galaxy = "Andromeda"
            };
        }

        static CaveMonster InitializeCaveMonster()
        {
            return new CaveMonster()
            {
                Id = 125,
                Name = "Bob",
                Age = 1738,
                IsUnderground = true,
                HomeCountry = "Taiwan",
                Origin = "Asia",
                Leggies = 10,
                HasTeeth = true,
                IsBlind = false,
                EatsDirt = false
            };
        }

        static void WelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my app");
            DisplayContinuePrompt();
        }

        private static void DisplayContinuePrompt()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void ClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my app");
            Console.ReadKey();
        }

        static void MainMenu()
        {
            Console.Clear();

            bool loopRun = true;
            int menuSelection;

            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;
            CaveMonster myCaveMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();
            myCaveMonster = InitializeCaveMonster();

            do
            {
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Edit Sea Monster");
                Console.WriteLine("3) Exit");
                Console.WriteLine();
                Console.Write("Enter Selection: ");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster, myCaveMonster);
                        break;

                    case 2:
                        DisplayEditSeaMonster(mySeaMonster);
                        break;

                    case 3:
                        loopRun = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (loopRun);
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, CaveMonster caveMonster)
        {
            Console.Clear();

            Console.WriteLine("Monster Info");

            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seaMonster);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cave Monster");
            DisplayCaveMonsterInfo(caveMonster);

            DisplayContinuePrompt();
        }

        private static void DisplayCaveMonsterInfo(CaveMonster caveMonster)
        {
            Console.WriteLine($"Id: {caveMonster.Id}");
            Console.WriteLine($"Name: {caveMonster.Name}");
            Console.WriteLine($"Age: {caveMonster.Age}");
            Console.WriteLine($"Number of Legs: {caveMonster.Leggies}");
            Console.WriteLine($"Has Teeth? {caveMonster.HasTeeth}");
            Console.WriteLine($"Is Blind? {caveMonster.IsBlind}");
            Console.WriteLine($"Eats Dirt? {caveMonster.EatsDirt}");
            Console.WriteLine($"Is Happy? {(caveMonster.IsHappy() ? "yes" : "no")}");
        }

        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is Happy? {(spaceMonster.IsHappy() ? "yes" : "no")}");

            Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Home Sea: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills? {(seaMonster.HasGills ? "yes" : "no")}");
            Console.WriteLine($"Is Happy? {(seaMonster.IsHappy() ? "yes" : "no")}");
        }

        private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
        {
            Console.WriteLine("Please enter monster ID: ");
            mySeaMonster.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter monster name: ");
            mySeaMonster.Name = Console.ReadLine();

            Console.WriteLine("Please enter monster age: ");
            mySeaMonster.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the home sea: ");
            mySeaMonster.HomeSea = Console.ReadLine();

            bool gills = true;
            do
            {
                Console.WriteLine("Does your monster have gills? Yes or no?");
                string gillStat = Console.ReadLine();

                if (gillStat.ToLower() == "yes")
                {
                    mySeaMonster.HasGills = true;
                    gills = false;
                }
                else if (gillStat.ToLower() == "no")
                {
                    mySeaMonster.HasGills = false;
                    gills = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer. ");
                }
            } while (gills);

        }
    }
}
