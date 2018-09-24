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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Intern_forms_management_system.UserControls
{
    public partial class UcForm1 : UserControl
    {

        DbOperation dbo=new DbOperation();
        DbConnect db = new DbConnect();
        sendMail mail = new sendMail();

        public UcForm1()
        {
            InitializeComponent();
        }
        public void studentEmpty() {
                     
            hphonetbox.Text = "";
            cgpatbox.Text = "";
            yeartbox.Text = "";
            semtbox.Text = "";
            passwoedtxt.Visible = false;
            passwordbtn.Visible = false;
        }
        public void employeeEmpty()
        {

            Enametbox.Text = "";
            Eaddresstbox.Text = "";
            snametbox.Text = "";
            stitletbox.Text = "";
            sphonetbox.Text = "";
            semailtbox.Text = "";
            esnametbox.Text = "";
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
            if (empagreeBox.Checked == false)
            {
                MetroMessageBox.Show(this, "Please click Agree to confirm this details ", "Message For You", MessageBoxButtons.OK);
            }
            else if (iname.Visible == true || iphone.Visible == true || iemail.Visible == true)
            {
                MetroMessageBox.Show(this, "Please Check Some field(s) is/are not correct", "Message For You", MessageBoxButtons.OK);
                empagreeBox.Checked =false;
            }

            else
            {
                
                    dbo.addEmployee(Enametbox.Text, Eaddresstbox.Text, snametbox.Text, stitletbox.Text, sphonetbox.Text, semailtbox.Text, esnametbox.Text);
                    MetroMessageBox.Show(this, "Successfully Inserted", "", MessageBoxButtons.OK);
                    employeeEmpty();
               
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (stdagreecbox.Checked == false)
            {
                MetroMessageBox.Show(this, "Please click Agree to confirm this details ", "Message For You", MessageBoxButtons.OK);
            }
            else if (ihome.Visible == true || iyear.Visible == true || icgpa.Visible == true)
            {
                MetroMessageBox.Show(this, "Please Check Some field(s) is/are not correct", "Message For You", MessageBoxButtons.OK);
            }
            else if (icgpa.Text=="")
            {
                MetroMessageBox.Show(this, "Please Check Some field(s) is/are Empty", "Message For You", MessageBoxButtons.OK);
            }

            else
            {
                
                dbo.addStudentForm1(Sidtxtbox.Text, cgpatbox.Text, Convert.ToInt32(hphonetbox.Text), semtbox.Text, yeartbox.Text);
                MetroMessageBox.Show(this, "Successfully Inserted", "", MessageBoxButtons.OK);
                studentEmpty();
            }

        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {
           
            
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
                    mphonetbox.Enabled = false; 
                    emailtbox.Enabled = false; 
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

            
            if (MetroMessageBox.Show(this, "Are You Sure", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dbo.updateStudentForm1(Sidtxtbox.Text, cgpatbox.Text, Convert.ToInt32(hphonetbox.Text), semtbox.Text, yeartbox.Text);
                MetroMessageBox.Show(this, "Successfully Updated", "", MessageBoxButtons.OK);
                studentEmpty();
            }
            else {
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {



            if (MetroMessageBox.Show(this, "Are You Sure", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dbo.deleteStudentForm1(Sidtxtbox.Text);
                MetroMessageBox.Show(this, "Successfully Deleted");
            }
            else {
               
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (stdagreecbox.Checked == false)
            {
                MetroMessageBox.Show(this, "Please click Agree to confirm this details ", "Message For You", MessageBoxButtons.OK);
            }

            else
            {
                if (MetroMessageBox.Show(this, "Are You Sure", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dbo.updateEmployee(Enametbox.Text, Eaddresstbox.Text, snametbox.Text, stitletbox.Text, sphonetbox.Text, semailtbox.Text, esnametbox.Text);
                    MetroMessageBox.Show(this, "Successfully Updated");
                    employeeEmpty();
                }
                else
                {

                }
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            try
            {
                db.Connection();
                MySqlCommand cmd;
                MySqlDataReader mdr;
                
                String quary = "SELECT * FROM `employee` where name='" + searchEmployee.Text + "'";
                
                cmd = new MySqlCommand(quary, db.con);
                db.con.Open();
                mdr = cmd.ExecuteReader();
                

                if (mdr.Read())
                {
                    Enametbox.Text = mdr.GetString("name");
                    Eaddresstbox.Text = mdr.GetString("address");
                    
                }
                else
                {
                    MetroMessageBox.Show(this, "Searched results are empty", "", MessageBoxButtons.OK);

                }
            }
            catch (Exception e1)
            {
                Console.Write(e1);
            }
            try
            {

                db.Connection();
                MySqlCommand cmd2;
                MySqlDataReader mdr2;

                String quary2 = "SELECT * FROM `supervisor` where ename='" + searchEmployee.Text + "'";

                cmd2 = new MySqlCommand(quary2, db.con);
                db.con.Open();
                mdr2 = cmd2.ExecuteReader();


                if (mdr2.Read())
                {

                    snametbox.Text = mdr2.GetString("supervisorName");
                    stitletbox.Text = mdr2.GetString("supervisorTitle");
                    sphonetbox.Text = mdr2.GetString("supervisorPhone");
                    semailtbox.Text = mdr2.GetString("supervisorEmail");
                    esnametbox.Text = mdr2.GetString("ExternalSupName");

                }
                else
                {
                    MetroMessageBox.Show(this, "Searched results are empty", "", MessageBoxButtons.OK);

                }
            }

            catch (Exception e1)
            {
                Console.Write(e1);
            }


}

        private void bunifuCustomLabel24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            employeeEmpty();
        }

        private void UcForm1_Load(object sender, EventArgs e)
        {
            stdagreecbox.Checked = false;
            empagreeBox.Checked = false;
            iname.Visible = false;
            ihome.Visible = false;
            iphone.Visible = false;
            iemail.Visible = false;            
            iyear.Visible = false;
            icgpa.Visible = false;
            passwoedtxt.Visible = false;
            passwordbtn.Visible = false;
            sentbt.Visible = false;


        }

        private void stdnametbox_Validated(object sender, EventArgs e)
        {
           
        }

        private void hphonetbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(hphonetbox.Text, @"^[0-9]*$") && hphonetbox.Text.Length == 10 || hphonetbox.Text == "")
            {
                ihome.ForeColor = Color.White;
                hphonetbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                ihome.Visible = false;

            }
            else
            {
                ihome.ForeColor = Color.Red;
                hphonetbox.LineIdleColor = Color.Red;
                ihome.Visible = true;

            }
        }

        private void mphonetbox_Validated(object sender, EventArgs e)
        {
           
        }

        private void emailtbox_Validated(object sender, EventArgs e)
        {
           
        }

        private void yeartbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(yeartbox.Text, @"^[0-9]*$"))
            {
                iyear.ForeColor = Color.White;
                yeartbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                iyear.Visible = false;

            }
            else
            {
                iyear.ForeColor = Color.Red;
                yeartbox.LineIdleColor = Color.Red;
                iyear.Visible = true;

            }
        }

        private void SidePanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cgpatbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cgpatbox.Text, @"-?\d+(?:\.\d+)?") || cgpatbox.Text == "")
            {
                icgpa.ForeColor = Color.White;
                cgpatbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                icgpa.Visible = false;

            }
            else
            {
                icgpa.ForeColor = Color.Red;
                cgpatbox.LineIdleColor = Color.Red;
                icgpa.Visible = true;

            }
        }

        private void Enametbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Enametbox.Text, @"^[a-zA-Z' '.]+$") || Enametbox.Text == "")
            {

                Enametbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                iname.Visible = false;

            }
            else
            {

                Enametbox.LineIdleColor = Color.Red;
                iname.Visible = true;

            }
        }

        private void snametbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(snametbox.Text, @"^[a-zA-Z' '.]+$") || snametbox.Text == "")
            {
                iphone.ForeColor = Color.White;
                snametbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                iphone.Visible = false;

            }
            else
            {
                iphone.ForeColor = Color.Red;
                snametbox.LineIdleColor = Color.Red;
                iphone.Visible = true;

            }
        }

        private void semailtbox_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(semailtbox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,5})+)$") || semailtbox.Text == "")
            {
                iemail.ForeColor = Color.White;
                semailtbox.LineIdleColor = System.Drawing.Color.FromArgb(84, 110, 122);
                iemail.Visible = false;


            }
            else
            {

                iemail.ForeColor = Color.Red;
                semailtbox.LineIdleColor = Color.Red;
                iemail.Visible = true;


            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            //bunifuFlatButton1.Visible = false;
            passwordbtn.Visible = true;
            passwoedtxt.Visible = true;
            sentbt.Visible = true;

            
        }

        private void sentbt_Click(object sender, EventArgs e)
        {
         //   mail.sendmail(emailtbox.Text,passwoedtxt.Text,"harshamahesh141@gmail.com");

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.EnableSsl = true;
                SmtpServer.Credentials = new NetworkCredential(emailtbox.Text, passwoedtxt.Text);
                SmtpServer.Send(emailtbox.Text, "harshamahesh141@gmail.com", "About Form I-1", "Sir, My details are added to the Form I-1, please sir check it");
            }
            catch (Exception E)
            {
                MessageBox.Show("network problem");
            }


        }
        /*if (passwoedtxt.Text != "")
        {
            mail.sendmail(emailtbox.Text, passwoedtxt.Text, "harshamahesh141@gmail.com");
        }
        else
        {
            MetroMessageBox.Show(this, "Check Password", "", MessageBoxButtons.OK);
        }*/
    }
    }

