using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KøkkenFanatikeren
{
    public partial class Form1 : Form
    {
        public List<Src.Models.CustomerQuestion> Answer { get; set; }

        public Form1()
        {
            InitializeComponent();

            Src.Database.KitchenFanaticDataContext ctx = new Src.Database.KitchenFanaticDataContext();

            Frontend.Form_CustomerQuestions tmp = new Frontend.Form_CustomerQuestions(this, ctx);
            tmp.ShowDialog();
        }
    }
}
