using System;

namespace or_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first name :");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("pleae enter spase :");
            string spase = Convert.ToString(Console.ReadLine());
            Console.WriteLine("please enter last name :");
            string name2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("pleae enter spase :");
            string add = names(name, spase, name2);
            Console.WriteLine("my name : {0}", add);
        }
        static string names(string name , string spase , string name2)
        {

            return name + spase + name2; 
        }
    }
}
