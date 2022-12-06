// Af Dannie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KøkkenFanatikeren.Src.Services
{ 
    
    public class DGWService
    {
        Repository.OrderRepository RepoDGWOrders { get; set; }
        Repository.CustomerRepository RepoDGWCustomers { get; set; }
        Repository.OrderItemRepository  RepoDGWOrderItems { get; set; }    
        Repository.ItemCategoryRepository RepoDGWItemCat { get; set; }

        /// <summary>
        /// connection between the repositories and the datagridview from form_start
        /// </summary>
        /// <param name="ctx"></param>
        public DGWService(Database.KitchenFanaticDataContext ctx)
        {
            RepoDGWOrders = new Repository.OrderRepository(ctx);
            RepoDGWCustomers = new Repository.CustomerRepository(ctx);
            RepoDGWOrderItems = new Repository.OrderItemRepository(ctx);
            RepoDGWItemCat = new Repository.ItemCategoryRepository(ctx);
            
        }
       
        public List<Models.Order> GetAllOrders()
        {
            return RepoDGWOrders.GetEntrys()
                .Select(dbEntry => new Models.Order(dbEntry))
                .ToList();
        }
        public List<Models.Customer> GetAllCustomers()
        {
            return RepoDGWCustomers
                .GetEntrys()
                .Select(dbEntry => new Models.Customer(dbEntry))
                .ToList();
        }
        public List<Models.OrderItem> GetAllOrderItems()
        {
            return RepoDGWOrderItems
                .GetEntrys()
                .Select(dbEntry => new Models.OrderItem(dbEntry))
                .ToList();
        }

        public List<Models.ItemCategory> GetALlCat()
        {
            return RepoDGWItemCat
                .GetEntrys()
                .Select(dbEntry => new Models.ItemCategory(dbEntry))
                .ToList();
        }

    }
}
