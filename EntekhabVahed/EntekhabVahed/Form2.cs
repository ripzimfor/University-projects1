﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntekhabVahed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin")
            {
                // مسیر فایل پسورد admin
                string filePass = System.IO.File.ReadAllText(@"C:\202\pass.txt").Trim();

                if (password == filePass)
                {
                    // ورود به فرم اصلی با حالت ادمین
                    Form1 frm = new Form1(true);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("رمز عبور اشتباه است");
                }
            }
            else
            {
                if (username == password) // شرط ورود دانشجو
                {
                    Form1 frm = new Form1(false, username); // false = دانشجو
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
