using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public int CreatorId { get; private set; }
        public float TotalPrice { get; private set; }

        public Order() { }

        public Order(int customerId, int creatorId) { }

        public Order(Database.Order dbEntry) { }


        /// <summary>
        /// Converts the instance of the Models.Order class into an instance of the Database.Order class
        /// </summary>
        /// <returns> An instance of the Database.Order class with the relevant data from the Models.Order class instance </returns>
        public Database.Order ConvertToDBEntry()
        {
            // Creates a new instance of the Database.Order class
            Database.Order result = new Database.Order();

            // Sets the relevant fields in the result variable
            result.Id = this.Id;
            result.CreatorId = this.CreatorId;
            result.CustomerId = this.CustomerId;
            result.TotalPrice = this.TotalPrice;

            // Returns the result variable
            return result;
        }

    }
}
