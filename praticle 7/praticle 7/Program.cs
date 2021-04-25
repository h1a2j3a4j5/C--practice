using System;

namespace praticle_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter 3 num:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{name} {name} {name}");
         //   string add = name;
            Console.WriteLine($"{name[0]}");
            string one = name + name + name;
            Console.WriteLine($"{one.Length}");
            
        }
    }
}
