using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.UserControls
{
    public partial class ScheduleVivaIM : Form
    {
        DbOperation dbobject = new DbOperation();

        public ScheduleVivaIM()
        {
            InitializeComponent();
        }

        private void RegisterEmployeeForm_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void insertviva_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text=="" || UniversityTextBox.Text=="" || dateTextBox.Text == "" || timeTextBox.Text == "" || StudentIDTextBox.Text == "")
            {
                MessageBox.Show("Please Fill all the fields before inserting.....");
            }
            else
            {
                dbobject.scheduleViva(StudentIDTextBox.Text, NameTextBox.Text, UniversityTextBox.Text);
                MessageBox.Show(this, "Viva Scheduled in the database Successully", "", MessageBoxButtons.OK);
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" ||  UniversityTextBox.Text == "")
            {
                MessageBox.Show("Please Fill all the fields before updating.....");

            }
            else
            {
                dbobject.updateViva(StudentIDTextBox.Text, NameTextBox.Text, UniversityTextBox.Text);


                MessageBox.Show(this, "Successfully Updated", "", MessageBoxButtons.OK);
            }
        }
    }
}
