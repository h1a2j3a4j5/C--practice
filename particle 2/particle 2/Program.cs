using System;

namespace particle_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 4 numbers and print the largest value!");
            int num = int.Parse(Console.ReadLine()); 
            int num2  =  int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int p2 = Math.Max(num,num2);


           Console.WriteLine($"this is num = {p2}");

            string name = "yoni";
            string num5 = name.ToUpper();
            Console.WriteLine($"name = {num5}");

            string pick = "yoni";
            Console.WriteLine(pick.Length);
            Console.WriteLine(pick.Length-1);

        }
    }
}
