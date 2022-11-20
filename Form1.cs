namespace Activity6
{

    // Breanna Gernon 
    // CST-150
    // November 19, 2022
    // I used the class textbook to format the results 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double grams;
                double cups;

                grams = double.Parse(gramsBox.Text);

                cups = grams / 250;

                cupsBox.Text = cups.ToString("n3");

            }
            
            catch
            {
                MessageBox.Show("Invalid data was entered. Data must be an integer or a decimal.");
            }
        }
    }
}