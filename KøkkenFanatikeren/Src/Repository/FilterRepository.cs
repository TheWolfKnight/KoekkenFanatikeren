﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Database;

namespace KøkkenFanatikeren.Src.Repository
{
    public class FilterRepository
    {
        Database.DataClasses1DataContext DBContext { get; set; } = new DataClasses1DataContext();
        List<Models.Item> ItemList { get; set; } = new List<Models.Item>();

        /// <summary>
        /// Sorts all items by the given minimum and maximum price and ordered by ascending bool
        /// </summary>
        /// <param name="min"> Minimum int to search for </param>
        /// <param name="max"> Maximum int to search for </param>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByPrice(int Min, int Max, bool Ascending)
        {
            IEnumerable<Database.Item> items = DBContext.Items.Where(i => i.UnitPrice >= Min 
            && i.UnitPrice <= Max).OrderBy(i => i.UnitPrice);

            if (Ascending == false)
            {
                items = DBContext.Items.Where(i => i.UnitPrice >= Min
            && i.UnitPrice <= Max).OrderByDescending(i => i.UnitPrice);
            }
           
            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);
                ItemList.Add(newItem);
            }

            return ItemList;
        }

        /// <summary>
        /// retrieves all items in the database
        /// </summary>
        public List<Models.Item> GetAllItems()
        {
            IEnumerable<Database.Item> items = DBContext.Items;

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);
                ItemList.Add(newItem);
            }

            return ItemList;
        }

        /// <summary>
        /// Sorts all items by quantitiy in order by given ascending bool
        /// </summary>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByQuantity(bool Ascending)
        {
            IEnumerable<Database.Item> items = DBContext.Items.OrderBy(i => i.Quantity);

            
            if (Ascending == false)
            {
                items = DBContext.Items.OrderByDescending(i => i.Quantity);
            }
            

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);

                ItemList.Add(newItem);
            }


            return ItemList;

        }

        /// <summary>
        /// Sorts all items by the categoryId, which determines material. 
        /// </summary>
        /// <param name="CategoryId"> Int CategoryId (foreign key) </param>
        public List<Models.Item> SortByCategory(int CategoryId)
        {

            IEnumerable<Database.Item> items = DBContext.Items.Where(i => i.ItemCategory == CategoryId);

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);

                ItemList.Add(newItem);
            }

            return ItemList;

        }






        //var items2 = DBContext.Items.Join(DBContext.ItemCategories,
        //        i => i.ItemCategory,
        //        c => c.Category,
        //        (i, c) => new
        //        {
        //            id = i.Id,
        //            itemc = i.ItemCategory,
        //            category = c.Category,
        //        }).Where(categoryid => categoryid.itemc == CategoryId);


        //public List<Models.ItemCategory> GetCategories()
        //{
        //    Database.DataClasses1DataContext DBContext = new DataClasses1DataContext();

        //    var categories = DBContext.ItemCategories;
        //    var categoriesList = new List<Models.ItemCategory>();

        //    foreach (Database.Item itemInDB in categories)
        //    {
        //        Models.ItemCategory newItem = new Models.ItemCategory(itemInDB);
        //        categoriesList.Add(newItem);
        //    }

        //    return categoriesList;

        //}




    }
}
