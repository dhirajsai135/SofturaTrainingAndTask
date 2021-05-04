using System;
using System.Linq;
using System.Collections.Generic;
namespace CollectionMovie
{
   public class Program
    {
        List<int> numbers = new List<int>();
        List<int> TakeNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number .Enter a negative number to quit");

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int result = 10 / number;
                    if (number >= 0)
                        numbers.Add(number);
                }
                catch (DivideByZeroException dbz)
                {

                    Console.WriteLine("We can not devide a number by zero");
                    Console.WriteLine(dbz.Message);
                }
                catch (FormatException frm)
                {

                    Console.WriteLine("We are expacting a number");
                    Console.WriteLine(frm.Message);
                }
                catch (OverflowException over)
                {

                    Console.WriteLine("The number is too long");
                    Console.WriteLine(over.Message);
                }

            } while (number >= 0);
            Console.WriteLine("The number of numbers is " + numbers.Count);
            if (numbers.Count == 0)
                numbers = null;
            return numbers;

        }
        private void PrintTheCollection(List<int> myNum)
        {
            if (myNum.Count > 0)
            {
                foreach (var item in myNum)
                {
                    Console.WriteLine(item);
                }
            }

        }
        void SortGivenNum()
        {
            List<int> myNum = TakeNumbersFromUser();
            try
            {
                if (myNum != null)
                {
                    myNum.Sort();
                    PrintTheCollection(myNum);
                }
                else
                {
                    Console.WriteLine("The colletion is empty");
                }
            }
            catch (NullReferenceException nullreference)
            {
                Console.WriteLine(nullreference.Message);
            }
        }
    }
}
