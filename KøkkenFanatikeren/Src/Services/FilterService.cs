using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class FilterService
    {
        Database.KitchenFanaticDataContext DBContext { get; set; } = new Database.KitchenFanaticDataContext();
        public List<Models.Item> ItemList { get; set; } = new List<Models.Item>();
        public List<Models.ItemColors> ColorList { get; set; } = new List<Models.ItemColors>();
        public List<Models.ItemDimension> DimensionList { get; set; } = new List<Models.ItemDimension>();

        private readonly List<Models.Item> OriginalList = new List<Models.Item>();

        public FilterService ()
        {
            //Update complete list of all values
            ItemList = GetAllItems();
            ColorList = GetItemColors();
            DimensionList = GetItemDimensions();
        }

        /// <summary>
        /// Returns a list of all items in the database
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
        /// Returns a list of all ItemColors in the database
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

        /// <summary>
        /// Returns a list of all ItemDimensions in the database
        /// </summary>
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
        /// <param name="ascending"> Orderby bool </param>
        public List<Models.Item> SortByPrice(int min, int max, bool ascending)
        {

            IEnumerable<Models.Item> items = ItemList
                .Where(i => InRange(Convert.ToInt32(i.UnitPrice), min, max))
                .OrderBy(i => i.UnitPrice);

            if (ascending == false)
            {
                items = ItemList
                .Where(i => InRange(Convert.ToInt32(i.UnitPrice), min, max))
                .OrderByDescending(i => i.UnitPrice);
            }

            //Set new list & return
            ItemList = items.ToList();
            return ItemList;
        }

        /// <summary>
        /// Sorts all items by quantitiy in order by given ascending bool
        /// </summary>
        /// <param name="ascending"> Orderby bool </param>
        public List<Models.Item> SortByQuantity(bool ascending)
        {

            IEnumerable<Models.Item> items = ItemList.OrderBy(i => i.Quantity);

            if (ascending == false)
            {
                items = ItemList.OrderByDescending(i => i.Quantity);
            }

            //Set new list & return
            ItemList = items.ToList();
            return ItemList;

        }

        /// <summary>
        /// Sorts all items by the categoryId, which determines material. 
        /// </summary>
        /// <param name="categoryId"> Int CategoryId (foreign key) </param>
        public List<Models.Item> SortByCategory(int categoryId)
        {

            IEnumerable<Models.Item> items = ItemList.Where(i => i.Category.Category == categoryId);

            //Set new list & return
            ItemList = items.ToList();
            return ItemList;

        }

        /// <summary>
        /// Sorts all items by the ColorId, which determines Color. 
        /// </summary>
        /// <param name="colorId"> Int ColorId (foreign key) </param>
        public List<Models.Item> SortByColor(int colorId)
        {
            IEnumerable<Models.Item> items = ItemList.Join(ColorList,
                i => i.Id, //Outer
                c => c.ItemId, //Inner
                (i, c) => new { ITEM = i, COLOR = c }) //Result
                .Where(Parent => Parent.COLOR.ColorId == colorId) //Match IDs
                .Select(Result => Result.ITEM); //Select only the item

            //Set new list & return
            ItemList = items.ToList();
            return ItemList;

        }

        /// <summary>
        /// Checks if if num is within range of min and max
        /// </summary>
        /// <param name="num"> The int to check </param>
        /// <param name="min"> Minimum int </param>
        /// <param name="max"> Maximum int </param>
        bool InRange(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        /// <summary>
        /// Sorts all items by the Dimensions minimum and maximum value of: Height, Width, & Depth.
        /// </summary>
        /// <param name="minHeight"> Min int of height </param>
        /// <param name="maxHeight"> Max int of height </param>
        /// <param name="minWidth"> Min int of Width </param>
        /// <param name="maxWidth"> Max int of Width </param>
        /// <param name="minDepth"> Min int of Depth </param>
        /// <param name="maxDepth"> Min int of Depth </param>
        public List<Models.Item> SortByDimensions(int minHeight, int maxHeight, int minWidth, int maxWidth, int minDepth, int maxDepth)
        {

            IEnumerable<Models.Item> items = ItemList.Join(DimensionList,
                i => i.Id, //Outer
                c => c.ItemId, //Inner
                (i, c) => new { ITEM = i, Dimensions = c }) //Result

                //Run through every dimension & check if within range
                .Where(Parent => InRange(Parent.Dimensions.Height, minHeight, maxHeight) == true
                && InRange(Parent.Dimensions.Width, minWidth, maxWidth) == true 
                && InRange(Parent.Dimensions.Depth, minDepth, maxDepth) == true)
                .Select(Result => Result.ITEM); //Select only the item

            //Set new list & return
            ItemList = items.ToList();
            return ItemList;

        }

        







        //Old stuff



        //public List<Models.Item> ApplyFilters()
        //{
        //    //Update complete list values'
        //    ItemList = GetAllItems();
        //    ColorList = GetItemColors();
        //    DimensionList = GetItemDimensions();
            
        //    //Apply filters
        //    ItemList = SortByColor(2);
        //    ItemList = SortByDimensions(1, 30, 1, 40, 1, 40);
        //    ItemList = SortByQuantity(true);
        //    ItemList = SortByCategory(3);
        //    ItemList = SortByPrice(10, 2000, true);

        //    foreach (Models.Item item in ItemList)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }



        //    //Returning the filtered list
        //    return ItemList;

        //}

        //public List<Models.Item> ApplyFilters2(List<Func<int, List<Models.Item>>> SortList)
        //{
        //    //Update complete list values'
        //    ItemList = GetAllItems();
        //    ColorList = GetItemColors();
        //    DimensionList = GetItemDimensions();

        //    //Apply filters
        //    foreach (Func<int, List<Models.Item>> func in SortList)
        //        ItemList = func(2);

        //    foreach (Models.Item item in ItemList)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }



        //    //Returning the filtered list
        //    return ItemList;

        //}



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
