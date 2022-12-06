// Af Dannie
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using KøkkenFanatikeren.Src.Services;


namespace KøkkenFanatikeren.Frontend
{
    public partial class Form_Login : Form
    {
        public Src.Models.Employee LoggedInUser { get; set; }
        public Src.Services.LoggingService LoggingService { get; set; }

        
        public Form_Login(Src.Models.Employee loggedInUser)
        {
            InitializeComponent();
            this.LoggedInUser = loggedInUser;
        }
        /// <summary>
        /// empty lable that gets field when incorrect username or password is intered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Login_Load(object sender, EventArgs e)
        {
            lb_errorMessage.Text = "";
        }
       
        /// <summary>
        /// closes the login form if the username and password is correct, if not, sends and error msg to lable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Login_Click(object sender, EventArgs e)
        {
            if (DoLogin())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lb_errorMessage.Text = "Incorrect Username or Password";
            }
        }
       /// <summary>
       /// bool that checks if username and password is correct
       /// </summary>
       /// <returns></returns>
        private bool DoLogin()
        {
            bool result = false;

            if (tb_UserName.Text == KøkkenFanatikeren.Properties.Resources.UserName && tb_Password.Text == KøkkenFanatikeren.Properties.Resources.Password)
            {
                result = true;
            }
            return result;

        }
    }

}
