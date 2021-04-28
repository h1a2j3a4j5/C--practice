using System;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please enter number:");
        
            int sum = 0;
            int counter = 0;
            int km = 0;
            km = int.Parse(Console.ReadLine());
            while (km!=-2)
            {
                sum += km;
                counter++;
                km = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A total of a pound in ten days:{0}", sum);
            Console.WriteLine("Average kilo meters per day:{0}", sum/counter);
        }
    }
}
