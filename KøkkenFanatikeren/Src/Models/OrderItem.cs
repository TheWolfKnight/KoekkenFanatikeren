using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class OrderItem
    {
        public int OrderId { get; private set; }
        public int ItemId { get; private set; }
        public int Quantity { get; private set; }


        /// <summary>
        /// Creates an empty Models.OrderItem class instance
        /// </summary>
        public OrderItem() { }


        /// <summary>
        /// Creates a new Models.OrderItem class instance from the values given by the program
        /// </summary>
        /// <param name="orderId"> The Order to which this Models.OrderItem class instance belongs </param>
        /// <param name="itemId"> The Item that the Models.OrderItem references to </param>
        /// <param name="quantity"> The amount of the given item that is needed to satisfy the Order </param>
        public OrderItem( int orderId, int itemId, int quantity )
        {
            OrderId = orderId;
            ItemId = itemId;
            Quantity = quantity;
        }


        /// <summary>
        /// Creates an Models.OrderItem class instance, with values from an pre-existing Database.OrderItem class instance
        /// </summary>
        /// <param name="dbEntry"> The Database.OrderItem to be converted to an Models.OrederItem </param>
        public OrderItem( Database.OrderItem dbEntry )
        {
            this.OrderId = dbEntry.OrderId;
            this.ItemId = dbEntry.ItemId;
            this.Quantity = dbEntry.Quantity;
        }


        /// <summary>
        /// Converts an excisting Models.OrderItem class instance to an Database.OrderItem class instance
        /// </summary>
        /// <returns> An new Database.OrderItem class instance, with the same values as the origional Models.OrderItem class instance </returns>
        public Database.OrderItem ConvertToDBEntry()
        {
            // Creates a new Database.OrderItem class instance
            Database.OrderItem result = new Database.OrderItem();

            // Set the result variable to have the Models.OrderItem instances values
            result.OrderId = this.OrderId;
            result.ItemId = this.ItemId;
            result.Quantity = this.Quantity;

            // Returns the result variable
            return result;
        }
    }
}
