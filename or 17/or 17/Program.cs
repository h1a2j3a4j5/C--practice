using System;

namespace or_17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool open = false;
            while (open == false)
            { 
               
            Console.WriteLine("Mailbox Mahat test:");
            int number = int.Parse(Console.ReadLine());
            int unity = number % 10;
            int Dozens = (number / 10) % 10;
            int Hundreds = (number / 100) % 10;

                if (unity == 2)
                {
                    if (Dozens % 2 == 0 && Hundreds % 2 == 0)
                    {
                        if (Dozens > unity)
                        {
                            if (Hundreds == unity + Dozens)
                            {
                                open = true;
                            }

                        }
                    }

                }
                if (open == true)
                {
                    Console.WriteLine("VALID");
                }
                else
                {
                    Console.WriteLine("NOT-VALID Try again");

                }
            }
        }
    }
}
