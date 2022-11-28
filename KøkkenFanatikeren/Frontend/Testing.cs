using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Database;
using Item = KøkkenFanatikeren.Src.Models.Item;
using KøkkenFanatikeren.Src.Repository;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
            FilterService filterService = new FilterService();
            List<Item> list = filterService.GetAllItems();
            List<Item> QuantitySort = filterService.SortByQuantity(true);
            List<Item> PriceSort = filterService.SortByPrice(50, 1000, true);
            List<Item> CategorySort = filterService.SortByCategory(2);
            List<Item> ColorSort = filterService.SortByColor(2);
            List<Item> DimensionsSort = filterService.SortByDimensions(1,10,1,10,1,10);

            Src.Database.KitchenFanaticDataContext DBContext = new KitchenFanaticDataContext();

            ItemRepository repo = new ItemRepository(DBContext);
            Item test = new Item(repo.GetEntryById(1423));
            //List<Item> Sort = filterService.Sort();

            foreach (Item iteminlist in DimensionsSort)
            {
                Console.WriteLine(iteminlist.Id.ToString());
            }

            Console.WriteLine($"{test.Id}  {test.Name}  {test.Producer}  {test.Quantity}  {test.UnitPrice}");

            //foreach (int item in DimensionSort)
            //{
            //    MessageBox.Show(item.ToString());
            //}
        }

        private void Testing_Load(object sender, EventArgs e)
        {

        }
    }
}
