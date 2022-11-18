using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class OrderRepository : Interface.IOrder
    {
        private Database.KitchenFanaticContext Context;

        private OrderRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }

        public void DeleteOrder(Database.Order order)
        {
            throw new NotImplementedException();
        }

        public Database.Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Database.Order order)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Database.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
