using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static int liczba_pierwiastkow (double a, double b, double c)
        {
            double d;
            if (a != 0)
            {
                d = b * b - (4 * a * c);
                if (d > 0) return 2;
                else if (d == 0) return 1;
                else return 0;
            }
            else return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This function has [solutions] [y=4x2+8x+5]: {0} ", liczba_pierwiastkow(4,8,5));
            Console.WriteLine("This function has [solutions]a [y=0x2+4x+3]: {0} ", liczba_pierwiastkow(0, 4, 3));
            Console.WriteLine("This function has [solutions] [y=x2-2x+1]: {0} ", liczba_pierwiastkow(1, -2, 1));
            Console.WriteLine("This function has [solutions] [y=-4x2+8x+5]: {0} ", liczba_pierwiastkow(-4, 8, 0));
            Console.ReadKey();
        }

    }
}
