using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0 , sum = 0;
             Console.WriteLine("Enter 4 numbers and print the largest value!");
            int num = Convert.ToInt32(Console.ReadLine());
            sum = num;
            min = num % 10;
            max = num % 10;
            while (sum > 0)
            {
                if (sum % 10 > max)
                {
                    max = sum % 10;
                }
                sum /= 10;
            }
          //  int x = Math.Abs(num);
           // int k = Math.Sqrt(num);
            //Console.WriteLine("this is sqrt {0}", Math.Sqrt(num));
            //Console.WriteLine("this is great{0}", Math.Abs(num));
            Console.WriteLine($"this is max = {max}this is sqrt = {0}this is great = {1}", Math.Sqrt(num), Math.Abs(num));
        }
    }
}
