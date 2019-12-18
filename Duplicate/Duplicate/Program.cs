using System;
using System.Text.RegularExpressions;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string.");
            string s=Console.ReadLine();
            s=del(s);
            Console.WriteLine(s);
            Console.ReadKey();
        }

        static string del(string s)
        {
            string buf = s;
            Regex reg = new Regex(@"[\?\.\,\!\-\:\;\s]");
            string[] words = reg.Split(buf);
            int n = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (i != words.Length - 1) n += words[i].Length + 1;
                else n += words[i].Length;
                if (words[i] == "") continue;
                
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (string.Compare(words[i], words[j]) == 0)
                    {
                        int g = buf.IndexOf(words[j], n);
                        buf=buf.Remove(g, words[j].Length);
                    }

                }
            }
            return buf;
        }
    }
}
