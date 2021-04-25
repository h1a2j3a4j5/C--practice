using System;

namespace or_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth and print your age:");
            int  year = int.Parse(Console.ReadLine());
            int sum = 2021;
            int minus = sum - year;
            Console.WriteLine($"This is your age: {minus}");
        }
    }
}
