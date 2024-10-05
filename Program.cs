using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "James";
            Console.WriteLine(name);
            name = "Alena";
            Console.WriteLine(name);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            Console.Clear();

            Console.WriteLine($"My name is {name}");

            int age = 18;
            Console.WriteLine($"I am {age} years old");

            bool HavePet = false;
            Console.WriteLine($"Do I have a pet? {HavePet}");

            double size = 36.5;
            Console.WriteLine($"My shoes size is {size}");
            Console.Clear();

            DaysOfWeek MyFavoritDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoritDay);

            Console.WriteLine("\t Hellow, \n world!");

            double result = 10 % 3;
            Console.WriteLine(result);
            Console.Clear();

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = checked ((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}. ", name, age);
            Console.Write("What's your favorite day of week? ");
            DaysOfWeek FavoritDay = (DaysOfWeek) byte.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}.", FavoritDay);

            Console.Write("Enter your birtdate: ");
            var birtdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birtdate);

            Console.ReadKey();
        }
    }
}
