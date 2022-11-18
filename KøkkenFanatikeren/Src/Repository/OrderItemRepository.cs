using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class OrderItemRepository : Interface.IOrderItem
    {
        private Database.KitchenFanaticContext Context;


        public OrderItemRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }

        public void DeleteOrderItem(Database.OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.OrderItem> GetOrderItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.OrderItem> GetOrderItemsByItemId(int itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public void InsertOrderItem(Database.OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderItem(Database.OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
