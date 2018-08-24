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
    public partial class DailyDiary : UserControl
    {
        public DailyDiary()
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
            if (NameTextBox.Text == "" || NameTextBox.Text == "Enter name here....." || UniversityTextBox.Text == "" || AddressTextBox.Text == "" || EmailTextBox.Text == "" || TelephoneTextBox.Text == "" || DepartmentTextBox.Text == "")
            {
                MessageBox.Show("Please Fill all the fields.....");

            }
            else {

            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
