using System;

namespace or_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the largest value:");
            int bigestValue = 0;
            int location = 0;
            for(int i = 1; i < 6; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > bigestValue)
                {
                    bigestValue = num;
                    location = i;
                }
            }
            Console.WriteLine("value bigest is: {0} and His loction: {1}",bigestValue,location);
        }
    }
}
