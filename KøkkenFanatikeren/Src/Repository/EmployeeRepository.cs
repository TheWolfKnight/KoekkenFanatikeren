using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class EmployeeRepository : Interface.IEmployee
    {
        private Database.KitchenFanaticContext Context;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EmployeeRepository(Database.KitchenFanaticContext context )
        {
            Context = context;
        }

        public void DeleteEmployee(Database.Employee employee)
        {
            Context.Employees.DeleteOnSubmit(employee);
        }

        public Database.Employee GetEmployeeById(int employeeId)
        {
            return Context.Employees.Where(employee => employee.Id == employeeId).Single();
        }

        public IEnumerable<Database.Employee> GetEmployees()
        {
            return Context.Employees.AsEnumerable();
        }

        public void InsertEmployee(Database.Employee employee)
        {
            Context.Employees.InsertOnSubmit(employee);
        }

        public void Save()
        {
            Context.SubmitChanges();
        }

        public void UpdateEmployee(Database.Employee employee)
        {
            Database.Employee dbEntry = Context.Employees.Where(dbInner => dbInner.Id == employee.Id).First();
            dbEntry = employee;
        }
    }
}
