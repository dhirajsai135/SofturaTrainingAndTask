using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    
    class BankCustomer
    {
        public ICustomerManager MyManager { get; set; }
        public void visitsBank()
        {
            Console.WriteLine("Hello Manager");

            MyManager.ResolveCustIssue();

        }
       
    }
}
