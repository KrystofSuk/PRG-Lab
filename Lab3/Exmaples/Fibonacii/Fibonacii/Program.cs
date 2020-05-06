using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 40;

            // 1 2 3 4 5 6 7 8
            // 0 1 1 2 3 5 8 13 ...
            // a b c
            // - a b c
            // - - a b c
            int a = 0;
            int b = 1;



            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                decimal goldenRatio = Convert.ToDecimal(c) / (decimal)b;

                a = b;
                b = c;

                Console.WriteLine("Pro " + i +" prvek je: " + goldenRatio);
            }

        }
    }
}
