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
        UserControls.SupervisorDailyDiary form3;
        DbConnect db;
        public DashBoard()
        {
            InitializeComponent();

            db = new DbConnect();
            form1 = new UserControls.UcForm1();
            form3 = new UserControls.SupervisorDailyDiary();
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
            form1.Hide();
            panel2.Hide();
            form3.Show();
            form3.Dock = DockStyle.Fill;
            panel1.Controls.Add(form3);

        }
    }
}
