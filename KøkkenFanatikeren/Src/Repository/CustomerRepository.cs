using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class CustomerRepository : RepositoryHandle, Interface.ICustomer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CustomerRepository(Database.KitchenFanaticContext context) : base(context) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public void DeleteCustomer(Database.Customer customer)
        {
            Context.Customers.DeleteOnSubmit(customer);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Database.Customer GetCustomerById(int customerId)
        {
            return Context.Customers.Where(dbEntry => dbEntry.Id == customerId).First();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Database.Customer> GetCustomers()
        {
            return Context.Customers.AsEnumerable();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public void InsertCustomer(Database.Customer customer)
        {
            Context.Customers.InsertOnSubmit(customer);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Database.Customer customer)
        {
            Database.Customer dbEntry = Context.Customers.Where(dbInner => dbInner.Id == customer.Id).First();
            dbEntry = customer;
        }
    }
}
