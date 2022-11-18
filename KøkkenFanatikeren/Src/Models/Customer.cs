using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Customer
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        /// <summary>
        /// Constructs an empty instance of the Models.Customer class
        /// </summary>
        public Customer() { }

        /// <summary>
        /// Creates a new instance of the Models.Customer with the Id field unfilled. Used when a new Customer is comming to the store
        /// </summary>
        /// <param name="fullName"> The full name of the customer </param>
        /// <param name="phoneNumber"> The phone number of the customer </param>
        /// <param name="email"> The email of the customer </param>
        public Customer(string fullName, string phoneNumber, string email )
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Creates an instance of the Models.Customer class, base upon the data from a Database.Customer class instnace
        /// </summary>
        /// <param name="dbEntry"> The Database.Customer that should become a Models.Customer </param>
        public Customer(Database.Customer dbEntry)
        {
            Id = dbEntry.Id;
            FullName = dbEntry.FullName;
            PhoneNumber = dbEntry.PhoneNumber;
            Email = dbEntry.Email;
        }


        /// <summary>
        /// Converts the Models.Customer class instance to an Database.Customer class instance
        /// </summary>
        /// <returns> An Database.Customer instance with the values of the Models.Customer instance </returns>
        public Database.Customer ConvertToDBEntry()
        {
            // Creates an instance of the Database.Customer class
            Database.Customer result = new Database.Customer();

            // Sets the values for the result
            result.Id = this.Id;
            result.FullName = this.FullName;
            result.PhoneNumber = this.PhoneNumber;
            result.Email = this.Email;

            // Returns the result variable
            return result;
        }


        public override string ToString()
        {
            return $"Customer(Id={Id}, FullName={FullName}, PhoneNumber={PhoneNumber}, Email={Email}";
        }

    }
}
