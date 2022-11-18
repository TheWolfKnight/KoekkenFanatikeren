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
using KøkkenFanatikeren.Src.Services;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Form1 : Form
    {
        public List<TestItem> testList { get; set; }
        public Form1()
        {

            InitializeComponent();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                TestItem testItem = new TestItem(rnd.Next(0, 1000000000), rnd.Next(0, 9), "gj", "fi", rnd.Next(0, 4), rnd.Next(0, 6000)); ;
                testList.Add(testItem);
            }

            List<TestItem> SortedItemsByPrice = new FilterService.SortItemsByPrice(testList);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
