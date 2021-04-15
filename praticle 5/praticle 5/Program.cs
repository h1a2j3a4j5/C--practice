using System;

namespace praticle_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter string:");
            string name = Console.ReadLine();
            int add = name.Length / 2;
            string len = name.Substring(0 , add);
            Console.WriteLine($"this is string : {len}...");

            Console.WriteLine("Enter 4 characters and it will tell you if it is a philodrome or not");
            string ch = Console.ReadLine();
            if(ch[0] == ch[3] && ch[1] == ch[2])
            {
                Console.WriteLine("pilandrum");
            }
            else
            {
                Console.WriteLine("no pilandrum");
            }


                 bool valid = false;
                 Console.WriteLine("My mailbox number is a three-digit number. The unity digit is 2, all even digits and the tens digit are greater than the unit digit, and the hundreds digit is the sum of the unit digits and another tens digit");
                 while (valid == false)
                  {
                int num = int.Parse(Console.ReadLine());
                int unity = num % 10;
                int tens = (num / 10) % 10;
                int Hundreds = (num / 100) % 10;

                if (unity == 2 )
                {
                     if ((tens % 2 == 0 )&& (Hundreds % 2 == 0))
                     {
                         if (tens > unity)
                     {
                       if (Hundreds == unity + tens)
                         {
                           valid = true;
                            }
                        }
                    }
                }
               if (valid == true)
                 {
                    Console.WriteLine("valid");
                }
                else
                {
                     Console.WriteLine("not - valid - try again");
                 }

            }

            
            

            }
        }
    }
