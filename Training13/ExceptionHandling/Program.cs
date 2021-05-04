using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        //ArrayList list = new ArrayList();
       
        List<int> InputUser()
        {
            int number = 0;
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine("Enter negative number to get count");
                
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int res = 10 / number;
                    if (number >= 0)
                    {
                        list.Add(number);
                    }
                    
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine(dbz.Message);
                }

                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                
            } while (number>= 0);
            Console.WriteLine("Count of values " + list.Count);
            if (list.Count == 0)
                list = null;
            return list;
        }
        void SortingList()
        {
            List<int> numbers = InputUser();
            try
            {
              
                if (numbers!=null)
                {
                    numbers.Sort();
                    PrintList(numbers);
                }
                else
                {
                    Console.WriteLine("No values for Numbers");
                }

            }
           
            catch (NullReferenceException Nfe)
            {
                Console.WriteLine(Nfe.Message);
            }

        }

        private void PrintList(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            
        }

        //static void Main(string[] args)
        //{
        //    Program prog = new Program();
        //    prog.SortingList();
        //    Console.ReadKey();
        //}
    }
}
