using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wealth_Management_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
// this button is for CLIENT

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Client();
            form3.Show();
            this.Hide();
        }

// this button is for PRODUCT

        private void button2_Click(object sender, EventArgs e)
        {
            var product_list = new Form4();
            product_list.Show();
            this.Hide();

        }
    }
}
