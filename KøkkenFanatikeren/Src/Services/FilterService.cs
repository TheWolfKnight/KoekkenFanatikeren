using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Database;

namespace KøkkenFanatikeren.Src.Repository
{
    public class FilterService
    {
        Database.DataClasses1DataContext DBContext { get; set; } = new DataClasses1DataContext();


        /// <summary>
        /// Sorts all items by the given minimum and maximum price and ordered by ascending bool
        /// </summary>
        /// <param name="min"> Minimum int to search for </param>
        /// <param name="max"> Maximum int to search for </param>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByPrice(int Min, int Max, bool Ascending)
        {
            List<Models.Item> ItemList = new List<Models.Item>();

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

            List<Models.Item> ItemList = new List<Models.Item>();

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
            List<Models.Item> ItemList = new List<Models.Item>();

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
            List<Models.Item> ItemList = new List<Models.Item>();

            IEnumerable<Database.Item> items = DBContext.Items.Where(i => i.ItemCategory == CategoryId);

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);

                ItemList.Add(newItem);
            }

            return ItemList;

        }

        public List<Models.Item> SortByColor(int ColorId)
        {
            List<Models.Item> ItemList = new List<Models.Item>();

            IQueryable<Database.Item> items = DBContext.Items.Join(DBContext.ItemColors,
                i => i.Id, //Outer
                c => c.ItemId, //Inner
                (i, c) => new { ITEM = i, COLOR = c }) //Result
                .Where(Parent => Parent.COLOR.ColorId == ColorId) //Match IDs
                .Select(Result => Result.ITEM); //Select only the item

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);

                ItemList.Add(newItem);
            }

            return ItemList;

        }

        public List<Models.Item> SortByDimensions(int MinHeight, int MaxHeight, int MinWidth, int MaxWidth, int MinDepth, int MaxDepth)
        {
            List<Models.Item> ItemList = new List<Models.Item>();

            IQueryable<Database.Item> items = DBContext.Items.Join(DBContext.ItemDimensions,
                i => i.Id, //Outer
                c => c.ItemId, //Inner
                (i, c) => new { ITEM = i, Dimensions = c }) //Result
                
                //Run through every dimension & check if within range
                .Where(Parent => Parent.Dimensions.Height >= MinHeight
                && Parent.Dimensions.Height <= MaxHeight 
                && Parent.Dimensions.Width >= MinWidth
                && Parent.Dimensions.Width <= MaxWidth
                && Parent.Dimensions.Depth >= MinDepth
                && Parent.Dimensions.Depth <= MaxDepth
                ) 
                .Select(Result => Result.ITEM); //Select only the item

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
