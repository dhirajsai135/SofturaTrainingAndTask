using System;
using System.Collections.Generic;
using System.Text;

namespace ObjOProgram
{
    class Bank
    {
        public void OperatorOverloading()
        {
            Account acc1 = new Account("dheeraj", 13000.00, "12309132");
            Account acc2 = new Account("Krishna", 9000.00, "12301829");
            Account acc3 = acc1 + acc2;
            acc1.printDetails();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%");
            acc2.printDetails();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%");
            acc3.printDetails();
        }
        static void Main(String[] a)
        {
            Bank bank = new Bank();
            bank.OperatorOverloading();
            //string name = Console.ReadLine();
            //double balance = Convert.ToDouble(Console.ReadLine());
            //string accountNumber = Console.ReadLine();
            //Account acc = new Account(name,balance,accountNumber);
            //Account acc1 = new Account("dheeraj", 9000.00, "630128301823");
            ////acc.openAccount();
            ////acc.openAccount("9191919919");
            ////acc.openAccount("9191919919",1234);
            //acc.printDetails();
            //Console.WriteLine("-------------------------------------------------");
            //acc1.printDetails();
        }
    }
}
