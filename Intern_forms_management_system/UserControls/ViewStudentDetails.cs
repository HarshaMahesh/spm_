using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.UserControls
{
    public partial class ViewStudentDetails : UserControl
    {
        DbOperation dbobject = new DbOperation();

        StudentView student = new StudentView();

        public ViewStudentDetails()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Button for inserting an employee to the Company Database
            if (string.IsNullOrEmpty(StudentIDTextBox.Text))
            {
                MessageBox.Show("Please Fill all the fields.....");

            }
            else
            {
                DataTable dt = student.loadStudentDetails(StudentIDTextBox.Text);
                if ( dt== null)
                {
                    MessageBox.Show(this, "Student does not exist", "", MessageBoxButtons.OK);
                }
                else
                {
                    bunifuCustomDataGrid1.DataSource = dt;
                }
                 //MessageBox.Show(this, "Employee Inserted in to the database Successully", "", MessageBoxButtons.OK);
                
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            //NameTextBox.Text = "Enter Name here ...";
        }

        private void UniversityTextBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void UniversityTextBox_Leave(object sender, EventArgs e)
        {
            //UniversityTextBox.Text = "Enter the University here ...";
        }

        private void AddressTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            //AddressTextBox.Text = "Enter Address here ...";
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            //EmailTextBox.Text = "Enter Email here ...";
        }

        private void TelephoneTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TelephoneTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void DepartmentTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void ClearEmployee_Click(object sender, EventArgs e)
        {
            //Clear the text in text boxes
           
            
        }

        private void StudentIDTextBox_Enter(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = "";
        }
    }
}
