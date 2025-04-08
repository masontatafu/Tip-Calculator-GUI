// Name: Mason Tatafu
// Date: 02/02/24
// Student ID: S2407
// This program displays a Form to the user, which prompts them to enter a price.
// After clicking calculate, text boxes containing 3 different recommended tip prices 
// will populate with the calculated percentages of the user price. 

namespace Lab22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // I am just initializing variables that I am going to use later
            double user_input;
            double tip_min;
            double tip_mid;
            double tip_max;

            // here I am taking the user input and converting it to type: double
            user_input = double.Parse(textBox1.Text);

            // here I am calculating the tip percentages, using the user input
            tip_min = 0.15 * user_input;
            tip_mid = 0.18 * user_input;
            tip_max = 0.20 * user_input;

            // here I am assigning the tip values to their respective text boxes, making sure to convert to string type + currency
            textBox2.Text = tip_min.ToString("C");
            textBox3.Text = tip_mid.ToString("C");
            textBox4.Text = tip_max.ToString("C");
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}