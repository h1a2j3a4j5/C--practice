using System;

namespace or_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers and check if all the digits in it are equal:");
            string num1 = Convert.ToString(Console.ReadLine());
            bool add = num(num1);
            Console.WriteLine("Is this a correct number : {0}", add);
        }
        static bool num (string num1)
        {
            if(num1[0] == num1[1] && num1[1] == num1[2])
            {
                return true;
            }
            return false;
        }
    }
}
