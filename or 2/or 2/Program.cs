using System;

namespace or_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            Console.WriteLine("Enter the product price:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("And now enter the discount:");
            int discount = int.Parse(Console.ReadLine());
            add = price * discount / 100;
            Console.WriteLine($"this is price after discount: {add}");
            price -= price * discount / 100;
            Console.WriteLine("How much you saved following the discount :{0}",price);

          
        }
    }
}
