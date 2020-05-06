using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            //y 
            // 0,2|1,2|2,2
            // 0,1|1,1|2,1
            // 0,0|1,0|2,0
            //            x

            // g|h|i
            // d|e|f
            // a|b|c

            // ' ' - nic tam neni
            // 'x' - krizek
            // 'o' - kolecko

            char a = ' '; // 0
            char b = ' '; // 1
            char c = ' '; // 2 
            char d = ' '; // 3
            char e = ' '; // 4
            char f = ' '; // 5
            char g = ' '; // 6
            char h = ' '; // 7
            char i = ' '; // 8

            bool state = false; //false = krizky / true = kolecka

            while (true)
            {
                Console.WriteLine("Kam umistuji?");
                int pos;
                int.TryParse(Console.ReadLine(), out pos);
                if (pos == -1)
                    return;



                if (state == false)
                {
                    if (pos == 0)
                    {
                        a = 'x';
                    }
                    if (pos == 1)
                    {
                        b = 'x';
                    }
                    if (pos == 2)
                    {
                        c = 'x';
                    }
                    if (pos == 3)
                    {
                        d = 'x';
                    }
                    if (pos == 4)
                    {
                        e = 'x';
                    }
                    if (pos == 5)
                    {
                        f = 'x';
                    }
                    if (pos == 6)
                    {
                        g = 'x';
                    }
                    if (pos == 7)
                    {
                        h = 'x';
                    }
                    if (pos == 8)
                    {
                        i = 'x';
                    }

                    state = true;
                }
                else if(state == true)
                {
                    if (pos == 0)
                    {
                        a = 'o';
                    }
                    if (pos == 1)
                    {
                        b = 'o';
                    }
                    if (pos == 2)
                    {
                        c = 'o';
                    }
                    if (pos == 3)
                    {
                        d = 'o';
                    }
                    if (pos == 4)
                    {
                        e = 'o';
                    }
                    if (pos == 5)
                    {
                        f = 'o';
                    }
                    if (pos == 6)
                    {
                        g = 'o';
                    }
                    if (pos == 7)
                    {
                        h = 'o';
                    }
                    if (pos == 8)
                    {
                        i = 'o';
                    }

                    state = false;
                }

                Console.Clear();
                Console.WriteLine(g + "|" + h + "|" + i);
                Console.WriteLine("-----");
                Console.WriteLine(d + "|" + e + "|" + f);
                Console.WriteLine("-----");
                Console.WriteLine(a + "|" + b + "|" + c);


                //win check
                //x x x
                //3
                if (a == b && b == c && a != ' ')
                {
                    Console.WriteLine("Vyhral " + a);
                    return;
                }
                if (d == e && e == f && d != ' ')
                {
                    Console.WriteLine("Vyhral " + d);
                    return;
                }
                if (g == h && h == i && g != ' ')
                {
                    Console.WriteLine("Vyhral " + g);
                    return;
                }

                //x
                //x
                //x
                //3
                if (a == d && d == g && a != ' ')
                {
                    Console.WriteLine("Vyhral " + a);
                    return;
                }
                if (b == e && e == h && b != ' ')
                {
                    Console.WriteLine("Vyhral " + b);
                    return;
                }
                if (c == f && f == i && c != ' ')
                {
                    Console.WriteLine("Vyhral " + c);
                    return;
                }

                //x
                // x
                //  x
                //2
                // g|h|i
                // d|e|f
                // a|b|c
                if (a == e && e == i && a != ' ')
                {
                    Console.WriteLine("Vyhral " + a);
                    return;
                }
                if (g == e && e == c && c != ' ')
                {
                    Console.WriteLine("Vyhral " + c);
                    return;
                }
            }
        }
    }
}
