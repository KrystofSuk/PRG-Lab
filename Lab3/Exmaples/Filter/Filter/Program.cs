using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cyklus nacita slova

            //Porovnani slova
            //Vypiseme
            //Nahradime *

            while (true)
            {
                Console.ResetColor();
                string slovo = Console.ReadLine();

                //Podminky
                if (slovo == "white man" || slovo == "battlefield")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("******");
                }
                else if(slovo == "end me")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(slovo);
                }
            }
        }
    }
}
