/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Item
    {
        public int Id { get; private set; }
        public ItemCategory Category { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }


        /// <summary>
        /// Creates an empty Models.Item class instance
        /// </summary>
        public Item() { }


        /// <summary>
        /// Creates a new Models.Item class instance with all values set
        /// </summary>
        /// <param name="category"> The category to which the item belongs </param>
        /// <param name="name"> The name of the item </param>
        /// <param name="producer"> The manufacturer of the item </param>
        /// <param name="quantity"> How much of the item, the store has in stock </param>
        /// <param name="unitPrice"> The price for each unit of the item purchasted </param>
        public Item( ItemCategory category, string name, string producer, int quantity, double unitPrice )
        {
            Category = category;
            Name = name;
            Producer = producer;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }


        /// <summary>
        /// Creates an instance of the Models.Item class, base upon the data from a Database.Item class instance
        /// </summary>
        /// <param name="dbEntry"> The Database.Item that should become a Models.Item </param>
        public Item(Database.Item dbEntry)
        {
            this.Id = dbEntry.Id;
            this.Name = dbEntry.Name;
            this.Producer = dbEntry.Producer;
            this.Category = new ItemCategory(dbEntry.ItemCategory1);
            this.Quantity = dbEntry.Quantity;
            this.UnitPrice = dbEntry.UnitPrice;
        }


        /// <summary>
        /// Converts the Models.Item class instance to an Database.Item class instance
        /// </summary>
        /// <returns> An Database.Item instance with the values of the Models.Item instance </returns>
        public Database.Item ConvertToDBEntry()
        {
            // Creates a new instance of the Database.Item class
            Database.Item result = new Database.Item();

            // Sets the valuse of the result varible
            result.Id = this.Id;
            result.ItemCategory1 = this.Category.ConvertToDBEntry();
            result.Name = this.Name;
            result.Producer = this.Producer;
            result.Quantity = this.Quantity;
            result.UnitPrice = this.UnitPrice;

            // returns the result varible
            return result;
        }


        public override string ToString()
        {
            return $"Item(Id={Id}, Name={Name}, ItemCategory={Category}, Producer={Producer}, Stock={Quantity}, UnitPrice={UnitPrice})";
        }
    }
}
