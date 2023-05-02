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
    public partial class DataConversation : Form
    {
        public DataConversation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age;

            int ageInt;

            age = "10";

            ageInt = Convert.ToInt32(age);

            MessageBox.Show(ageInt.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b , total;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            total = a + b;

            lblTotal.Text = total.ToString();

        }
    }
}
