using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Database;

namespace KøkkenFanatikeren.Src.Repository
{
    public class Repo
    {
        Database.DataClasses1DataContext DBContext { get; set; } = new DataClasses1DataContext();
        List<Models.Item> ItemList { get; set; } = new List<Models.Item>();

        public List<Models.Item> SortByPrice(int Min, int Max)
        {
            IEnumerable<Database.Item> items = DBContext.Items.Where(i => i.UnitPrice >= Min && i.UnitPrice <= Max);
           
            foreach (var itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);
                ItemList.Add(newItem);
            }

            return ItemList;
        }

        public List<Models.Item> GetAllItems()
        {
            IEnumerable<Database.Item> items = DBContext.Items;

            foreach (var itemInDB in items)
            {
                Models.Item newItem = new Models.Item(new Models.ItemCategory(), itemInDB.Name, itemInDB.Producer, itemInDB.Quantity, itemInDB.UnitPrice);
                ItemList.Add(newItem);
            }

            return ItemList;
        }

        public List<Models.Item> SortByQuantity(bool Ascending)
        {
            IEnumerable<Database.Item> items = DBContext.Items.OrderBy(i => i.Quantity);

            if (Ascending == true)
            {
                items = DBContext.Items.OrderBy(i => i.Quantity);
            }
            else
            {
                items = DBContext.Items.OrderByDescending(i => i.Quantity);
            }

            foreach (var itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);

                ItemList.Add(newItem);
            }


            return ItemList;

        }





        //public List<Models.ItemCategory> GetCategories()
        //{
        //    Database.DataClasses1DataContext DBContext = new DataClasses1DataContext();

        //    var categories = DBContext.ItemCategories;
        //    var categoriesList = new List<Models.ItemCategory>();

        //    foreach (var itemInDB in categories)
        //    {
        //        Models.ItemCategory newItem = new Models.ItemCategory(itemInDB);
        //        categoriesList.Add(newItem);
        //    }

        //    return categoriesList;

        //}




    }
}
