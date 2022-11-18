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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ItemRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(Database.Item item)
        {
            Context.Items.DeleteOnSubmit(item);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Database.Item GetItemById(int itemId)
        {
            return Context.Items.Where(dbEntry => dbEntry.Id == itemId).First();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Database.Item> GetItems()
        {
            return Context.Items.AsEnumerable();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void InsertItem(Database.Item item)
        {
            Context.Items.InsertOnSubmit(item);
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
        /// <param name="item"></param>
        public void UpdateItem(Database.Item item)
        {
            Database.Item dbEntry = Context.Items.Where(dbInner => dbInner.Id == item.Id).First();
            dbEntry = item;
        }
    }
}
