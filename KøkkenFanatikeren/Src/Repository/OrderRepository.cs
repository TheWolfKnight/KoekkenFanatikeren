using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class OrderRepository : GenericRepository, Interface.IRepository<Database.Order>
    {
        /// <summary>
        /// Creates an instance of the OrderRepository class
        /// </summary>
        /// <param name="context"> The Database context the class instance will use </param>
        public OrderRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Order entry)
        {
            Context.Orders.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Order GetEntryById(int entryId)
        {
            return Context.Orders.Where(dbEntry => dbEntry.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Order> GetEntry()
        {
            return Context.Orders.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Order entry)
        {
            Context.Orders.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Order entry)
        {
            Database.Order dbEntry = Context.Orders.Where(dbInner => dbInner.Id == entry.Id).First();
            dbEntry.CreatorId = entry.CreatorId;
            dbEntry.CustomerId = entry.CustomerId;
            dbEntry.Status = entry.Status;
            dbEntry.TotalPrice = entry.TotalPrice;
        }
    }
}
