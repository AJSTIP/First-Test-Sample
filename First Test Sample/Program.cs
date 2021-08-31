using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Test_Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name is: {userName}, Age is: {userAge}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            
            int hoursOfSleep = Convert.ToInt32(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job thats a lot of sleep");
            }
            else if (hoursOfSleep >= 6)
            {
                Console.WriteLine("Not bad, but you need more");
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("Dude you need more sleep.");
            }
            else
            {
                Console.WriteLine("I dont know what you wrote");
            }

            Console.ReadKey();
        }
    }
}
