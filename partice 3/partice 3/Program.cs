using System;

namespace partice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a price and calculate it after 25 percent off");
            double num = Convert.ToDouble(Console.ReadLine());
            num += num * 18 / 100;
            Console.WriteLine($"new price = {num}");

            string firstName = "yoni";
            string lastName = "hajaj";
            string end = firstName + lastName;
            string add = end.ToUpper();
            Console.WriteLine(add);

            string txt = Convert.ToString(Console.ReadLine());
            Console.WriteLine(txt.Length);
        }
    }
}
