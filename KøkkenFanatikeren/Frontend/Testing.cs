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
using KøkkenFanatikeren.Src.Services;
using Item = KøkkenFanatikeren.Src.Models.Item;

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

            Src.Database.DataClasses1DataContext dbContext = new DataClasses1DataContext();

            //List<Item> Sort = filterService.Sort();

            foreach (Item iteminlist in PriceSort)
            {
                Console.WriteLine(iteminlist.UnitPrice.ToString());
            }

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
