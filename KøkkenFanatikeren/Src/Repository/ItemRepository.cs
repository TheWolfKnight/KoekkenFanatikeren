using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemRepository : GenericRepository, Interface.IRepository<Database.Item>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ItemRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Item entry)
        {
            Context.Items.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Item GetEntryById(int entryId)
        {
            return Context.Items.Where(dbEntry => dbEntry.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Item> GetEntrys()
        {
            return Context.Items.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Item entry)
        {
            Context.Items.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Item entry)
        {
            Database.Item dbEntry = Context.Items.Where(dbInner => dbInner.Id == entry.Id).First();
            dbEntry.ItemCategory = entry.ItemCategory;
            dbEntry.Name = entry.Name;
            dbEntry.Producer = entry.Producer;
            dbEntry.Quantity = entry.Quantity;
            dbEntry.UnitPrice = entry.UnitPrice;
        }
    }
}
