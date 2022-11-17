using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }

        /// <summary>
        /// Creates a new empty instance of the Models.Employee class
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Creates a new Models.Employee instance with all the data set
        /// </summary>
        /// <param name="id"> The id for the employee </param>
        /// <param name="fullName"> The full name of the employee </param>
        public Employee( int id, string fullName ) { Id = id; FullName = fullName; }

        /// <summary>
        /// Creates a new Models.Employee class instance from a Database.Employee class instance
        /// </summary>
        /// <param name="dbEntry"> The database entry to craete the new employee from </param>
        public Employee( Database.Employee dbEntry )
        {
            Id = dbEntry.Id;
            FullName = dbEntry.FullName;
        }


        /// <summary>
        /// Converts the Models.Employee class instance to a Database.Employee class instance
        /// </summary>
        /// <returns> The new Database.Employee instance with the data from the original Models.Employee class instance </returns>
        public Database.Employee ConvertToDBEntry()
        {
            // Creates an instance of the Database.Employee class
            Database.Employee result = new Database.Employee();

            // Sets the values for the result variable
            result.Id = this.Id;
            result.FullName = this.FullName;

            // Returns the result variable
            return result;
        }

    }
}
