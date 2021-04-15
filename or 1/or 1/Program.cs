using System;

namespace or_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("please enter your name");
            // string name = Console.ReadLine();
            //// Console.WriteLine(name);
            // string lastName = Console.ReadLine();
            // //  Console.WriteLine(lastName);
            // char ch = ' ';
            // string add = name + ch + lastName.ToUpper();
            // Console.WriteLine(add);

            //Console.WriteLine("Enter an hour and count the seconds and minutes ");
            //int num = int.Parse(Console.ReadLine());
            //int subtlety = num * 60;
            //int Seconds = num * 3600;
            //Console.WriteLine("hour she : {0} subtlety : {1} Seconds: {2}", num, subtlety, Seconds);

            //Console.WriteLine("Enter a score:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a score:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a score:");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a score:");
            //int num4 = int.Parse(Console.ReadLine());
            //int add = num + num2 + num3 + num4;
            //add /= 4;
            //Console.WriteLine($"The average is : {add}");

            //Console.WriteLine("Insert a string and print the first character:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"The first character is:{name[0]}");

            Console.WriteLine("Enter your year of birth and say your age:");
            int num = 2021;
            int num2 = int.Parse(Console.ReadLine());
            int add = num - num2;
            Console.WriteLine($"Your age is:{add}");
        }

    }
}
