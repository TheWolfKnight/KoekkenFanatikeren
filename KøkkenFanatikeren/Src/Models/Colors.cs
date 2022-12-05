using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Colors
    {
        public int ColorId { get; private set; }
        public string Name { get; private set; }


        /// <summary>
        /// Creates an empty Models.Colors class instance
        /// </summary>
        public Colors() { }


        /// <summary>
        /// Creates a new Models.Colors class instance from the values given by the program
        /// </summary>
        /// <param name="name"> The name of the Models.Colors references to </param>
        public Colors(string name)
        {
            Name = name;
        }


        /// <summary>
        /// Creates an Models.Colors class instance, with values from an pre-existing Database.Colors class instance
        /// </summary>
        /// <param name="dbEntry"> The Database.Colors to be converted to an Models.Colors </param>
        public Colors(Database.Color dbEntry)
        {
            this.ColorId = dbEntry.ColorId;
            this.Name = dbEntry.Name;
        }


        /// <summary>
        /// Converts an existing Models.Colors class instance to an Database.Colors class instance
        /// </summary>
        /// <returns> An new Database.Colors class instance, with the same values as the origional Models.Colors class instance </returns>
        public Database.Color ConvertToDBEntry()
        {
            // Creates a new Database.Colors class instance
            Database.Color result = new Database.Color();

            // Set the result variable to have the Models.Colors instances values
            result.ColorId = this.ColorId;
            result.Name = this.Name;

            // Returns the result variable
            return result;
        }
    }
}
