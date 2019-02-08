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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account(textBox1.Text, textBox2.Text);
            this.Text = account.Auth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account account = new Account(textBox1.Text, textBox2.Text);
            this.Text = account.Reg();
        }
    }
}