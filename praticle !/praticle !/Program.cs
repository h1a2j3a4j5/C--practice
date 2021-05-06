using System;

namespace praticle__
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"string :{name[0]}");
            Console.WriteLine($": {name.Length}");
            Console.WriteLine($": {name.IndexOf("n")}");

            Console.WriteLine("Enter 2 numbers, multiply and divide them!");
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num * num2;
            int avg = num / num2;
            int plus = num + num2;
            Console.WriteLine($"sum : {sum} avg : {avg} plus : {plus}");

            double sum = 0;
            int counter = 0;
            double num = Convert.ToDouble(Console.ReadLine());
            
            while (num !=-1.0)
            {
                sum += num;
                counter++;
                num /= 10;
                num = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"this is result : {sum/counter}");


            
        }
        
    }
}
