using System;

namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is a mailbox number valid or not ?");
            int num = int.Parse(Console.ReadLine());
            int unit = num % 10;
            int Dozens = (num /10) %10;
            int Hundreds = (num /100) % 100;
            bool chek = false;
            if (unit % 2 == 0)
            {

                if (Dozens % 2 == 0 && Hundreds % 2 == 0)
                {

                    if (Dozens > unit)
                    {


                        if (Hundreds >= Dozens + unit)
                        {

                            chek = true;
                            
                        } 
                    }
                }
               

            }

            if (chek == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("NOT-valid");
            }
        }
    }
}
