using System;

namespace or_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            Console.WriteLine("Please enter the range: ");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }

        }
    }
}
