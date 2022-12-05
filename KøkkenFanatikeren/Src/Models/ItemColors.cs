/*
    Skrevet af: Martin Dalgaard
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class ItemColors
    {
        public int ItemId { get; private set; }
        public int ColorId { get; private set; }


        /// <summary>
        /// Creates an empty Models.ItemColors class instance
        /// </summary>
        public ItemColors() { }


        /// <summary>
        /// Creates a new Models.ItemColors class instance from the values given by the program
        /// </summary>
        /// <param name="itemId"> The Item to which this Models.ItemColors class instance belongs </param>
        /// <param name="colorId"> The Color that the Models.ItemColors references to </param>
        public ItemColors(int itemId, int colorId)
        {
            ItemId = itemId;
            ColorId = colorId;
        }


        /// <summary>
        /// Creates an Models.ItemColors class instance, with values from an pre-existing Database.ItemColors class instance
        /// </summary>
        /// <param name="dbEntry"> The Database.ItemColors to be converted to an Models.ItemColors </param>
        public ItemColors( Database.ItemColor dbEntry )
        {
            this.ItemId = dbEntry.ItemId;
            this.ColorId = dbEntry.ColorId;
        }


        /// <summary>
        /// Converts an excisting Models.ItemColors class instance to an Database.ItemColors class instance
        /// </summary>
        /// <returns> An new Database.ItemColors class instance, with the same values as the origional Models.ItemColors class instance </returns>
        public Database.ItemColor ConvertToDBEntry()
        {
            // Creates a new Database.ItemColors class instance
            Database.ItemColor result = new Database.ItemColor();

            // Set the result variable to have the Models.ItemColors instances values
            result.ItemId = this.ItemId;
            result.ColorId = this.ColorId;

            // Returns the result variable
            return result;
        }
    }
}
