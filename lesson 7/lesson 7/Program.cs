using System;

namespace lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "erfvc";
            string b = "feaxw";
            string sum = "";

            foreach(var l in a)
            {
               if (b.IndexOf(l)>=0)
               {
                    sum += l;
                }
            }
           //Console.WriteLine(sum);
           // string name = "mishe";
           // int num = name.IndexOf('s');
           // string sum = name.Substring(num);
           // Console.WriteLine(sum);

            //int[] numbers = {-2, 6, 2, 1, 3, 9, -2, 3, 73, 35,6, 55};
            //int num = 6;
            //int first= -1;
            //int last = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(num == numbers[i])
            //    {
            //        first = i;
            //        break;
            //    }

            //}

            //for (int i = numbers.Length-1; i >=0; i--)
            //{
            //    if (num == numbers[i])
            //    {
            //        last = i;
            //        break;
            //    }

            //}
            //if (numbers.Length - last <=first)
            //{
            //    Console.WriteLine("END");
            //}
            //else
            //{
            //    Console.WriteLine("START");
            //}


        }
    }
}
