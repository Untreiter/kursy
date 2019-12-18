using System;
using System.Text.RegularExpressions;

namespace RegexT
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter any string:");
            s = Console.ReadLine();

            Console.WriteLine("Count of vowels: {0}",reg(s));
            Console.ReadKey();
        }

        static int reg (string s)
        {
            Regex r = new Regex("[aeiou]");
            MatchCollection match = r.Matches(s);
            return match.Count;
        }
    }
}
