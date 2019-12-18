using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array=new string[10];
            Console.WriteLine("Enter 10 strings.");
            for (int i = 0; i < 10; i++)
            {
                array[i]=Console.ReadLine();
            }
            sort(array, 10);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. {1}",i,array[i]);
            }
            Console.ReadKey();
        }

        static void sort (string[] a, int n)
        {
            int c=-1;
            string buf;
            for (int i = 0; i < n; i++)
            {
                buf = a[i];
                for (int j = i; j < n; j++)
                {
                    if (buf.Length > a[j].Length)
                    {
                        buf = a[j];
                        c = j;
                    }
                }
                if (c != -1)
                {
                    buf = a[i];
                    a[i] = a[c];
                    a[c] = buf;
                }
                c = -1;
            }
        }
    }
}
