using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemColorRepository : GenericRepository, Interface.IRepository<Database.ItemColor>
    {
        /// <summary>
        /// Creates an instance of the ItemColorsRepository class
        /// </summary>
        /// <param name="context"> The database context </param>
        public ItemColorRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.ItemColor entry)
        {
            Context.ItemColors.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.ItemColor GetEntryById(int entryId)
        {
            throw new InvalidOperationException("Do not use this function. It is only here to satisfy the IRepository interface");
        }

        /// <summary>
        /// Gets the ItemColors related to an Item
        /// </summary>
        /// <param name="itemId"> The id of the item of which contains the ColorId </param>
        /// <returns> An enumerable of all the ItemColors with a given Item </returns>
        public IEnumerable<Database.ItemColor> GetColorsByItemId(int itemId)
        {
            return Context.ItemColors.Where(item => item.ItemId == itemId).AsEnumerable();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.ItemColor> GetEntrys()
        {
            return Context.ItemColors.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.ItemColor entry)
        {
            Context.ItemColors.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.ItemColor entry)
        {
            Database.ItemColor dbEntry = Context.ItemColors.Where(dbInner => dbInner.ItemId == entry.ItemId && dbInner.ColorId == entry.ColorId).First();
        }
    }
}
