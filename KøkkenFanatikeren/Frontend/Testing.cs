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
using System.Diagnostics;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
            FilterService filterService = new FilterService();

            Stopwatch timer = Stopwatch.StartNew();

            List<Item> list = filterService.GetAllItems();
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            Console.WriteLine(String.Format("GetAllItems: {0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));
            timer.Restart();
            List<Item> PriceSort = filterService.SortByPrice(50, 1000, true);
            timer.Stop();
            timespan = timer.Elapsed;
            Console.WriteLine(String.Format("SortByPrice: {0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));

            timer.Restart();
            List<Item> CategorySort = filterService.SortByCategory(2);
            timer.Stop();
            timespan = timer.Elapsed;
            Console.WriteLine(String.Format("SortByCategory: {0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));

            filterService.ApplyFilters();

            Src.Database.KitchenFanaticDataContext DBContext = new KitchenFanaticDataContext();

            ItemRepository repo = new ItemRepository(DBContext);
            Item test = new Item(repo.GetEntryById(1423));
            //List<Item> Sort = filterService.Sort();

            //foreach (Item iteminlist in QuantitySort)
            //{
                //Console.WriteLine(iteminlist.Id.ToString());
            //}

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
