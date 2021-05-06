using System;
using System.Collections.Generic;
using TransportDALLibrary;
using System.Linq;

namespace TransportBLLibrary
{
    public class EmployeeBl : IRepo<Employee>, IUserLogin<Employee>
    {
        EmployeeDAL dal;
        public EmployeeBl()
        {
            dal = new EmployeeDAL();
        }
        public bool Add(Employee t)
        {
            try
            {
                return dal.AddEmployee(t);

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool AddEmployee(Employee t)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetAll()
        {
            List<Employee> employees;
            try
            {
                employees = dal.SelectAllEmployees().ToList();
                return employees;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Login(Employee t)
        {

            bool result = false;
            try
            {
                List<Employee> employees = GetAll().ToList();
                Employee employee = employees.Find(e => e.Id == t.Id && e.Password == t.Password);
                if (employee != null)
                    result = true;

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Update(Employee t)
        {
            try
            {
                return dal.UpdatePassword(t);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
