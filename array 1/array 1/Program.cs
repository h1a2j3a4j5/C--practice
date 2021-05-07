using System;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4] { 4, 6, 2, 1 };
           
            for(int i = 0; i < num.Length-1; i++)
            {
                num[i] = num[i + 1];
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            
        }
    }
}