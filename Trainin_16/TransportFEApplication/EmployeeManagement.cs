using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportBLLibrary;
using TransportDALLibrary;

namespace TransportFEApplication
{
    class EmployeeManagement
    {
        IRepo<Employee> _repo;
        public EmployeeManagement()
        {

        }
        public EmployeeManagement(IRepo<Employee> repo)
        {
            _repo = repo;
        }
        public void CreateEmployee()
        {
            CompleteEmployee employee = new CompleteEmployee();
            employee.TakeEmployeeData();
            try
            {
                if(_repo.Add(employee))
                    Console.WriteLine("Employee created");
                else
                    Console.WriteLine("Sorry could not create employee");

            }
            catch (Exception e)
            {
                Console.WriteLine("Could not add Employee");
                throw e;
            }
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = _repo.GetAll().ToList();
            return employees;
        }
        public void PrintAllEmployee()
        {
            var employees = GetAllEmployees();
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        public List<CompleteEmployee> SortEmployee()
        {
            List<CompleteEmployee> employees = new List<CompleteEmployee>();
            foreach (var item in GetAllEmployees())
            {
                employees.Add(new CompleteEmployee(item));
            }
            return employees;
        }
        public void PrintEmployeesSortedById()
        {
            var employees = SortEmployee();
            employees.Sort();
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        public void ResetPassword()
        {
            Console.WriteLine("Please enter the employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the old password");
            string password = Console.ReadLine();
            Employee employee = GetAllEmployees().Find(e => e.Id == id && e.Password == password);
            try
            {
                if(employee!=null)
                {
                    Console.WriteLine("Please enter the new Password: ");
                    var newPassword = Console.ReadLine();
                    Console.WriteLine("Please retype the new Password");
                    var repeatPassword = Console.ReadLine();
                    if(newPassword==repeatPassword)
                    {
                        employee.Password = newPassword;
                        if(_repo.Update(employee))
                            Console.WriteLine("Password Updated");
                        else
                            Console.WriteLine("Please try again");
                    }
                    else
                        Console.WriteLine("Password MissMatch");
                }
                else
                    Console.WriteLine("Incorrect Username or Password");

            }
            catch (Exception e)
            {
                Console.WriteLine("Could not Update password");
                throw e;
            }
        }
    }
}
