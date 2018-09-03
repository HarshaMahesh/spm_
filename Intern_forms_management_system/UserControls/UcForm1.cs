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
using MySql.Data.MySqlClient;

namespace Intern_forms_management_system.UserControls
{
    public partial class UcForm1 : UserControl
    {

        DbOperation dbo=new DbOperation();
        DbConnect db = new DbConnect();

        public UcForm1()
        {
            InitializeComponent();
        }
        public void studentEmpty() {
            stdnametbox.Text ="";
            addresstbox.Text = "";
            mphonetbox.Text = "";
            emailtbox.Text = "";
            hphonetbox.Text = "";
            cgpatbox.Text = "";
            yeartbox.Text = "";
            semtbox.Text = "";
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
            double cgpa = Convert.ToDouble(cgpatbox.Text);
            dbo.addStudentForm1(Sidtxtbox.Text,cgpa, Convert.ToInt32(hphonetbox.Text),semtbox.Text,yeartbox.Text);
            MetroMessageBox.Show(this, "Successfully Inserted", "", MessageBoxButtons.OK);
            studentEmpty();

        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {
            // dbo.searchSudent(Sidtxtbox.Text,snametbox.Text, addresstbox.Text, mphonetbox.Text,semailtbox.Text);
            //MetroMessageBox.Show(this, "Successfully Inserted", "", MessageBoxButtons.OK);
            
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            try
            {
                db.Connection();
                MySqlCommand cmd2;
                MySqlDataReader mdr;

                String quary = "SELECT * FROM `intern_student` where studentId='" + Sidtxtbox.Text + "'";
                cmd2 = new MySqlCommand(quary, db.con);
                db.con.Open();
                mdr = cmd2.ExecuteReader();

                if (mdr.Read())
                {
                    stdnametbox.Text = mdr.GetString("full_name");
                    addresstbox.Text = mdr.GetString("address");
                    mphonetbox.Text = mdr.GetString("telephone");
                    emailtbox.Text = mdr.GetString("email");
                    hphonetbox.Text = mdr.GetString("homePhone");
                    cgpatbox.Text = mdr.GetString("cgpa");
                    yeartbox.Text = mdr.GetString("year");
                    semtbox.Text = mdr.GetString("semester");

                    
                    stdnametbox.Enabled= false;
                    addresstbox.Enabled = false;
                    mphonetbox.Enabled = false; ;
                    emailtbox.Enabled = false; ;
                    stdnametbox.BackColor = System.Drawing.SystemColors.Window;
                    addresstbox.BackColor = System.Drawing.SystemColors.Window;
                    mphonetbox.BackColor = System.Drawing.SystemColors.Window;
                    emailtbox.BackColor = System.Drawing.SystemColors.Window;

                }
                else
                {
                    MetroMessageBox.Show(this, "Searched results are empty", "", MessageBoxButtons.OK);

                }
            }
            catch (Exception e1) {
                Console.Write(e1);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            studentEmpty();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            double cgpa = Convert.ToDouble(cgpatbox.Text);
            dbo.updateStudentForm1(Sidtxtbox.Text,cgpa, Convert.ToInt32(hphonetbox.Text), semtbox.Text, yeartbox.Text);
            MetroMessageBox.Show(this, "Successfully Updated", "", MessageBoxButtons.OK);
        }
    }
}
