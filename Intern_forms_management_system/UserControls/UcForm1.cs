using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Intern_forms_management_system.UserControls
{
    public partial class UcForm1 : UserControl
    {
        DbOperation dbo=new DbOperation();
        public UcForm1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            dbo.addEmployee(Enametbox.Text,Eaddresstbox.Text,snametbox.Text,stitletbox.Text,sphonetbox.Text,semailtbox.Text,esnametbox.Text);
            MetroMessageBox.Show(this, "Successfully Inserted","", MessageBoxButtons.OK);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
