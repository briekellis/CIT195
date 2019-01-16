using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_HelloAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteDonut;

            Console.WriteLine("What is your favorite donut?");
            favoriteDonut = Console.ReadLine();
            Console.WriteLine("Your favorite donut is... " + favoriteDonut);
            Console.Read();
        }
    }
}
