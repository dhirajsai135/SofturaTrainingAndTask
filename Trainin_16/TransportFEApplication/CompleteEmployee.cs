using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TransportDALLibrary;


namespace TransportFEApplication
{
    class CompleteEmployee : Employee, IComparable<Employee>
    {
        const string INITIAL_PASSWORD = "1234";
        public CompleteEmployee()
        {

        }
        public CompleteEmployee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name; 
            this.Password = employee.Password;
            this.Vehicle_id = employee.Vehicle_id;
            this.Phone = employee.Phone;
        }

        public int CompareTo([AllowNull] Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public void TakeEmployeeData()
        {
            Console.WriteLine("Please enter the employee name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Location");
            Location = Console.ReadLine();
            Console.WriteLine("Please enter the employee Phone");
            Phone = Console.ReadLine();
            Password = INITIAL_PASSWORD;
        }
        public override string ToString()
        {
            string MakePassword = GetMaskedPassword(Password);
            return "Id "+Id+" Name "+Name+" Location "+Location+" Phone "+Phone+" Password "+MakePassword;
        }

        public string GetMaskedPassword(string password)
        {
            string result = password.Substring(0, 2);
            for (int i = 2; i < password.Length; i++)
            {
                result += "*";
            }
            return result;
        }
    }
}
