using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ColorRepository : GenericRepository, Interface.IRepository<Database.Color>
    {
        /// <summary>
        /// Creates an instance of the ColorRepository class
        /// </summary>
        /// <param name="context"> The database context </param>
        public ColorRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Color entry)
        {
            Context.Colors.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Color GetEntryById(int entryId)
        {
            return Context.Colors.Where(dbEntry => dbEntry.ColorId == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Color> GetEntrys()
        {
            return Context.Colors.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Color entry)
        {
            Context.Colors.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Color entry)
        {
            Database.Color dbEntry = Context.Colors.Where(dbInner => dbInner.ColorId == entry.ColorId).First();
            dbEntry.Name = entry.Name;
        }
    }
}
