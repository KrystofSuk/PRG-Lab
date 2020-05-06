using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamen_nuzky_papir
{
    class Program
    {
        static void Main(string[] args)
        {
            Random oponent = new Random();
            while (true)
            {
                string volba = Console.ReadLine();

                if(volba == "end")
                {
                    break;
                }

                //kamen - 0
                //nuzky - 1
                //papir - 2
                int volbaOponenta = oponent.Next(0, 3);
                Console.WriteLine(volbaOponenta);


                //kdo vyhral
                //openent kamen
                if (volbaOponenta == 0 && volba == "papir")
                {
                    Console.WriteLine("Vyhrali jsme");
                }
                else if(volbaOponenta == 0 && volba == "kamen")
                {
                    Console.WriteLine("Nevyhral nikdo");
                }
                else if (volbaOponenta == 0 && volba == "nuzky")
                {
                    Console.WriteLine("Prohrali jsme");
                }

                //openent nuzky
                if (volbaOponenta == 1)
                {
                    if(volba == "papir")
                    {
                        Console.WriteLine("Prohrali jsme");
                    }
                    else if(volba == "kamen")
                    {
                        Console.WriteLine("Vyhrali jsme");
                    }
                    else
                    {
                        Console.WriteLine("Nevyhral nikdo");
                    }
                }

                //openent papir
                if (volbaOponenta == 2)
                {
                    if (volba == "papir")
                    {
                        Console.WriteLine("Nevyhral nikdo");
                    }
                    else if (volba == "kamen")
                    {
                        Console.WriteLine("Prohrali jsme");
                    }
                    else
                    {
                        Console.WriteLine("Vyhrali jsme");
                    }
                }
            }
        }
    }
}
