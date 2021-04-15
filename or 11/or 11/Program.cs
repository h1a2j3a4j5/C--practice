using System;

namespace or_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int add;
            Console.WriteLine("please enter price :");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("now enter discuont :");
            int discuont = int.Parse(Console.ReadLine());
            int result = produce(price, discuont ,out add);
            Console.WriteLine("price after discuont : {0}", add);
            Console.WriteLine("The price you saved following the discount: {0}", result);
        }
        static int produce(int price , int discuont , out int add)
        {
             add = price-(price * discuont)/100;
             return (price * discuont)/100;
            

        }
    }
}
