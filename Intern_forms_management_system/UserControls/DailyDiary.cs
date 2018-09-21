using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intern_forms_management_system.Diary;

namespace Intern_forms_management_system.UserControls
{
    public partial class DailyDiary : UserControl
    {
        private DiaryEntry entry;
        public DailyDiary()
        {
            InitializeComponent();
            entry = new DiaryEntry();
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
            //Button for inserting an diary entry to Database
            if (entry.saveEntry())
            {
                MessageBox.Show("Diary Entry Success");

            }
            else {
                MessageBox.Show("Diary Entry Unsuccess");
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
