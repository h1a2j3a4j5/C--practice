using System;

namespace or_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and print the amount of digits you entered:");
            Console.WriteLine("Also print the first and last digit and whether it is even or odd:");
            int num = 0 , sum  = 0 , min = 0 , max = 0 , counter = 0;
            num = int.Parse(Console.ReadLine());
            sum = num;
            min = num % 10;
            max = num % 10;
            while (sum > 0)
            {
                counter++;
                if (sum % 10 < min)
                {
                    min = sum % 10;
                }
                if (sum % 10 > max)
                {
                    max = sum % 10;
                }
                sum /= 10;
            }
            Console.WriteLine("Number of digits:{0}",counter);
            Console.WriteLine("The small digit:{0}",min);
            Console.WriteLine("The big number:{0}",max);
        }
    }
}
