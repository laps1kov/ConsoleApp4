using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x = ");
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
            return;
        }

        }
}
