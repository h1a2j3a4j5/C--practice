using System;

namespace or_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a plan that will print the numbers and even numbers and the average:");
            int num = 1;
            int sum = 0;
            int counter = 0;
            int avg = 0;
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                sum++;
                avg+= num;
                if (num % 2 == 0)
                {
                    counter++;
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total numbers received:{0}",sum);
            Console.WriteLine("Total even numbers were recorded:{0}",counter);
            Console.WriteLine("Total even numbers were recorded:{0}",(double)avg/sum);
        }
    }
}
