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
    public partial class Register : Form
    {
        public string picurl = "";
        public Account account;

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPic pic = new LoadPic();
            pic.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            account = new Account(textBox1.Text, textBox2.Text);
            this.Text = account.Reg();
            this.Close();
        }
    }
}
