using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    class Horse : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I am Fast AF Boy");
        }
    }
    class Donkey : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Why I am walking slow?? May be because of Weight on my back");
        }
    }
    class Road
    {
        void AssignAnimal()
        {
            Animal animal = null;
            Console.WriteLine("Choose Either Horse orDonkey");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "Horse":
                    animal = new Horse();
                    break;
                case "Donkey":
                    animal = new Donkey();
                    break;
                default:
                    Console.WriteLine("Invalid Animal");
                        break;
            }
            PullCart(animal);
        }
        void PullCart(Animal animal)
        {
            animal.Eat();
            animal.Move();
            animal.sleep();
        }
       //public static void Main(string[] args)
       // {
       //     new Road().AssignAnimal();

       // }
    }
}
