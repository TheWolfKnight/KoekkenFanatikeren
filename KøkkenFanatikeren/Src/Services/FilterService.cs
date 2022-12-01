using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Repository;
using KøkkenFanatikeren.Src.Database;

namespace KøkkenFanatikeren.Src.Repository
{
    public class FilterService
    {
        Database.KitchenFanaticDataContext DBContext { get; set; } = new KitchenFanaticDataContext();
        public List<Models.Item> ItemList { get; set; } = new List<Models.Item>();
        public List<Models.ItemColors> ColorList { get; set; } = new List<Models.ItemColors>();
        public  List<Models.ItemDimension> DimensionList { get; set; } = new List<Models.ItemDimension>();

        /// <summary>
        /// retrieves all items in the database
        /// </summary>
        public List<Models.Item> GetAllItems()
        {

            List<Models.Item> ItemList = new List<Models.Item>();
            
            ItemRepository ItemRepository = new Repository.ItemRepository(DBContext);
            IEnumerable<Database.Item> items = ItemRepository.GetEntrys();

            foreach (Database.Item itemInDB in items)
            {
                Models.Item newItem = new Models.Item(itemInDB);
                ItemList.Add(newItem);
            }

            return ItemList;
        }

        /// <summary>
        /// retrieves all ItemColors in the database
        /// </summary>
        public List<Models.ItemColors> GetItemColors()
        {

            List<Models.ItemColors> ItemColorList = new List<Models.ItemColors>();

            ItemColorRepository ItemColorRepository = new Repository.ItemColorRepository(DBContext);
            IEnumerable<Database.ItemColor> ItemColors = ItemColorRepository.GetEntrys();

            foreach (Database.ItemColor ItemColorInDB in ItemColors)
            {
                Models.ItemColors newItem = new Models.ItemColors(ItemColorInDB);
                ItemColorList.Add(newItem);
            }

            return ItemColorList;
        }

        public List<Models.ItemDimension> GetItemDimensions()
        {

            List<Models.ItemDimension> ItemDimensionList = new List<Models.ItemDimension>();

            ItemDimensionRepository ItemDimensionRepository = new Repository.ItemDimensionRepository(DBContext);
            IEnumerable<Database.ItemDimension> ItemDimensions = ItemDimensionRepository.GetEntrys();

            foreach (Database.ItemDimension ItemDimensionInDB in ItemDimensions)
            {
                Models.ItemDimension newItem = new Models.ItemDimension(ItemDimensionInDB);
                ItemDimensionList.Add(newItem);
            }

            return ItemDimensionList;
        }

        /// <summary>
        /// Sorts all items by the given minimum and maximum price and ordered by ascending bool
        /// </summary>
        /// <param name="min"> Minimum int to search for </param>
        /// <param name="max"> Maximum int to search for </param>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByPrice(int Min, int Max, bool Ascending)
        {

            IEnumerable<Models.Item> items = ItemList.Where(i => i.UnitPrice >= Min
            && i.UnitPrice <= Max).OrderBy(i => i.UnitPrice);

            if (Ascending == false)
            {
                items = ItemList.Where(i => i.UnitPrice >= Min
            && i.UnitPrice <= Max).OrderByDescending(i => i.UnitPrice);
            }


            return items.ToList();
        }

        /// <summary>
        /// Sorts all items by quantitiy in order by given ascending bool
        /// </summary>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByQuantity(bool Ascending)
        {

            IEnumerable<Models.Item> items = ItemList.OrderBy(i => i.Quantity);


            if (Ascending == false)
            {
                items = ItemList.OrderByDescending(i => i.Quantity);
            }

            return items.ToList();

        }

        /// <summary>
        /// Sorts all items by the categoryId, which determines material. 
        /// </summary>
        /// <param name="CategoryId"> Int CategoryId (foreign key) </param>
        public List<Models.Item> SortByCategory(int CategoryId)
        {

            IEnumerable<Models.Item> items = ItemList.Where(i => i.Category.Category == CategoryId);


            return items.ToList();

        }

        /// <summary>
        /// Sorts all items by the ColorId, which determines Color. 
        /// </summary>
        /// <param name="ColorId"> Int ColorId (foreign key) </param>
        public List<Models.Item> SortByColor(int ColorId)
        {
            IEnumerable<Models.Item> items = ItemList.Join(ColorList,
                i => i.Id, //Outer
                c => c.ItemId, //Inner
                (i, c) => new { ITEM = i, COLOR = c }) //Result
                .Where(Parent => Parent.COLOR.ColorId == ColorId) //Match IDs
                .Select(Result => Result.ITEM); //Select only the item

            return items.ToList();

        }

        /// <summary>
        /// Sorts all items by the Dimensions minimum and maximum value of: Height, Width, & Depth.
        /// </summary>
        /// <param name="MinHeight"> Min int of height </param>
        /// <param name="MaxHeight"> Max int of height </param>
        /// <param name="MinWidth"> Min int of Width </param>
        /// <param name="MaxWidth"> Max int of Width </param>
        /// <param name="MinDepth"> Min int of Depth </param>
        /// <param name="MaxDepth"> Min int of Depth </param>
        public List<Models.Item> SortByDimensions(int MinHeight, int MaxHeight, int MinWidth, int MaxWidth, int MinDepth, int MaxDepth)
        {


            IEnumerable<Models.Item> items = ItemList.Join(DimensionList,
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

            return items.ToList();

        }

        /// <summary>
        /// Runs through all filters and returns given value
        /// Add a list or array of params to apply to the filters+++++++++++++
        /// </summary>
        public List<Models.Item> ApplyFilters ()
        {
            //Update complete list values
            ItemList = GetAllItems();
            ColorList = GetItemColors();
            DimensionList = GetItemDimensions();

            //Apply filters
            ItemList = SortByColor(2);
            ItemList = SortByDimensions(1, 30, 1, 40, 1, 40);
            ItemList = SortByQuantity(true);
            ItemList = SortByCategory(3);
            ItemList = SortByPrice(10, 2000, true);

            foreach (Models.Item item in ItemList)
            {
                Console.WriteLine(item.ToString());
            }



            //Returning the filtered list
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
