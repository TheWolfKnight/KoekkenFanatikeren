using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class Material
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        /// <summary>
        /// Creates an empty instance of the Models.Matreial class
        /// </summary>
        public Material() { }

        /// <summary>
        /// Creates a new Models.Material class instance with a name
        /// </summary>
        /// <param name="name"> The name of the new material </param>
        public Material(string name) => Name = name;

        /// <summary>
        /// Creates an instance of the Models.Material class from an Database.Material class instance
        /// </summary>
        /// <param name="dbEntry"> The instance of the Database.Material class </param>
        public Material(Database.Material dbEntry)
        {
            this.Id = dbEntry.Id;
            this.Name = dbEntry.Name;
        }


        public override string ToString()
        {
            return $"Material(Id={Id}, Name={Name})";
        }

    }
}
