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
    public class Order
    {
        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public int CreatorId { get; private set; }
        public DateTime Creation { get; private set; }
        public DateTime Completion { get; private set; }
        public double TotalPrice { get; set; }
        public OrderStatus Status { get; set; }


        /// <summary>
        /// Creates an empty Order class instance
        /// </summary>
        public Order() { }


        /// <summary>
        /// Creates a Models.Order instance from a Customer Id and a Creator Id
        /// </summary>
        /// <param name="customerId"> The id of the customer, to whom this Order belongs </param>
        /// <param name="creatorId"> The id of the employee who created this order </param>
        public Order(int customerId, int creatorId)
        { 
            CustomerId = customerId;
            CreatorId = creatorId;
            Creation = DateTime.Now;
            TotalPrice = 0.0d;
            Status = OrderStatus.NotStarted;
        }


        /// <summary>
        /// Creates a Models.Order class instance based upon a Database.Order class instance
        /// </summary>
        /// <param name="dbEntry"> The database entry thath will be converted to a Models.Order instance </param>
        public Order(Database.Order dbEntry) {
            this.Id = dbEntry.Id;
            this.CustomerId = dbEntry.CustomerId;
            this.CreatorId = dbEntry.CreatorId;
            this.Creation = dbEntry.Creation;

            if ( dbEntry.Completion.HasValue )
                this.Completion = dbEntry.Completion.Value;

            this.TotalPrice = dbEntry.TotalPrice.GetValueOrDefault(0.0d);
            this.Status = (OrderStatus)dbEntry.Status;
        }


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
            result.Creation = this.Creation;
            result.Completion = this.Completion;
            // The status is cast to an int, as the database does not have an idéer of what an enum is.
            result.Status = (int)this.Status;

            // Returns the result variable
            return result;
        }


        public override string ToString()
        {
            return $"Order(Id={Id}, CreatorId={CreatorId}, CustomerId={CustomerId}, Creation=({Creation:g}), Completion=({Completion:g}), TotalPrice={TotalPrice}, Status={Status})";
        }
    }


    /// <summary>
    /// Describes the status of an order
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// When the order is not started,
        /// Default value for the Status field
        /// </summary>
        NotStarted = 0,
        /// <summary>
        /// When the order is started.
        /// </summary>
        Started = 1,
        /// <summary>
        /// When the order is completed
        /// </summary>
        Done = 2,
        /// <summary>
        /// When the order is cancelled
        /// </summary>
        Cancelled = 3,
    }

}
