namespace StudentApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtMarksObtained.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            // Convert marks to integer
            int marks = Convert.ToInt32(txtMarksObtained.Text);
            if (marks < 0 || marks > 100)
            {
                MessageBox.Show("Please enter valid marks between 0 and 100.");
                return;
            }

            // Get selected course fee
            int fee = 0;
            switch (cmbCourseName.SelectedItem.ToString())
            {
                case "Computer Science":
                    fee = 50000;
                    break;
                case "Commerce":
                    fee = 60000;
                    break;
                case "Media Studies":
                    fee = 55000;
                    break;
                case "Psychology":
                    fee = 45000;
                    break;
            }

            // Calculate concession
            double concession = 0;
            if (marks >= 90)
                concession = fee * 0.30;
            else if (marks >= 75)
                concession = fee * 0.20;
            else if (marks >= 50)
                concession = fee * 0.10;

            // Calculate final fee
            double finalFee = fee - concession;

            // Display results
            lblBaseFee.Text = "Base Fee: ₹" + fee;
            lblConcession.Text = "Concession: ₹" + concession;
            lblFinalFee.Text = "Final Fee: ₹" + finalFee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
