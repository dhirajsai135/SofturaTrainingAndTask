using System;
using System.Collections.Generic;
using System.Text;

namespace ObjOProgram
{
    class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public string Type  { get; set; }
        public Account()
        {
            Name = null;
            Balance = 0.0;
            AccountNumber = null;
            Type = null;
        }
        public Account(string name,double balance,string accountNumber)
        {
            Name = name;
            Balance =balance;
            AccountNumber = accountNumber;
        }
        public void printDetails()
        {

            if (Balance >= 10000.00)
            {
                Type = "Business Account";
            }
            else
                Type = "Zero Balance Account";
            Console.WriteLine("Account Number : " + AccountNumber + 
                "\n Name : " + Name + "\n Balance :" + Balance+"\n Type "+Type);
        }

        public static  Account operator +(Account acc1,Account acc2)
        {
            Account result = new Account();
            result.AccountNumber = acc1.AccountNumber + "&" + acc2.AccountNumber;
            result.Balance = acc1.Balance + acc2.Balance;
            result.Name = acc1.Name + "&" + acc2.Name;
            return result;
        }
        public void openAccount()
        {
            Console.WriteLine("Please provide details");
        }
        public void openAccount(string phone)
        {
            Console.WriteLine("Please enter phone number");
            Console.WriteLine("your phone number {0} ",phone);
        }
        public void openAccount(string phone,int otp)
        {
            Console.WriteLine("Please enter phone number and otp");
            Console.WriteLine("your phone number {0} and otp {1}  ", phone,otp);
        }
    }       
}
