using System;

namespace particle_test_nahat_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter days km:");
            int km = 0;
            int counter = 0;
            int sum = 0;
             for(int i = 1;i<11;i++)
            {
                 km = int.Parse(Console.ReadLine());
                counter++;
                sum += km;           
            }
            Console.WriteLine("rusult is: {0} and avg: {1}", sum, sum / counter);
            Console.WriteLine("The number of days he traveled: {0}", counter);
        }
    }
}
