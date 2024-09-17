namespace Assignment_1
{
    public partial class Form1 : Form
    {
        private const double PAY_PER_HOUR = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            try
            {
                //int.Parse for hours worked in try catch block
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int hoursWorked = int.Parse(txtHoursWorked.Text);
                double total = hoursWorked * PAY_PER_HOUR;

                //Forecolor set to black and define summary
                txtSummary.ForeColor = Color.Black;
                txtSummary.Text = $"{firstName} {lastName} worked {hoursWorked} hours at ${PAY_PER_HOUR:n2} an hour for a total of ${total:n2}";
            }
            catch (FormatException)
            {
                //Set error message to red and define error message
                txtSummary.ForeColor = Color.Red;
                txtSummary.Text = "Invalid hours worked. Please enter a valid number.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //set to clear out input
            txtFirstName.Clear();
            txtLastName.Clear();
            txtHoursWorked.Clear();
            txtSummary.Text = "";
        }

        private void txtSummary_Click(object sender, EventArgs e)
        {

        }

        private void txtHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
