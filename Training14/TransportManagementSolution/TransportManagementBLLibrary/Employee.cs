using System;
using System.Diagnostics.CodeAnalysis;

namespace TransportManagementBLLibrary
{
    public class Employee:IComparable<Employee>
    {
        const string DEFAULT_PASSWORD = "1234";
        public int Emp_ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Employee()
        {
            Password = DEFAULT_PASSWORD;

        }
        public Employee(int emp_ID, string name, string location, string password, string phone)
        {
            Emp_ID = emp_ID;
            Name = name;
            Location = location;
            Password = DEFAULT_PASSWORD;
            Phone = phone;
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Please Enter the Employee's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Phone Number");
            Phone = Console.ReadLine();
            Console.WriteLine("Please Enter the Employee's Location");
            Location = Console.ReadLine();

        }
        public override string ToString()
        {
            string maskedPassword = GetMaskedPassword(Password);
            return "Employee Name :" + Name + " Phone " + Phone + " Location " + Location + " Password: " + maskedPassword;
        }

        private string GetMaskedPassword(string password)
        {
            string result = password.Substring(0, 2);
            for(int i=2;i<=password.Length;i++)
            {
                result = result + "*";
            }
            return result;
        }

        public int CompareTo([AllowNull] Employee other)
        {
            return this.Location.CompareTo(other.Location);
        }
    }
}
