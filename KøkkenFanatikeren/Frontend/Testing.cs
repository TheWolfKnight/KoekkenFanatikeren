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
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            Src.Database.KitchenFanaticDataContext ctx = new KitchenFanaticDataContext();
            Form_CustomerQuestions cq = new Form_CustomerQuestions(this, ctx);
            cq.ShowDialog();
        }
    }
}
