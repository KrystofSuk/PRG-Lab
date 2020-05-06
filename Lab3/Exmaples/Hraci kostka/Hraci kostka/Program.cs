using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hraci_kostka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag; // false = spatne / true = true
            //a - b
            Console.WriteLine("Zadej spodni mez:");
            int a = 0;
            flag = int.TryParse(Console.ReadLine(), out a);

            if(flag == false)
            {
                Console.WriteLine("Chyba");
                return;
            }

            Console.WriteLine("Zadej horni mez:");
            int b = 0;
            flag = int.TryParse(Console.ReadLine(), out b);

            if (flag == false)
            {
                Console.WriteLine("Chyba");
                return;
            }

            Console.WriteLine("Hazim od " + a + " po " + b);

            //randomizer
            Random kostka = new Random();

            //.next(a <= x < b)
            Console.WriteLine(kostka.Next(a, b + 1));
        }
    }
}
