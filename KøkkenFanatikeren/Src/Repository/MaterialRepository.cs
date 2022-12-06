using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class MaterialRepository : GenericRepository, Interface.IRepository<Database.Material>
    {
        /// <summary>
        /// Creates an instance of the OrderRepository class
        /// </summary>
        /// <param name="context"> The Database context the class instance will use </param>
        public MaterialRepository(Database.KitchenFanaticDataContext ctx) : base(ctx) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Material entry)
        {
            Context.Materials.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Material GetEntryById(int entryId)
        {
            return Context.Materials.Where(item => item.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Material> GetEntrys()
        {
            return Context.Materials;
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Material entry)
        {
            Context.Materials.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Material entry)
        {
            Database.Material dbEntry = GetEntryById(entry.Id);
            dbEntry.Id = entry.Id;
            dbEntry.Name = entry.Name;
        }
    }
}
