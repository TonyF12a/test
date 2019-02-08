using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenderTech
{
    public partial class FormMain : Form
    {
        Account account;

        public FormMain(Account _account)
        {
            InitializeComponent();
            account = _account;
            label1.Text += account.uLogin;
            label2.Text += account.uID;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
