using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat Eat always");
        }
        public void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
        }
        public abstract void Move();      
    }
}
