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
    public partial class WhoWants5000Dollars : Form
    {
        public WhoWants5000Dollars()
        {
            InitializeComponent();
        }

        string question;
        string RightAnswer;
        int wrongAnswerCount, RightAnswerCount = 0;
        int questionNumber = 0;

        string btna, btnb, btnc, btnd = "";

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Orange;


            if (btnA.Text == RightAnswer)
            {
                RightAnswerCount++;
                lblTrue.Text = RightAnswerCount.ToString();
            }
            else
            {
                wrongAnswerCount++;
                lblFalse.Text = wrongAnswerCount.ToString();
            }

            btnChanges();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Orange;

            if (btnB.Text == RightAnswer)
            {
                RightAnswerCount++;
                lblTrue.Text = RightAnswerCount.ToString();

            }
            else
            {
                wrongAnswerCount++;
                lblFalse.Text = wrongAnswerCount.ToString();
            }

            btnChanges();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Orange;

            if (btnC.Text == RightAnswer)
            {
                RightAnswerCount++;
                lblTrue.Text = RightAnswerCount.ToString();

            }
            else
            {
                wrongAnswerCount++;
                lblFalse.Text = wrongAnswerCount.ToString();
  
            }

            btnChanges();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Orange;

            if (btnD.Text == RightAnswer)
            {
                RightAnswerCount++;
                lblTrue.Text = RightAnswerCount.ToString();
            }
            else
            {
                wrongAnswerCount++;
                lblFalse.Text = wrongAnswerCount.ToString();        
            }

            btnChanges();
        }

        public void btnChanges()
        {
            if (btnA.Text == RightAnswer)
            {
                btnA.BackColor = Color.Green;
            }
            else if (btnB.Text == RightAnswer)
            {
                btnB.BackColor = Color.Green;
            }
            else if (btnC.Text == RightAnswer)
            {
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Green;
            }

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNextQuestion.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            questionNumber++;

            #region question1
            if (questionNumber == 1)
            {
                question = "Which one of the following is a car name?";
                RightAnswer = "Bugatti";

                rtQuestion.Text = question;

                btnA.Text = "Red";
                btnB.Text = "Yellow";
                btnC.Text = "Agriculture";
                btnD.Text = "Bugatti";
            }
            #endregion

            #region question2
            if (questionNumber == 2)
            {
                question = "Which one of the following is a color name?";
                RightAnswer = "Red";

                rtQuestion.Text = question;

                btnA.Text = "Red";
                btnB.Text = "Ford";
                btnC.Text = "Agriculture";
                btnD.Text = "Bugatti";
            }
            #endregion

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            lblQuestionNumber.Text = Convert.ToString(questionNumber);

            btnNextQuestion.Enabled = false;

        }
    }
}
