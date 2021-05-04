using System;

namespace or_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter arrray: ");
            int[] num = new int[5] ;
             
            int sum = 0;
            int location = 0;
            
            for(int i = 0; i < num.Length; i++)
            {
                
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] >= sum)
                {
                    sum = num[i];
                    location = i;
                }
            }
            Console.WriteLine("number bigest at array:{0}", sum);
            Console.WriteLine("location is:{0}",location);
        }
    }
}
