using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class ItemDimension
    {
        public int ItemId { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Depth { get; private set; }


        /// <summary>
        /// Creates an empty Models.ItemDimension class instance
        /// </summary>
        public ItemDimension() { }


        /// <summary>
        /// Creates a new Models.ItemDimension class instance from the values given by the program
        /// </summary>
        /// <param name="itemId"> The Item to which this Models.ItemDimension class instance belongs </param>
        /// <param name="height"> The given height of the product </param>
        /// <param name="width"> The given width of the product </param>
        /// <param name="depth"> The given depth of the product </param>
        public ItemDimension( int itemId, int height, int width, int depth )
        {
            ItemId = itemId;
            Height = height;
            Width = width;
            Depth = depth;
        }


        /// <summary>
        /// Creates an Models.ItemDimension class instance, with values from an pre-existing Database.ItemDimension class instance
        /// </summary>
        /// <param name="dbEntry"> The Database.ItemDimension to be converted to an Models.ItemDimension </param>
        public ItemDimension( Database.ItemDimension dbEntry )
        {
            this.ItemId = dbEntry.ItemId;
            this.Height = dbEntry.Height;
            this.Width = dbEntry.Width;
            this.Depth = dbEntry.Depth;
        }


        /// <summary>
        /// Converts an existing Models.ItemDimension class instance to an Database.ItemDimension class instance
        /// </summary>
        /// <returns> An new Database.ItemDimension class instance, with the same values as the origional Models.ItemDimension class instance </returns>
        public Database.ItemDimension ConvertToDBEntry()
        {
            // Creates a new Database.ItemDimension class instance
            Database.ItemDimension result = new Database.ItemDimension();

            // Set the result variable to have the Models.ItemDimension instances values
            result.ItemId = this.ItemId;
            result.Height = this.Height;
            result.Width = this.Width;
            result.Depth = this.Depth;

            // Returns the result variable
            return result;
        }
    }
}
