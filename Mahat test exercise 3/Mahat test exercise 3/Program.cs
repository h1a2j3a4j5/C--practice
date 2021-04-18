using System;

namespace Mahat_test_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write a program that captures the student's shots and prints the student's best result :");
            double ball = 0;
            double max = 0;
            max = ball;
            for (int num = 1; num < 11; num++){
                ball = Convert.ToDouble(Console.ReadLine());
                if (ball> max)
                {
                    max = ball;
                }
            }
            Console.WriteLine("The best result is:{0}", max);
           
        }
    }
}
