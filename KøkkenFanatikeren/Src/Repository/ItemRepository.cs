using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemRepository : Interface.IItem
    {
        private Database.KitchenFanaticContext Context;

        public ItemRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }

        public void DeleteItem(Database.Item item)
        {
            throw new NotImplementedException();
        }

        public Database.Item GetItemById(int ItemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void InsertItem(Database.Item item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Database.Item item)
        {
            throw new NotImplementedException();
        }
    }
}
