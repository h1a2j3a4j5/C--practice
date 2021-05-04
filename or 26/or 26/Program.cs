using System;

namespace or_26
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool chek = false;
            while (chek == false) {
                Console.WriteLine("please enter number:");
                string num = Console.ReadLine();
                if (num[0] == num[3] && num[1] == num[2])
                {
                    chek = true;
                }
                if (chek == true)
                {
                    Console.WriteLine("pilndrom");
                }
                else
                {
                    Console.WriteLine("NOT-pilndrom");
                }
            }

        }
    }
}
