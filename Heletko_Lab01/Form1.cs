using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heletko_Lab01
{
    public partial class Form1 : Form
    {
        private string login = "Alex";
        private string password = "Heletko";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text == login && passwordTextBox.Text == password)
            {
                statusLabel.BackColor = Color.FromArgb(255, 0, 255, 0);
                MessageBox.Show(String.Format("Welcome back {0}!", login));
            }
            else
            {
                statusLabel.BackColor = Color.FromArgb(255, 255, 0, 0);
                MessageBox.Show("Wrong login or password!");
            }
        }
    }
}
