using System;

namespace lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] num = new int [10];
          
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 1;
                Console.WriteLine(num[i]);
            }


            for (int i = 270; i < num.Length; i++)
            {
               sum += num[i];
                
            }
            Console.Write($"numbers is:{sum}");
        }
    }
}
