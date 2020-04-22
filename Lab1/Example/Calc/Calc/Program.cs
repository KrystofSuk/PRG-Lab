using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej X:");
            float x;
            if (!float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("X musi byt cislo!");
                return;
            }

            Console.WriteLine("Zadej Y:");
            float y;
            if (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Y musi byt cislo!");
                return;
            }

            Console.WriteLine("Zadej Operaci:");
            char op;
            char.TryParse(Console.ReadLine(), out op);

            if (op == '*')
            {
                Console.WriteLine("Vysledek {0}", x * y);
            }
            else if(op == '+')
            {
                Console.WriteLine("Vysledek {0}", x + y);
            }
            else if(op == '-')
            {
                Console.WriteLine("Vysledek {0}", x - y);
            }
            else if(op == '/')
            {
                if(y == 0)
                {
                    Console.WriteLine("Deleni nulou!!!");
                    return;
                }
                Console.WriteLine("Vysledek {0}", x / y);
            }
            else if(op == '^')
            {
                Console.WriteLine("Vysledek {0}", Math.Pow(x, y));
            }
            else
            {
                Console.WriteLine("Spatna operace");
            }
        }
    }
}
