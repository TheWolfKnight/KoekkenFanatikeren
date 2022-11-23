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

        public Form1 Owner { get; private set; }
        public Handler_CustomerQuestions Handler { get; private set; }
        public List<Src.Models.CustomerQuestion> Answer { get; set; }


        public Form_CustomerQuestions(Form1 owner)
        {
            Owner = owner;
            InitializeComponent();
            Handler = new Handler_CustomerQuestions(this);
        }

        private void Form_CustomerQuestions_Load(object sender, EventArgs e)
        {
            Handler.OnForm_CustomerQuestionsLoadEvent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Handler.OnSubmitButtonClick((MouseEventArgs)e);
        }
    }
}
