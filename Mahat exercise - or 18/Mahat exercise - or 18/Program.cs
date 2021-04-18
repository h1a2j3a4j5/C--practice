using System;

namespace Mahat_exercise___or_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out how many kilograms the student walked in ten days and calculated the average of each day:");
            double finish = 0;
            double sum = 0;
            double average = 0;

             for (int day = 1;day<11;day++)
            {
                finish = Convert.ToDouble(Console.ReadLine());
                sum += finish;
                average++;
            }
            Console.WriteLine("The final amount he ran:{0}", sum);
            Console.WriteLine("The average pound per meter per day is:{0}", sum / average);

        }
    }
}
