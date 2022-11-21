using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class OrderItemRepository : GenericRepository, Interface.IRepository<Database.OrderItem>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
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
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.OrderItem GetEntryById(int entryId)
        {
            return Context.OrderItems.Where(dbEntry => dbEntry.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.OrderItem> GetEntry()
        {
            return Context.OrderItems.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.OrderItem entry)
        {
            Context.OrderItem.InsertOnSubmit(entry);
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
