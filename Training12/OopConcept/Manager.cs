using System;
using System.Collections.Generic;
using System.Text;

namespace OopConcept
{
    class Manager :ICustomerManager,IEmployeeManager,IManagerPersonal
    {
        public void Eat()
        {
            Console.WriteLine("Eating......");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping.....");
        }
        public void ConductsMeeting()
        {
            Console.WriteLine("Communicate with employees..");
        }
        public void AproveLoan()
        {
            Console.WriteLine("You have requested for Loan");
        }
        public void ResolveCustIssue()
        {
            Console.WriteLine("Your issue will be solved Don't Worry");
        }


    }
}
