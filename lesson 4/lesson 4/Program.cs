using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program that captures the student's shots and prints the student's best result :");
            int num = 1;
            int max = 0;
            int counter = 0;
            
            for (int i = 1; i < 6; i++) 
                {
                    num = int.Parse(Console.ReadLine());
                max = num;
                if (max > num)
                    {
                        max = i;
                    }
                    
                }
                Console.WriteLine("location: {0}", max);
            }
    }
}
