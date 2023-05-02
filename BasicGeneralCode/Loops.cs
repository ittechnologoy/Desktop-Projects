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
    public partial class Loops : Form
    {
        public Loops()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 2 3 4 5

            int i;

            for (i = 0; i < 5; i++)
            {
                MessageBox.Show(i.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1 + 2 + 3 .. + 10

            int totalVal;

            //intellisense - auto completed or code helper

            totalVal = 0;

            for (int i = 1; i <= 10; i++)
            {
                totalVal = totalVal + i;
            }

            MessageBox.Show(totalVal.ToString());
            
            //tab button twice
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1 + 2 + 3 .. + 10

            int totalVal;
            totalVal = 0;
            int sayi;

            sayi = 1;

            while (sayi <= 10)
            {
                totalVal = totalVal + sayi;
                sayi++;
            }

            MessageBox.Show(totalVal.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalVal;
            totalVal = 0;
            int sayi;

            sayi = 1;

            do
            {
                totalVal = totalVal + sayi; //execute just one times if the condition true or false
                sayi++;
            } while (sayi <= 10);

            MessageBox.Show(totalVal.ToString());
        }
    }
}
