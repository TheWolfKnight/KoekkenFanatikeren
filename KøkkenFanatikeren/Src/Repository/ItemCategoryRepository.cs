/*
    Skrevet af: Philip Knudsen
*/

using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemCategoryRepository : GenericRepository, Interface.IRepository<Database.ItemCategory>
    {
        /// <summary>
        /// Creates an instance of the ItemCategoryRepository class
        /// </summary>
        /// <param name="context"> The database context </param>
        public ItemCategoryRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.ItemCategory entry)
        {
            Context.ItemCategories.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.ItemCategory GetEntryById(int entryId)
        {
            return Context.ItemCategories.Where(dbEntry => dbEntry.Category == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.ItemCategory> GetEntrys()
        {
            return Context.ItemCategories.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.ItemCategory entry)
        {
            Context.ItemCategories.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.ItemCategory entry)
        {
            Database.ItemCategory dbEntry = Context.ItemCategories.Where(dbInner => dbInner.Category == entry.Category).First();
            dbEntry.Name = entry.Name;
        }
    }
}
