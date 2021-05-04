using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    class NullOpeartor
    {
        void UnderstandingNull()
        {
            string name = null;
            Console.WriteLine(name);
            int? num1 = 200;
            int num2 = num1 ?? 100;
            Console.WriteLine(num2);
        }
        void CheckBlock()
        {
            int maxi = int.MaxValue;
            checked
            {
                maxi += 10000;
            }
            Console.WriteLine(maxi);
        }
        //public static void Main(string[] args)
        //{
        //    //new NullOpeartor().CheckBlock();
        //    int[] Arr = new int[5];
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Console.WriteLine("Enter the elements");
        //        Arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Your array element");
        //    foreach (var item in Arr)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
    }
}
