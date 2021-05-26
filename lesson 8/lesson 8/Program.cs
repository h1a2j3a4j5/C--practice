using System;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the highest value and its location!");
            double[] num = new double[10] { 13, 24, 12.5, 8, 24, -9, 12, 6, -37, 5 };
            double sum = 0;
            double location = 0;
            
            for(int i = 0; i <num.Length; i++)
            {
                if (num[i] >= sum)
                {
                    sum = num[i];
                }
            }


            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == sum)
                {
                    location = i;
                    break;
                }
            }
            Console.WriteLine("nunber is:{0} location is:{1}", sum, location);

        }
    }
}
