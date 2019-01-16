using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ListOfObjects
{
    enum Car
    {
        Ford,
        Dodge,
        Porsche,
        Other
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Stuff> inventory;

            // initialize inventory
            inventory = InitializeInventory();

            DisplayAddThing(inventory);
            DisplayInventory(inventory);
        }

        //allows user to add a thing
        static void DisplayAddThing(List<Stuff> inventory)
        {
            Stuff userThing = new Stuff();
            bool addItem = true;
            bool garageStat = true;
            
            do
            {
                //enter name
                Console.WriteLine("What is your name?");
                userThing.Name = Console.ReadLine();

                //enter garage status
                Console.WriteLine("Is your car in the garage? Yes or no?");
                do
                {
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        userThing.Garage = true;
                        garageStat = false;
                    }
                    if(Console.ReadLine().ToLower() == "no")
                    {
                        userThing.Garage = false;
                        garageStat = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer. Is your car in the garage? Yes or no?");
                    }
            } while (garageStat == true);


                //enter car make
                Console.WriteLine("What make is your car? Ford, Dodge, Porsche, or Other?");
                Car make;
                Enum.TryParse(Console.ReadLine().ToLower(), out make);
                userThing.Make = make;

                //add item to inventory
                inventory.Add(userThing);

                //ask if user wants to add another item
                Console.WriteLine("Would you like to add another item? Yes or no?");
                if (Console.ReadLine().ToLower() == "no")
                {
                    addItem = false;
                }
            } while (addItem == true);
            
        }

        //displays the inventory
        static void DisplayInventory(List<Stuff> inventory)
        {
            //
            //dipslay ollumheaders
            //
            Console.WriteLine("Name : Model : In the garage?".PadRight(25));
            Console.WriteLine("-------------".PadRight(25));

            foreach (Stuff item in inventory)
            {
                Console.WriteLine(item.StuffInfo().PadRight(25));
            }
            Console.ReadLine();
        }

        static List<Stuff> InitializeInventory()
        {
            List<Stuff> inventory = new List<Stuff>();

            Stuff myStuff1 = new Stuff();
            myStuff1.Name = "Joe";
            myStuff1.Make = Car.Ford;
            myStuff1.Garage = false;

            Stuff myStuff2 = new Stuff();
            myStuff2.Name = "Dan";
            myStuff2.Make = Car.Dodge;
            myStuff2.Garage = true;

            Stuff myStuff3 = new Stuff();
            myStuff3.Name = "Mr. Moose";
            myStuff3.Make = Car.Porsche;
            myStuff3.Garage = false;

            //
            //add stuff objects to inventory list   
            //
            inventory.Add(myStuff1);
            inventory.Add(myStuff2);
            inventory.Add(myStuff3);

            return inventory;
        }
    }

    class Stuff
    {
        #region FIELDS
        private Car _make;
        private string _name;
        private bool _Garage;

        #endregion

        #region PROPERTIES


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Car Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public bool Garage
        {
            get { return _Garage; }
            set { _Garage = value; }
        }
        #endregion

        #region METHODS

        public string StuffInfo()
        {
            string stuffInfo;

            stuffInfo = _name + " : " + _make + " : " + _Garage ;

            return stuffInfo;
        }

        #endregion

        #region CONSTRUCTORS
        public Stuff()
        {

        }

        #endregion

    }
}

