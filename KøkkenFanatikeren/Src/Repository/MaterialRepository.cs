using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class MaterialRepository : GenericRepository, Interface.IRepository<Database.Material>
    {

        public MaterialRepository(Database.KitchenFanaticDataContext ctx) : base(ctx) { }

        public void DeleteEntry(Database.Material entry)
        {
            throw new NotImplementedException();
        }

        public Database.Material GetEntryById(int entryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.Material> GetEntrys()
        {
            throw new NotImplementedException();
        }

        public void InsertEntry(Database.Material entry)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(Database.Material entry)
        {
            throw new NotImplementedException();
        }
    }
}
