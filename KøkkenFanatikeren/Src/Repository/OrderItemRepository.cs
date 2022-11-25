using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class OrderItemRepository : GenericRepository, Interface.IRepository<Database.OrderItem>, Interface.IOrderItem
    {
        /// <summary>
        /// Creates an instance of the OrderItemRepository class
        /// </summary>
        /// <param name="context"> The database context </param>
        public OrderItemRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.OrderItem entry)
        {
            Context.OrderItems.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// WARNING: THIS FUNCTION IS NOT TO BE USED WITH ORDERITEM CLASS
        /// </summary>
        /// <param name="entryId"> The id of the order whoes items will be returned to be returned </param>
        /// <returns> THROWS AN ERROR </returns>
        public Database.OrderItem GetEntryById(int entryId)
        {
            throw new InvalidOperationException("Do not use this function. It is only here to satisfy the IRepository interface");
        }


        /// <summary>
        /// Gets the OrderItems related to an Order
        /// </summary>
        /// <param name="orderId"> Id of the order that the items will origniate from </param>
        /// <returns> An enumeable of the items of a given order </returns>
        public IEnumerable<Database.OrderItem> GetItemsByOrderId(int orderId)
        {
            return Context.OrderItems.Where(item => item.OrderId == orderId).AsEnumerable();
        }


        /// <summary>
        /// Gets the OrderItems related to an Item
        /// </summary>
        /// <param name="itemId"> The id of the item whoes orders the function will get </param>
        /// <returns> An enumerable of all the OrderItems with a given Item </returns>
        public IEnumerable<Database.OrderItem> GetItemsByItemId(int itemId)
        {
            return Context.OrderItems.Where(item => item.ItemId == itemId).AsEnumerable();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.OrderItem> GetEntrys()
        {
            return Context.OrderItems.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.OrderItem entry)
        {
            Context.OrderItems.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.OrderItem entry)
        {
            Database.OrderItem dbEntry = Context.OrderItems.Where(dbInner => dbInner.OrderId == entry.OrderId && dbInner.ItemId == entry.ItemId).First();
            dbEntry.Quantity = entry.Quantity;
        }
    }
}
