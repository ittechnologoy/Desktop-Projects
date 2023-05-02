using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGeneralCode
{
    public partial class Arrarys : Form
    {
        public Arrarys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] books = { 1 , 2 , 3  }; // datatype [] name = { items }

            MessageBox.Show("First item is " + books[0]);
            MessageBox.Show("Last item is " + books[2]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullname;

            string[] names = { "Ömer", "Yasin" };

            fullname = names[0] + names[1];

            MessageBox.Show(fullname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int totalVal = 0;

            int[] books = { 1, 2, 3 }; // datatype [] name = { items }

            foreach (var item in books)
            {
                totalVal = totalVal + item;
            }

            MessageBox.Show(totalVal.ToString());
        }
    }
}
