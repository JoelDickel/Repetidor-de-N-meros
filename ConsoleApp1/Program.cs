using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números?");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; a > i; i++)
            {
                Console.WriteLine(a);
            }
        }
    }
}
