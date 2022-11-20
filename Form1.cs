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
            //check if the information in the grams box is a double

            try
            {
                double grams;
                double cups;

                //read the info in the grams box
                grams = double.Parse(gramsBox.Text);

                cups = grams / 250;

                //print result, formatted to three decimals
                cupsBox.Text = cups.ToString("n3");

            }
            
            //throw an error if information is not a double
            catch
            {
                MessageBox.Show("Invalid data was entered. Data must be an integer or a decimal.");
            }
        }
    }
}