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
            Random r = new Random();
            int x, y;
            System.Console.WriteLine("Enter the location of A: ");
            System.Console.Write("AX: ");
            string xx = Console.ReadLine();
            x = Convert.ToInt32(xx);

            System.Console.Write("AY: ");

            string yy = Console.ReadLine();
            y = Convert.ToInt32(yy);

            int xxx = x;
            int yyy = y;

            x = x + 12;
            y = 11 - y;

            //2x-2 kullan
            string sets = "123";
            int a = r.Next(0, 3);
            char aset = sets[a];
            Console.WriteLine(aset);

            sets = sets.Remove(a, 1);
            Console.WriteLine(sets);
            Console.WriteLine("ae");

            string array2D = "    + - - - - - - - - - - ^ - - - - - - - - - - +\n 10 | . . . . . . . . . . | . . . . . . . . . . |\n  9 | . . . . . . . . . . | . . . . . . . . . . |\n  8 | . . . . . . . . . . | . . . . . . . . . . |\n  7 | . . . . . . . . . . | . . . . . . . . . . |\n  6 | . . . . . . . . . . | . . . . . . . . . . |\n  5 | . . . . . . . . . . | . . . . . . . . . . |\n  4 | . . . . . . . . . . | . . . . . . . . . . |\n  3 | . . . . . . . . . . | . . . . . . . . . . |\n  2 | . . . . . . . . . . | . . . . . . . . . . |\n  1 | . . . . . . . . . . | . . . . . . . . . . |\n  0 | - - - - - - - - - - + - - - - - - - - - - >\n -1 | . . . . . . . . . . | . . . . . . . . . . |\n -2 | . . . . . . . . . . | . . . . . . . . . . |\n -3 | . . . . . . . . . . | . . . . . . . . . . |\n -4 | . . . . . . . . . . | . . . . . . . . . . |\n -5 | . . . . . . . . . . | . . . . . . . . . . |\n -6 | . . . . . . . . . . | . . . . . . . . . . |\n -7 | . . . . . . . . . . | . . . . . . . . . . |\n -8 | . . . . . . . . . . | . . . . . . . . . . |\n -9 | . . . . . . . . . . | . . . . . . . . . . |\n-10 | . . . . . . . . . . | . . . . . . . . . . |\n    + - - - - - - - - - - - - - - - - - - - - - +\n      0 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 0  ";
            Console.WriteLine(array2D);
            Console.ReadLine();
        }
    }
}
