using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class ItemCategoryRepository : Interface.IItemCategory
    {
        private Database.KitchenFanaticContext Context;

        public ItemCategoryRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }

        public void DeleteItemCategory(Database.ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.ItemCategory> GetItemCategories()
        {
            throw new NotImplementedException();
        }

        public Database.ItemCategory GetItemCategoryByCategory(int itemCategory)
        {
            throw new NotImplementedException();
        }

        public void InsertItemCategory(Database.ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateItemCategory(Database.ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }
    }
}
