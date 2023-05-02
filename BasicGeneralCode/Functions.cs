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
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int c = 0 ;
        int d = 0 ;

        private void button1_Click(object sender, EventArgs e)
        {
            f1();
            c = f2();
            d = f3(5);
            f4(2);

            lblSummary.Text = "a:" + a.ToString() + "b:" +  b.ToString() +"c:" + c.ToString() +"d" + d.ToString();
            
        }

        public void f1() //not return and not have parameters
        {
            a = 5;
        }
        public int f2() // have return but not have parameters
        {
            return a + b + 1;
        }
        public int f3(int z) // have return but have parameters
        {
            b = z;
            return b;
        }

        public void f4(int z) // not have return but have parameters
        {
            a = z;
        }

    }
}
