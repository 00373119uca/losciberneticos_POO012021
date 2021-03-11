using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0 , b = 0;
            Console.WriteLine("Enter value for 'a': ");
            a=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for 'b': ");
            b=Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Adding {a} + {b} equales {AddNumber(a,b)}");
        }
        static int AddNumber(int a, int b)
        {
            return a+b;
        }
    }
}
