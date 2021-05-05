using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportManagementBLLibrary
{
   public  class EmployeeRepository : IRepo<Employee>, ILogin<Employee>
    {
        public Dictionary<int, Employee> employees;

        public EmployeeRepository()
        {
            employees = new Dictionary<int, Employee>();
        }

        private int GenerateEmployeeID()
        {
            if (employees.Count == 0)
                return 1;
            List<int> ids = employees.Keys.ToList();
            ids.Sort();
            int id = ids[ids.Count - 1];
            id++;
            return id;
        }
        public void Add(Employee t)
        {
            try
            {
                t.Emp_ID = GenerateEmployeeID();
                employees.Add(t.Emp_ID, t);
            }
            catch(ArgumentException argumentException)
            {
                throw new UnableToAddEmployeeException();

            }
        }

        public Employee Get(int id)
        {
            Employee employee = null;
            try
            {
                employee = employees[id];
            }
            catch(Exception e)
            {
                employee = null;
            }
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            if (employees.Count == 0)
                return null;
            return employees.Values.ToList();
        }

        public bool login(Employee t)
        {
            throw new NotImplementedException();
        }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
