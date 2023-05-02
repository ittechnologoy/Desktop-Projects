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
    public partial class SwitchCase : Form
    {
        public SwitchCase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mthNumber;

            mthNumber = Convert.ToInt32(textBox1.Text);

            switch (mthNumber)
            {
                case 1:
                    lblMonthName.Text = "January";
                    break;
                case 2:
                    lblMonthName.Text = "February";
                    break;

                default:
                    lblMonthName.Text = "Not true value";
                    break;
            }



        }
    }
}
