using System;

namespace or_13
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("please enter string and printf first charter:");
          string name = Console.ReadLine();
          string add = first(name);
          Console.WriteLine(" first charter is:{0}", add);
        }
        static string first(string plus)
        {
            
            return plus.Substring(0, 1);
        }
    }
}
