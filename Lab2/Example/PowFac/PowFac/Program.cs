using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowFac
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cislo x:");
                int x = 0;
                if(!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Chyba");
                }
                else
                {
                    Console.WriteLine("Cislo y nebo !:");
                    string line = Console.ReadLine();
                    int y = 0;
                    if(line == "!")
                    {
                        for(int i = x - 1; i > 1; i--)
                        {
                            x *= i;
                        }
                        Console.WriteLine("Factorial: " + x);
                    }
                    else if(line == "e")
                    {
                        break;
                    }
                    else if(int.TryParse(line, out y))
                    {
                        int pow = x;
                        for (int i = 1; i < y; i++)
                        {
                            x *= pow;
                        }
                        Console.WriteLine("Mocnina: " + x);
                    }
                    else
                    {
                        Console.WriteLine("Chyba");
                    }
                }
            }
        }
    }
}
