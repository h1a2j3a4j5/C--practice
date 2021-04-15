using System;

namespace or_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int sum = number(num, num2, num3, num4);
            Console.WriteLine($"average he :{sum}");
        }
       static int number (int num ,int num2 , int num3 , int num4)
            {

                return num + num2 +num3 +num4 / 2;
        }
    }
}
