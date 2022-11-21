using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class CustomerRepository : GenericRepository, Interface.IRepository<Database.Customer>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CustomerRepository(Database.KitchenFanaticDataContext context) : base(context) { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Customer entry)
        {
            Context.Customers.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Customer GetEntryById(int entryId)
        {
            return Context.Customers.Where(dbEntry => dbEntry.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Customer> GetEntry()
        {
            return Context.Customers.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Customer entry)
        {
            Context.Customers.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Customer entry)
        {
            Database.Customer dbEntry = Context.Customers.Where(dbInner => dbInner.Id == entry.Id).First();
            dbEntry.FullName = entry.FullName;
            dbEntry.Email = entry.Email;
            dbEntry.PhoneNumber = entry.PhoneNumber;
        }
    }
}
