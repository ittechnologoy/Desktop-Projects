namespace BasicGeneralCode
{
    partial class WhoWants5000Dollars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtQuestion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtQuestion
            // 
            this.rtQuestion.Location = new System.Drawing.Point(24, 98);
            this.rtQuestion.Name = "rtQuestion";
            this.rtQuestion.Size = new System.Drawing.Size(636, 120);
            this.rtQuestion.TabIndex = 0;
            this.rtQuestion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Who wants 5000 Dollars";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(24, 235);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(287, 38);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(373, 235);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(287, 38);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(24, 279);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(287, 38);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(373, 279);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(287, 38);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question number:";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(749, 42);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(156, 34);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Right Answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Wrong Answers:";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Location = new System.Drawing.Point(882, 141);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(23, 28);
            this.lblTrue.TabIndex = 10;
            this.lblTrue.Text = "0";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Location = new System.Drawing.Point(882, 178);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(23, 28);
            this.lblFalse.TabIndex = 11;
            this.lblFalse.Text = "0";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(882, 98);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(23, 28);
            this.lblQuestionNumber.TabIndex = 12;
            this.lblQuestionNumber.Text = "0";
            // 
            // WhoWants5000Dollars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(922, 378);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtQuestion);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WhoWants5000Dollars";
            this.Text = "WhoWants5000Dollars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtQuestion;
        private Label label1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label2;
        private Button btnNextQuestion;
        private Label label3;
        private Label label4;
        private Label lblTrue;
        private Label lblFalse;
        private Label lblQuestionNumber;
    }
}