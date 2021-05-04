using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class StackOperations
    {
        Stack<string> polo;
        public StackOperations()
        {
            polo = new Stack<string>();
        }
        
        void pushElements()
        { 
            polo.Push("Red");
            polo.Push("Yellow");
            polo.Push("Green");
            polo.Push("Red");
            polo.Push("Yellow");
            polo.Push("Green");
        }
        void printStack()
        {
            while(polo.Count>0)
            {
                Console.WriteLine(polo.Pop());
            }
        }
        void stackCount()
        {
            Console.WriteLine(polo.Count);
        }
       
        //static void Main(string[] args)
        //{
        //    StackOperations So = new StackOperations();
        //    So.pushElements();
        //    So.printStack();
        //    So.stackCount();
        //    Console.ReadKey();
            
        //}
    }
}
