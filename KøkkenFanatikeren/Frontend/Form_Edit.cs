using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Form_Edit : Form
    {
        public Src.Models.Customer MyCustomer { get; set; }
        public Form_Edit(Src.Models.Customer customer)
        {
            InitializeComponent();
            MyCustomer = customer;
        }

        private void Form_EditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            tb_EditCusEmail.Text = MyCustomer.Email;
            tb_EditCusID.Text = MyCustomer.Id.ToString();
            tb_EditCusName.Text = MyCustomer.FullName;
            tb_EditCusPhoneNum.Text = MyCustomer.PhoneNumber;

        }

        private void SaveCustomerData()
        {
            MyCustomer.Email = tb_EditCusEmail.Text;
            MyCustomer.FullName = tb_EditCusName.Text;
            //MyCustomer.PhoneNumber = int.Parse(tb_EditCusPhoneNum.Text);
           //MyCustomer.Id = tb_EditCusID.Text;
        }
        private void SaveExit_Click(object sender, EventArgs e)
        {
            SaveCustomerData();
            this.Close();
        }
    }
}
