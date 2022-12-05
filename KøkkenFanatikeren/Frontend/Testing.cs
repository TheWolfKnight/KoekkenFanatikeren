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
            //List<Func<int, List<Item>>> filterList = new List<Func<int, List<Item>>>();
            //filterList.Add(filterService.SortByColor);
            //filterList.Add(filterService.SortByCategory);
            //filterService.ApplyFilters2(filterList);

            List<Item> itemList = filterService.SortByColor(8);
            itemList = filterService.SortByDimensions(10, 25, 1, 25, 1, 3);
            itemList = filterService.SortByPrice(50, 3000, false);
            itemList = filterService.SortByQuantity(false);
            itemList = filterService.SortByCategory(2);

            foreach (Item iteminlist in itemList)
            {
                Console.WriteLine(iteminlist.ToString());
            }

            //filterService.ApplyFilters();

            Console.WriteLine("FInished");


            FilterService filterService2 = new FilterService();
            itemList = filterService2.SortByColor(8);
            itemList = filterService2.SortByDimensions(10, 25, 1, 25, 1, 3);
            itemList = filterService2.SortByPrice(50, 3000, false);
            itemList = filterService2.SortByQuantity(false);
            itemList = filterService2.SortByCategory(3);

            foreach (Item iteminlist in itemList)
            {
                Console.WriteLine(iteminlist.ToString());
            }


            //List<Item> Sort = filterService.Sort();

            //foreach (Item iteminlist in QuantitySort)
            //{
            //Console.WriteLine(iteminlist.Id.ToString());
            //}

            // Console.WriteLine($"{test.Id}  {test.Name}  {test.Producer}  {test.Quantity}  {test.UnitPrice}");

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
