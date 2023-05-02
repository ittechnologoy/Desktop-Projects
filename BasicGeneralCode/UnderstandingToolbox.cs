namespace BasicGeneralCode
{
    public partial class UnderstandingToolbox : Form
    {
        public UnderstandingToolbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ýntellisense 

            

        }

        private void btnGetNames_Click(object sender, EventArgs e)
        {
            lblOurNames.Text = "Sinan Yürekli";
        }

        private void btnGetNamesByTxt_Click(object sender, EventArgs e)
        {
            lblNamesByTxt.Text = txtGetUser.Text;
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstCities.Items.Add(cmbSelecteableCmb.Text);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string nameVal;
            string surnameVal;
            string BirthdayVal;
            string telephoneNumber;
            string IdentityVal;

            string personelInfo;

            nameVal = txtName.Text;
            surnameVal = txtSurname.Text;
            BirthdayVal = dtBirthday.Text;
            telephoneNumber = mskTelephone.Text;
            IdentityVal = mskIdentity.Text;

            personelInfo = "Name: " + nameVal + "Surname: " + surnameVal + "Birthday: " + BirthdayVal +
                "Tel: " + telephoneNumber + "Id: " + IdentityVal;

            lstCities.Items.Add(personelInfo);


        }
    }
}