using System;

namespace or_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number:");
            string num = Console.ReadLine();
            bool sum = chek(num);
            Console.WriteLine(sum);



        }
        static bool chek(string num )
        {
            
            if(num[0] == num[3] && num[1] == num[2])
            {

                Console.WriteLine("Pilndron");
                return true;
            }
            else
            {
                Console.WriteLine("Not-Pilndron");
            }
            return false;
        }
    }
}
