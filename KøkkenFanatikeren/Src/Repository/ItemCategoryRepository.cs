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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ItemCategoryRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCategory"></param>
        public void DeleteItemCategory(Database.ItemCategory itemCategory)
        {
            Context.ItemCategories.DeleteOnSubmit(itemCategory);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Database.ItemCategory> GetItemCategories()
        {
            return Context.ItemCategories.AsEnumerable();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCategory"></param>
        /// <returns></returns>
        public Database.ItemCategory GetItemCategoryByCategory(int itemCategory)
        {
            return Context.ItemCategories.Where(dbEntry => dbEntry.Category == itemCategory).First();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCategory"></param>
        public void InsertItemCategory(Database.ItemCategory itemCategory)
        {
            Context.ItemCategories.InsertOnSubmit(itemCategory);
        }


        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            Context.SubmitChanges();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCategory"></param>
        public void UpdateItemCategory(Database.ItemCategory itemCategory)
        {
            Database.ItemCategory dbEntry = Context.ItemCategories.Where(dbInner => dbInner.Category == itemCategory.Category).First();
            dbEntry = itemCategory;
        }
    }
}
