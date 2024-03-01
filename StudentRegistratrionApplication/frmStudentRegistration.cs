using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistratrionApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for(int days = 1; days <= 31; days++)
            {
                dayCombo.Items.Add(days.ToString());
            }

            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                monthCombo.Items.Add(month);
            }

            for (int year = 1900;  year <= 2024; year++)
            {
                yearCombo.Items.Add(year.ToString());
            }

            string[] programList = new string[] {"Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems", "Bachelor of Science in Computer Engineering"};

            foreach(string program in programList)
            {
                listPrograms.Items.Add(program);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string lastName = textBox3.Text;
            string firstName = textBox1.Text;
            string middleName = textBox2.Text;

            string studentName = "Student Name: " +  firstName + " " + middleName + " " + lastName + "\n";
            string gender = "None";

            if (maleRadio.Checked)
            {
                gender = "Gender: " + maleRadio.Text + "\n";
            }
            else if (femaleRadio.Checked)
            {
                gender = femaleRadio.Text + "\n";
            }

            string birthMonth = "Date of Birth: " + dayCombo.Text + "/" + monthCombo.Text + "/" + yearCombo.Text + "\n";
            string programShow = "Program: " + listPrograms.Text;

            MessageBox.Show(studentName + gender + birthMonth + programShow);

        }
    }
}
