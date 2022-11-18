using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Models
{
    public class TestItem
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public TestItem(int id, int category, string name, string producer, int quantity, int unitprice)
        {
            this.Id = id;
            this.Category = category;
            this.Name = name;
            this.Producer = producer;
            this.Quantity = quantity;
            this.UnitPrice = unitprice;
        }

    }
}
