using System;

namespace or_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("printf number array is from [0] to [9]: ");
            int[] arr = {20 , 3 ,41 ,5,65,70,9, 2 ,4 ,5,6,7,8,34,1};
            bool plus = chek(arr);
            Console.WriteLine(plus);
        }
        static bool chek(int[] arr)
        {
            
            for (int i = 0; i <arr.Length; i++)
            {
                if(arr[i]>=0 && arr[i] <= 9)
                {
                    Console.WriteLine("nubers is from [0] to [9] = {0}", arr[i]);
                    
                }
              
            }
            return true;

        }
    }
}
