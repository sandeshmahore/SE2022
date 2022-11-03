using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Wealth_Management_Project
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new Main();
            Form2.Show();
            this.Hide();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = Console.ReadLine();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Password = Console.ReadLine();

        }
    }
}
