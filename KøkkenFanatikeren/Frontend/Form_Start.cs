// Af Dannie
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
using KøkkenFanatikeren.Src.Services;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Start_Menu : Form
    {
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
       
        /// <summary>
        /// Opens the form LoginBox, if the username and password is correct, then it closes the form
        /// </summary>
        private void ShowLoginBox()
        {
            var Login = new Form_Login(this.LoggedInUser);
            var LoginResult = Login.ShowDialog();
            if(LoginResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// the first event run when opening the program, starts the form loginbox, loads the datagridview, and refresh the customerUi when editform is closed
        /// </summary>
       private void Form_Start_Load(object sender, EventArgs e)
        {
            ShowLoginBox();
            UpdateDGVOnUI();
            UpdateCustomerOnUI();
        }

        /// <summary>
        /// buttenclik event that sends the event to the handler class, opens save doc
        /// </summary>
       public void B_OpenDuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open";
            OFD.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                rtb_YourAssignment.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);
            this.Text = OFD.FileName;
        }
        /// <summary>
        ///  buttenclik event that sends the event to the handler class, creats new doc
        /// </summary>
        public void B_CreatNewDoc_Click(object sender, EventArgs e)
        {
            rtb_YourAssignment.Clear();
        }

        /// <summary>
        ///  buttenclik event that sends the event to the handler class, saves Doc
        /// </summary>
        public void B_SaveDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog OFD = new SaveFileDialog();
            OFD.Title = "Save";
            OFD.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                rtb_YourAssignment.SaveFile(OFD.FileName, RichTextBoxStreamType.PlainText);
            this.Text = OFD.FileName;
        }
       
        /// <summary>
        /// Loads in the datagridview from the DGWService class
        /// </summary>
        private void UpdateDGVOnUI()
        {
            DGWService dgwService = new DGWService(Context);

            dgv_CustomerInfo.DataSource = dgwService.GetAllCustomers();

            dgv_Orders.DataSource = dgwService.GetAllOrders();

            dgv_OrderItem.DataSource = dgwService.GetAllOrderItems();

            dgv_ItemCat.DataSource = dgwService.GetALlCat();

        }
        
        /// <summary>
        ///  buttenclik event that sends the event to the handler class, searhces the database using the int value from the Costumer ID textbox
        /// </summary>
        public void B_search_Click(object sender, EventArgs e)
        {
            try
            {
                Src.Repository.CustomerRepository cr = new Src.Repository.CustomerRepository(Context);
                Src.Database.Customer dbEntry = cr.GetEntryById(int.Parse(this.tb_CustomerID.Text));
                this.tb_customerName.Text = dbEntry.FullName;
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex);
                MessageBox.Show("Your most inter a 4 diget number before search");
            }
        }
        
        /// <summary>
        ///takes the selected customer from the cusotmer textbox, and puts it in the edit form
        /// </summary>
        public void OpenEditForm()
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
        /// <summary>
        /// opens edit form from the search cusotmer ID, and calls the UpdatecustomerUI
        /// </summary>
        private void B_EditCustomer_Click(object sender, EventArgs e)
        {
            OpenEditForm();
            UpdateCustomerOnUI();
        }

        /// <summary>
        /// refreshes the datagridview
        /// </summary>
        private void UpdateCustomerOnUI()
        {
            dgv_CustomerInfo.Refresh();
        }
        
        /// <summary>
        /// gets custemor info thruw the customer int value ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Src.Models.Customer LoadCustomerData(int id)
        {
            var CustomerService = new Src.Services.CustomerService(Context);
            Src.Database.Customer cst = CustomerService.GitCustomerInfo(id);
            return new Src.Models.Customer(cst);
        }
        
        /// <summary>
        /// puts the selected customer from datagridview into edit form
        /// </summary>
        /// <param name="customerInfo"></param>
        /// <returns></returns>
        private Src.Models.Customer FromDGRToCustomer(DataRow customerInfo)
        {

            int customerId = (int)customerInfo[0];
            string customerFullName = (string)customerInfo[1];
            string customerPhone = (string)customerInfo[2];
            string customerEmail = (string)customerInfo[3];
            Src.Models.Customer result = new Src.Models.Customer(customerId, customerFullName, customerPhone, customerEmail);

            return result;
        }

    }
}
