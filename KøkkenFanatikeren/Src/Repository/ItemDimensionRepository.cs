using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemDimensionRepository : GenericRepository, Interface.IRepository<Database.ItemDimension>
    {
        /// <summary>
        /// Creates an instance of the ItemDimensionRepository class
        /// </summary>
        /// <param name="context"> The database context </param>
        public ItemDimensionRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.ItemDimension entry)
        {
            Context.ItemDimensions.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.ItemDimension GetEntryById(int entryId)
        {
            return Context.ItemDimensions.Where(dbEntry => dbEntry.ItemId == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.ItemDimension> GetEntrys()
        {
            return Context.ItemDimensions.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.ItemDimension entry)
        {
            Context.ItemDimensions.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.ItemDimension entry)
        {
            Database.ItemDimension dbEntry = Context.ItemDimensions.Where(dbInner => dbInner.ItemId == entry.ItemId).First();
            dbEntry.Height = entry.Height;
            dbEntry.Width = entry.Width;
            dbEntry.Depth = entry.Depth;
        }
    }
}
