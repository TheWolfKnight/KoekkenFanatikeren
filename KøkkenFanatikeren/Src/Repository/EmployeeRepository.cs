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
    public class EmployeeRepository : GenericRepository, Interface.IRepository<Database.Employee>
    {
        /// <summary>
        /// Creates an instance of the EmployeeRepository class
        /// </summary>
        /// <param name="context"> The Database context the class instance will use </param>
        public EmployeeRepository(Database.KitchenFanaticDataContext context) : base(context)  { }


        /// <summary>
        /// Deletes a single entry from the database
        /// </summary>
        /// <param name="entry"> The entry to be deleted from the database </param>
        public void DeleteEntry(Database.Employee entry)
        {
            Context.Employees.DeleteOnSubmit(entry);
        }


        /// <summary>
        /// Returns a entry defined by the entry id
        /// </summary>
        /// <param name="entryId"> The id of the entry to be returned </param>
        /// <returns> Returns a Database.entry instance with the data from the database </returns>
        public Database.Employee GetEntryById(int entryId)
        {
            return Context.Employees.Where(dbEntry => dbEntry.Id == entryId).First();
        }


        /// <summary>
        /// Gets all the entrys in the database as an enumerable
        /// </summary>
        /// <returns> An enumerable of all entrys in the database </returns>
        public IEnumerable<Database.Employee> GetEntrys()
        {
            return Context.Employees.AsEnumerable();
        }


        /// <summary>
        /// Inserts an entry in the database
        /// </summary>
        /// <param name="entry"> The entry to be inserted </param>
        public void InsertEntry(Database.Employee entry)
        {
            Context.Employees.InsertOnSubmit(entry);
        }


        /// <summary>
        /// Updates an entry with new information
        /// </summary>
        /// <param name="entry"> The entry object containg the new information </param>
        public void UpdateEntry(Database.Employee entry)
        {
            Database.Employee dbEntry = Context.Employees.Where(dbInner => dbInner.Id == entry.Id).First();
            dbEntry.FullName = entry.FullName;
        }
    }
}
