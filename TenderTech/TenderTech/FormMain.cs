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
        private string uID = "";
        private string login = "";
        private string pass = "";

        public FormMain(string _login, string _uID, string _pass)
        {
            InitializeComponent();
            uID = _uID;
            login = _login;
            pass = _pass;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account(textBox1.Text, textBox2.Text);
            account.Delete(this.Text);
        }
    }
}
