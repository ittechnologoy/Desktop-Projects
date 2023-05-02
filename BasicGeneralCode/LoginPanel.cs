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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        bool eyeStatus;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (eyeStatus == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyeStatus = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyeStatus = true;
            }
                
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            eyeStatus = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
