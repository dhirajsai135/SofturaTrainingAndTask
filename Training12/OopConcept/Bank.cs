using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    class Bank
    {
        Manager manager;
        public void Routine()
        {
            manager = new Manager();
            BankCustomer customer = new BankCustomer();
            customer.MyManager = manager;
            customer.visitsBank();
        }
        //static void Main(string[] a)
        //{
        //    Bank icici = new Bank();
        //    icici.Routine();

        //}
    }
}
