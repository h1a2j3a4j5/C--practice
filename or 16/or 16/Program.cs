using System;

namespace or_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a function that takes two strings and returns one string:");
            string one = Convert.ToString(Console.ReadLine());
            string plus = " ";
            string two = Convert.ToString(Console.ReadLine());
            string add = Essay(one , plus , two);
            Console.WriteLine("The string is:{0}", add);
        }
        static string Essay(string one ,string plus , string two)
        {
            string free = one + plus + two;
            return free;
        }
    }
}
