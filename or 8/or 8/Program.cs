using System;

namespace or_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that inserts your year of birth and prints your age:");
            int years = int.Parse(Console.ReadLine());
            int add = getAge(years);
            Console.WriteLine("your age is {0}", add);
        }
        static int getAge(int year)
            {
            return 2021 - year;
        }
    }
}
