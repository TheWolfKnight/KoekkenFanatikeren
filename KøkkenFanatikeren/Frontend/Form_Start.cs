using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Start_Menu : Form
    {
        public List<Src.Models.Customer> MyCustomer { get; set; }
        public Src.Models.Employee LoggedInUser { get; set; }
        public Src.Database.KitchenFanaticDataContext Context { get; private set; }

        private DataRow SelectedCustomer;

        public Src.Services.LoggingService LoggingService { get; set; }

        public Start_Menu()
        {
            InitializeComponent();
            this.LoggingService = new Src.Services.LoggingService();
            this.LoggedInUser = new Src.Models.Employee();
            Context = new Src.Database.KitchenFanaticDataContext();
        }
        private void ShowLoginBox()
        {
            var Login = new Form_Login(this.LoggedInUser);
            var LoginResult = Login.ShowDialog();
            if(LoginResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Form_Start_Load(object sender, EventArgs e)
        {
            ShowLoginBox();
            UpdateDGVOnUI();
            UpdateCustomerOnUI();
        }

        private void B_OpenDuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open";
            OFD.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                rtb_YourAssignment.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);
            this.Text = OFD.FileName;
        }

        private void B_CreatNewDoc_Click(object sender, EventArgs e)
        {
            rtb_YourAssignment.Clear();
        }

        private void B_SaveDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog OFD = new SaveFileDialog();
            OFD.Title = "Save";
            OFD.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                rtb_YourAssignment.SaveFile(OFD.FileName, RichTextBoxStreamType.PlainText);
            this.Text = OFD.FileName;
        }

        private void UpdateDGVOnUI()
        {
            Src.Repository.CustomerRepository cr = new Src.Repository.CustomerRepository(Context);
            dgv_CustomerInfo.DataSource = cr.GetEntrys();

            Src.Repository.OrderRepository orderRepository = new Src.Repository.OrderRepository(Context);
            dgv_Orders.DataSource = orderRepository.GetEntrys();

            Src.Repository.OrderItemRepository orderItemRepository = new Src.Repository.OrderItemRepository(Context);
            dgv_OrderItem.DataSource = orderItemRepository.GetEntrys();

            Src.Repository.ItemCategoryRepository itemCategoryRepository = new Src.Repository.ItemCategoryRepository(Context);
            dgv_ItemCat.DataSource = itemCategoryRepository.GetEntrys();
        }

        private void B_search_Click(object sender, EventArgs e)
        {
            try
            {
                Src.Repository.CustomerRepository cr = new Src.Repository.CustomerRepository(Context);
                Src.Database.Customer dbEntry = cr.GetEntryById(int.Parse(this.tb_CustomerID.Text));
                this.tb_customerName.Text = dbEntry.FullName;
            }
            catch(Exception ex)
            {
                LoggingService.LogError(ex);
                MessageBox.Show("Your most inter a 4 diget number before search");
            }
        }

        private void OpenEditForm()
        {
            try
            {
                Src.Models.Customer selectedCustomer;

                if (SelectedCustomer != null)
                    selectedCustomer = FromDGRToCustomer(SelectedCustomer);
                else
                    selectedCustomer = LoadCustomerData(int.Parse(tb_CustomerID.Text));

                Form_Edit editCustomerfrm = new Form_Edit(selectedCustomer);
                editCustomerfrm.ShowDialog();
            }
            catch(Exception ex)
            {
                LoggingService.LogError(ex);
                MessageBox.Show("You Most Select a Customer to Edit");
            }
        }
        private void B_EditCustomer_Click(object sender, EventArgs e)
        {
            OpenEditForm();
            UpdateCustomerOnUI();
        }

        private void UpdateCustomerOnUI()
        {
            dgv_CustomerInfo.Refresh();
        }
        private Src.Models.Customer LoadCustomerData(int id)
        {
            var CustomerService = new Src.Services.CustomerService(Context);
            Src.Database.Customer cst = CustomerService.GitCustomerInfo(id);
            return new Src.Models.Customer(cst);
        }

        private Src.Models.Customer FromDGRToCustomer(DataRow customerInfo)
        {
            int customerId = (int)customerInfo[0];
            string customerFullName = (string)customerInfo[1];
            Src.Models.Customer result = new Src.Models.Customer();
            return result;
        }

    }
}
