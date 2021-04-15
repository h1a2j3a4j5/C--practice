using System;

namespace or_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("this is : {0}", sod(a, b));
            
        }
        public static Boolean sod (int a , int b)
        {
            if (a == b +1)
            {
                return true;
            }
            if (b == a +1)
            {
                return true;
            }
            return false;
        }

    }
}
