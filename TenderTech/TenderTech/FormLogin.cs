﻿using System;
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
    public partial class FormLogin : Form
    {
        public Account account;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account = new Account(textBox1.Text, textBox2.Text);
            if (account.Auth() != "Error")
            {
                this.Text = account.Auth();
                clearAll();
                this.Hide();
                new FormMain(account).Show();
            }
            else
            {
                this.Text = account.Auth();
                clearAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void clearAll()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            this.Text = "TenderTech";
        }        
    }
}
