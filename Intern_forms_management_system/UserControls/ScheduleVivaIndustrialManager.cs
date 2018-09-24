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
    public partial class ScheduleVivaIndustrialManager : UserControl
    {
        DbOperation dbobject = new DbOperation();

        public ScheduleVivaIndustrialManager()
        {
            InitializeComponent();
        }

        private void insertviva_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text==""||UniversityTextBox.Text ==""||dateTextBox.Text==""||timeTextBox.Text ==""||StudentIDTextBox.Text=="")
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
            if (NameTextBox.Text == "" || UniversityTextBox.Text == "")
            {
                MessageBox.Show("Please Fill all the fields before updating.....");

            }
            else
            {
                dbobject.updateViva(StudentIDTextBox.Text, NameTextBox.Text, UniversityTextBox.Text);


                MessageBox.Show(this, "Successfully Updated", "", MessageBoxButtons.OK);
            }
        }

        private void StudentIDTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void StudentIDTextBox_Enter(object sender, EventArgs e)
        {
            StudentIDTextBox.Text="";
        }

        private void NameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.Text="";
        }

        private void UniversityTextBox_Enter(object sender, EventArgs e)
        {
            UniversityTextBox.Text = "";

        }

        private void timeTextBox_Enter(object sender, EventArgs e)
        {
            timeTextBox.Text = "";
        }

        private void ScheduleVivaIndustrialManager_Load(object sender, EventArgs e)
        {
            
                try
                {
                    DbOperation dbops = new DbOperation();
                    DataTable dataTabl1 = new DataTable();
                    dataTabl1 = dbops.viewVivaSchedule();
                    //ds = dbops.viewDailyDiary(cmbStdID.SelectedItem.ToString(), dateTimeFrom.Value, dateTimeTo.Value);

                    bunifuCustomDataGrid1.DataSource = dataTabl1;

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            
        }
    }
}
