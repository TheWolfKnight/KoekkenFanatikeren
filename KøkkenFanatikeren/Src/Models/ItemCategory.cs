using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class ItemCategory
    {
        public int Category { get; private set; }
        public string Name { get; set; }


        /// <summary>
        /// Creates an empty Models.ItemCategory class instance
        /// </summary>
        public ItemCategory() { }


        /// <summary>
        /// Creates a new Models.ItemCategory class instance with all values set
        /// </summary>
        /// <param name="name"> The name of the new category </param>
        public ItemCategory(string name)
        {
            Name = name;
        }


        /// <summary>
        /// Creates an instance of the Models.ItemCategory class, base upon the data from a Database.ItemCategory class
        /// </summary>
        /// <param name="dbEntry"> The Database.ItemCategory that should become a Models.ItemCategory </param>
        public ItemCategory( Database.ItemCategory dbEntry )
        {
            this.Category = dbEntry.Category;
            this.Name = dbEntry.Name;
        }


        /// <summary>
        /// Converts the Models.ItemCategory class instance to an Database.ItemCategory class instance
        /// </summary>
        /// <returns> An Database.ItemCategory instance with the values of the Models.ItemCategory instance </returns>
        public Database.ItemCategory ConvertToDBEntry()
        {
            // Creates a new instance of the Database.ItemCategory class
            Database.ItemCategory result = new Database.ItemCategory();

            // Sets the values of the results variable
            result.Category = this.Category;
            result.Name = this.Name;

            // Returns the result variable
            return result;
        }


        public override string ToString()
        {
            return $"ItemCategory(CategoryIndex={Category}, Name={Name})";
        }

    }
}
