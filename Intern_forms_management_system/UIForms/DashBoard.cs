using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.UIForms
{
    public partial class DashBoard : Form

            
    {
        UserControls.UcForm1 form1;
        UserControls.UCStudentRegisterHR stdReg;
        UserControls.DailyDiary form3;
        UserControls.SupervisorDailyDiary form32;

        UserControls.UCInernshipReport form33;
        LoginIFMS logn;
        DbConnect db;
        public DashBoard()
        {
            InitializeComponent();

            db = new DbConnect();
            form1 = new UserControls.UcForm1();
            stdReg = new UserControls.UCStudentRegisterHR();
            form3 = new UserControls.DailyDiary();
            form32 = new UserControls.SupervisorDailyDiary();
            form33 = new UserControls.UCInernshipReport();
            logn = new LoginIFMS();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            sidepanelbtn.Visible = false;

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
                    }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (SidePanal.Width == 277)
            {
                sidepanelbtn.Visible = true;
                logo.Visible = false;
                SidePanal.Width = 57;
                // SidePanalAnimation.ShowSync(SidePanal);
            }
            else
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            }
            form3.Hide();
            form32.Hide();
            form33.Hide();
            panel2.Hide();
            form1.Hide();
            stdReg.Show();
            stdReg.Dock = DockStyle.Fill;
            panel1.Controls.Add(stdReg);
        }

        private void SidePanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidePanal_MouseEnter(object sender, EventArgs e)
        {
            if (SidePanal.Width == 57)
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;          
                
                //SidePanalAnimation.ShowSync(SidePanal);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            sidepanelbtn.Visible = false;
            logo.Visible = true;
            SidePanal.Width = 277;
        }

        private void StudentRegBtn_DragEnter(object sender, DragEventArgs e)
        {
            sidepanelbtn.Visible = false;
            logo.Visible = true;
            SidePanal.Width = 277;
        }

        private void StudentRegBtn_MouseEnter(object sender, EventArgs e)
        {
            sidepanelbtn.Visible = false;
            logo.Visible = true;
            SidePanal.Width = 277;
        }

        private void bunifuGradientPanel3_MouseEnter_1(object sender, EventArgs e)
        {
            sidepanelbtn.Visible = false;
            logo.Visible = true;
            SidePanal.Width = 277;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
           sidepanelbtn.Visible = false;
           logo.Visible = true;
           SidePanal.Width = 277;                  
                    
          
            form33.Hide();
            form32.Hide();
            stdReg.Hide();
            form3.Hide();
            form1.Hide();
            form1.Hide();

            panel2.Show();
        }

        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (SidePanal.Width == 277)
            {
                sidepanelbtn.Visible = true;
                logo.Visible = false;
                SidePanal.Width = 57;
                // SidePanalAnimation.ShowSync(SidePanal);
            }
            else
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            }

            panel2.Hide();
            form33.Hide();
            form32.Hide();
            stdReg.Hide();
            form3.Hide();
            form1.Show();
            form1.Dock = DockStyle.Fill;
            panel1.Controls.Add(form1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (SidePanal.Width == 277)
            {
                sidepanelbtn.Visible = true;
                logo.Visible = false;
                SidePanal.Width = 57;
                // SidePanalAnimation.ShowSync(SidePanal);
            }
            else
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            }

            panel2.Hide();
            form33.Hide();
            stdReg.Hide();
            form32.Hide();
            form1.Hide();
            form3.Show();
            form3.Dock = DockStyle.Fill;
            panel1.Controls.Add(form3);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            
                if (SidePanal.Width == 277)
            {
                sidepanelbtn.Visible = true;
                logo.Visible = false;
                SidePanal.Width = 57;
                // SidePanalAnimation.ShowSync(SidePanal);
            }
            else
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            }

            panel2.Hide();
            stdReg.Hide();
            form1.Hide();
            form33.Hide();
            form3.Hide();
            form32.Show();
            form32.Dock = DockStyle.Fill;
            panel1.Controls.Add(form32);
        }


        private void bunifuFlatButton5_Click(object sender, EventArgs e) { 
      
            if (SidePanal.Width == 277)

            {
                sidepanelbtn.Visible = true;
                logo.Visible = false;
                SidePanal.Width = 57;
                // SidePanalAnimation.ShowSync(SidePanal);
            }
            else
            {
                sidepanelbtn.Visible = false;
                logo.Visible = true;
                SidePanal.Width = 277;
            }

            panel2.Hide();
            stdReg.Hide();
            form1.Hide();
            form3.Hide();
            form32.Hide();
            form33.Show();
            form33.Dock = DockStyle.Fill;
            panel1.Controls.Add(form33);

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            logn.Visible = true;
            this.Visible = false;
        }
    }
}
