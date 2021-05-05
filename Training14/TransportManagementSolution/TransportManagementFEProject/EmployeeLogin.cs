using System;
using System.Collections.Generic;
using System.Text;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class EmployeeLogin
    {
        ILogin<Employee> repo;
        public EmployeeLogin()
        {
            repo=new EmployeeRepository();
        }
        public void Register()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            repo.Add(employee);
        }
        public void Login()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the UserName");
            employee.Emp_ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the password");
            employee.Password = Console.ReadLine();
            if(repo.login(employee))
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Invalid username and password");
        }
    }
}
