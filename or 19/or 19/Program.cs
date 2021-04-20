using System;

namespace or_19
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("please enter a string:");
            string newString = Console.ReadLine();
            reverse(newString);
        }
        static void reverse(string myString) 
        {
            string reversdString = "";
            for(int i = myString.Length - 1; i >= 0; i--)
            {
                reversdString += myString[i];
            }
            Console.Write("Prints the inverted string:{0}", reversdString);
        }
    }
}
