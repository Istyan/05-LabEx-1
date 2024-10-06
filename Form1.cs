using System;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistrationApplication
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lname = lnameTextBox.Text;
            string fname = fnameTextBox.Text;
            string mname = mnameTextBox.Text;
            string gender = isMale.Checked ? "Male" : isFemale.Checked ? "Female" : "";
            string day = Day.SelectedItem?.ToString();
            string month = Month.SelectedItem?.ToString();
            string year = Year.SelectedItem?.ToString();
            string program = selectProgram.SelectedItem?.ToString();

            StringBuilder registerStudent = new StringBuilder();

            // Display a message if the following required fields is not selected
            if (string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(mname) || string.IsNullOrEmpty(day) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(program))
            {
                MessageBox.Show("Please fill out all required fields (Last Name, First Name, Year of Birth, and Program).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            // Display a message if gender is not selected
            else if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Gender Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }       

            MessageBox.Show("Student name: " + lname + ", " + fname + " " + mname + " \nGender: " + gender + " \nYear of Birth: " + year + "\nChosen Program: " + program);

            MessageBox.Show("Student name: " + lname + "\nChosen Program: " + program);

            MessageBox.Show("Student name: " + fname + " " + lname + "\nChosen Program: " + program);

            lnameTextBox.Focus();
        }
    
        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
