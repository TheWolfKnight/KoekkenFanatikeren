using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KøkkenFanatikeren.Src.Handlers;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Form_CustomerQuestions : Form
    {

        // Skal hede Start_Menu
        public Form WindowOwner { get; private set; }
        public Handler_CustomerQuestions Handler { get; private set; }
        public List<Src.Models.CustomerQuestion> Answer { get; set; }


        public Form_CustomerQuestions(Form owner, Src.Database.KitchenFanaticDataContext ctx)
        {
            WindowOwner = owner;
            InitializeComponent();
            Handler = new Handler_CustomerQuestions(this, ctx);
        }

        private void Form_CustomerQuestions_Load(object sender, EventArgs e)
        {
            Handler.OnForm_CustomerQuestionsLoadEvent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Handler.OnSubmitButtonClickEvent((MouseEventArgs)e);
        }

        private void btn_PrevQuest_Click(object sender, EventArgs e)
        {
            Handler.OnPrevQuestButtonClickEvent((MouseEventArgs)e);
        }
    }
}
