using System;
using System.Collections.Generic;
using System.Text;

namespace ObjOProgram
{
    class Phone
    {
        public string Color {get; set; }
        public Phone()
        {
            Console.WriteLine("Consturctor for class Phone");
        }
        public void MethodPublic()
        {
            Console.WriteLine("Public method");
        }
        internal void MethodInternal()
        {
            Console.WriteLine("Internal method");
        }
        private void MethodPrivate()
        {
            Console.WriteLine("Private method");
        }
        protected void MethodProtected()
        {
            Console.WriteLine("Protected method");
        }
    }
}
