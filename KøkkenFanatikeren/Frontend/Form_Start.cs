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
        public Src.Models.Employee LoggedInUser { get; set; }
        public Start_Menu()
        {
            InitializeComponent();
            this.LoggedInUser = new Src.Models.Employee();
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
        }

        private void b_OpenDuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open";
            OFD.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
                rtb_YourAssignment.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);
            this.Text = OFD.FileName;
        }

        private void b_CreatNewDoc_Click(object sender, EventArgs e)
        {
            rtb_YourAssignment.Clear();
        }

        private void b_SaveDoc_Click(object sender, EventArgs e)
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Customer", "Server = school-database-server.database.windows.net; database = KitchenFanatic;");
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            dgv_CustomerInfo.DataSource = ds.Tables["Customer"].DefaultView;
        }
        private void b_search_Click(object sender, EventArgs e)
        {
            
        }
    }
}
