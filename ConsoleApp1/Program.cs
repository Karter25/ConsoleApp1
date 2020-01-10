using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("potatoe"); // пишем в консоль
            Console.WriteLine("tomorrow is a weekends!");

            string name = "Daniya";

            Console.WriteLine($"My name is {name}");

            Console.Write("enter a film:");//cout write
            string film = Console.ReadLine();
            Console.WriteLine($"My film: {film}");

            Console.WriteLine("how old are you?");
            int age = Convert.ToInt32(Console.ReadLine() );
            Console.WriteLine($"your age:{age}");

            Console.WriteLine("enter a first number");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"summa: {f} + {n} = {f + n}");

                Console.WriteLine($"minus: {f} - {n} = {f - n}");

                Console.WriteLine($"umnozheniye: {f} * {n} = {f * n}");

            Console.WriteLine($"deleniye: {f} / {n} = {f / n}");

            Console.ReadKey(); //ждет клава cin read
        }
    }
}
