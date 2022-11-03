using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// this is the data for the clients 

namespace Wealth_Management_Project
{
    


    public partial class Client : Form
    {

        int num = 1;

        public Client()
        {
            InitializeComponent();

        }

        private void populateListView()
        {
            // List of all the clients 

            listView1.Items.Add("Sandesh Mahore", 1);
            listView1.Items.Add(" ");
            listView1.Items.Add("Jeff Bezos", 2);
            listView1.Items.Add(" ");
            listView1.Items.Add("Elon Musk", 3);
            listView1.Items.Add(" ");
            listView1.Items.Add("Narayan Murthy", 4);
            listView1.Items.Add(" ");
            listView1.Items.Add("Sundar Pitchai", 5);
            listView1.Items.Add(" ");
            listView1.Items.Add("Mukesh Ambani", 6);
            listView1.Items.Add(" ");
            listView1.Items.Add("Gautam Adani", 7);
            listView1.Items.Add(" ");
            listView1.Items.Add("A.P Hinduja", 8);
            listView1.Items.Add(" ");
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selClient = this.listView1.SelectedItems;

            String clients="";
            foreach (ListViewItem item in selClient)
            {
                clients += (item.SubItems[0].Text);
            }

            Console.WriteLine("you clicked something" + sender.ToString());
            Console.WriteLine("you clicked something" + clients);
            label1.Text = clients;

            if (clients.Equals(" "))
                label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateListView();

        }
    }
}
