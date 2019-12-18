using System;


namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gdc(123123,124124));

            Console.WriteLine("Hello World!");
            System.Console.ReadKey();
        }

        static int gdc(int a, int b)
        {
            int shift=0;
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return b;
            if ((a % 2 == 0) && (b % 2 == 0)) shift = 2 * gdc(a / 2, b / 2);
            if ((a % 2 != 0) && (b % 2 == 0)) shift = gdc(a, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) shift = gdc(a / 2, b);
            if (((a % 2 != 0) && (b % 2 != 0))&& a > b) shift = gdc((a - b) / 2, b);
            if (((a % 2 != 0) && (b % 2 != 0)) && a < b) shift = gdc((b - a) / 2, a);

            return shift;
        }

    }
}
