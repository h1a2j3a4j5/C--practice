using System;

namespace or_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            int add = str.Length / 4;


            string new1 = str.Substring(0, add);
            string new2 = str.Substring(add, add * 2);
            string new3 = str.Substring(add * 2, add * 3);
            string new4 = str.Substring(add * 3, add - 1);
            Console.WriteLine($"{new1}{new2}{new3}{new4}");
        }
    }
}
