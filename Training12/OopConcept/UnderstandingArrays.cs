using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    class UnderstandingArrays
    {
        void multiDimensionalArray()
        {
            string[,] strArray = new string[2, 3];
            Console.WriteLine("Enter values for multiDimensional array");
            for (int i = 0; i < 2; i++)
            {
                for (int j= 0; j<3; j++)
                {
                    strArray[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(strArray);
                    Console.WriteLine("||");
                }
            }
        }
        
        //public static void Main(string[] a)
        //{
        //    new UnderstandingArrays().multiDimensionalArray();

        //}
    }
}
