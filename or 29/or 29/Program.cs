using System;

namespace or_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char letter = char.Parse(Console.ReadLine());
            int sum = add(name, letter);
            Console.WriteLine(sum);
        }
        static int add (string name , char letter)
        {
            for (int i = 0; i <= name.Length; i++)
            {
                if(name[i] == letter)
                {
                    
                    return i;
                }
            }
            return -1;
        }
    }
}
