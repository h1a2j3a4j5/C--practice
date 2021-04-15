using System;

namespace hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string num = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine() + Console.ReadLine());
            //int hodi = 2, num = 5;
            //Console.WriteLine(hodi + num);
            //string name =  Console.ReadLine();
            //int age = Convert.ToInt32(Console.Read());
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("new price = {0}",0.75 * num );
            ///Console.WriteLine(Convert.ToInt32(Console.ReadLine()) + int.Parse(Console.ReadLine()));
            //int maam = 18;

            //Console.WriteLine("Enter a number and calculate it after 25% off");
            //int prices =  int.Parse(Console.ReadLine());
            //prices -= prices * 25 / 100;
            //Console.WriteLine($"price after discount = {prices}");

            //Console.WriteLine("Enter a number and calculate it after 25% off");
            //int price = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("price after discount = {0}", 0.75 * price );

            Console.WriteLine("Enter price before VAT and calculate after VAT");
            int price3 = int.Parse(Console.ReadLine());
            price3 += price3 * 18 / 100; 
            Console.WriteLine($"new price = {price3}");
        }
    }
}
