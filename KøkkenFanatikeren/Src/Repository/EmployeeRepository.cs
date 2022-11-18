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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void DeleteEmployee(Database.Employee employee)
        {
            Context.Employees.DeleteOnSubmit(employee);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Database.Employee GetEmployeeById(int employeeId)
        {
            return Context.Employees.Where(employee => employee.Id == employeeId).Single();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Database.Employee> GetEmployees()
        {
            return Context.Employees.AsEnumerable();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void InsertEmployee(Database.Employee employee)
        {
            Context.Employees.InsertOnSubmit(employee);
        }


        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            Context.SubmitChanges();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployee(Database.Employee employee)
        {
            Database.Employee dbEntry = Context.Employees.Where(dbInner => dbInner.Id == employee.Id).First();
            dbEntry = employee;
        }
    }
}
