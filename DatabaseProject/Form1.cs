using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textPass.Clear();
            textUser.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text =="User_CEO" && textPass.Text =="Password")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textUser.Text =="User_HR" && textPass.Text =="Password")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textUser.Text =="User_Sales" && textPass.Text =="Password")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password You Have Entered is Invalid");
                textUser.Clear();
                textPass.Clear();
                textUser.Focus();
            }
        }
    }
}
