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
using Intern_forms_management_system.UIForms;
using MetroFramework;

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

            entry.setEntry(txtEntry.Text);
            entry.setSid(txtUsername.Text);
            entry.setDate(dateTimePickerDate.Value);
            //Button for inserting an diary entry to Database
            if (entry.entryValidate())
            {

                
                //DiaryEntry diaryEntry = new DiaryEntry();

                entry.saveEntry();
                MessageBox.Show("Diary Entry Success", "Info", MessageBoxButtons.OK);
                //MetroMessageBox.Show(this,"Diary Entry Success","",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Diary Entry UnSuccess", "Error", MessageBoxButtons.OK);
                //MetroMessageBox.Show(this, "Diary Entry UnSuccess", "", MessageBoxButtons.OK);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearEmployee_Click(object sender, EventArgs e)
        {
            txtEntry.Text = "";
            txtUsername.Text = "";
        }
    }
}
