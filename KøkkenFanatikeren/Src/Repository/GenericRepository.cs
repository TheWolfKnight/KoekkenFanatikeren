/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class GenericRepository
    {
        /// <summary>
        /// The context of the database
        /// </summary>
        internal Database.KitchenFanaticDataContext Context;

        /// <summary>
        /// Constructor for the Generic Repository
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(Database.KitchenFanaticDataContext context) => Context = context;


        /// <summary>
        /// Saves all changes to the repository
        /// </summary>
        public void Save()
        {
            Context.SubmitChanges();
        }

    }
}
