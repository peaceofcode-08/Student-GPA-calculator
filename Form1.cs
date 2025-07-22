namespace StudentGPAcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)

        {

            try
            {
                // Parse grades from the textboxes
                double grade1 = double.Parse(textBox3.Text);
                double grade2 = double.Parse(textBox4.Text);
                double grade3 = double.Parse(textBox5.Text);

                // Calculate average GPA
                double gpa = (grade1 + grade2 + grade3) / 3;

                // Show the result in a message box
                MessageBox.Show("Average GPA: " + gpa.ToString("0.00"), "GPA Result");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric grades.", "Input Error");
            }

            this.button1.Click += new System.EventHandler(this.button1_Click);



        }
    }
}
