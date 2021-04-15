using System;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //(פונקציה שמחזירה ערך (פרמטר

            Console.WriteLine("Enter 4 numbers and print their average:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            double add = multiple(num1, num2, num3, num4);
            Console.WriteLine("result is : {0}", add);

        }
        static double multiple(double one, double two, double tree, double four)
        {

            return (one + two + tree + four) / 4;
        }
    }
}
         //אופציה שנייה לעשות פונקציה עם פרמטר כמעט אותו הדבר 
 //static void Main(string[] args)
//{

//    Console.WriteLine("Enter 4 numbers and print their average:");
//    double num1 = Convert.ToDouble(Console.ReadLine());
//    double num2 = Convert.ToDouble(Console.ReadLine());
//    double num3 = Convert.ToDouble(Console.ReadLine());
//    double num4 = Convert.ToDouble(Console.ReadLine());
//    double add = multiple(num1, num2, num3, num4);
//    Console.WriteLine("result is : {0}", add);

//}
//static double multiple(double num1, double num2, double num3, double num4)
//{

//    return (num1 + num2 + num3 + num4) / 4;
//}
