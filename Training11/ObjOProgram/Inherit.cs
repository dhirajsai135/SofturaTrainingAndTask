using System;
using System.Collections.Generic;
using System.Text;

namespace ObjOProgram
{
    class OutputInherit : Inherit
    {
        public OutputInherit()
        {
            details();
            Console.WriteLine("After overriding");
        }
        public override void details()
        {
            name = "Dheeraj";
            Console.WriteLine(name);
            String salary = "90000";
            Console.WriteLine(salary);
        }
    }
    class Inherit
    {
      public string name { set; get; }
      public string salary { set; get; }
        public virtual void details()
        {
            String name = "Dheeraj" ;
            Console.WriteLine(name);
            String salary = "100000";
            Console.WriteLine(salary);
        }
        public Inherit()
        {
            Console.WriteLine("Here are the details of employee>>>>");
        }
    }
}
