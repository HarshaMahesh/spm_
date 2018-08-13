using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;
using App1.vehicleManage;

namespace Car_Rentel_System_v0._1.UI_Forms
{
    public partial class DashBoard : Form
    {
        UserControl1 uc;
        UserControls.ucDataBackup uc2;
        UserControls.ucvehiclepro uc3;
        UserControls.ucBooking ucBooking;
        UserControls.Employeeuc uc4;
        SpecialPackage uc5;
        UserControls.UserHandling.ManagerMain uc6;
        DbConnect db;
        Notifications n1;
        Reports re;
        MainUC uc7;
        UserControls.EmployeeUserControls.Payments uc8;
        UserControls.Employee_User_Controls.EmployeeAttendance uc9;
        UserControls.Employee_User_Controls.EmployeeGUIPreLoader uc10;
        UI_Forms.EmployeePersonalDetails uc11;
        
        






        public DashBoard()
  
        {
            
            

            uc = new UserControl1();
            uc2 = new UserControls.ucDataBackup();
            uc3 = new UserControls.ucvehiclepro();
            ucBooking = new UserControls.ucBooking();
            db = new DbConnect();
            uc4 = new UserControls.Employeeuc();
            uc5 =new  SpecialPackage();
            uc6 =new UserControls.UserHandling.ManagerMain() ;
            n1 = new Notifications();
            re = new Reports();
            uc7 = new MainUC();


            InitializeComponent();
            btnMenu2.Visible = false;
           
            





        }
        

        private void DashBoard_Load(object sender, EventArgs e)
        {

            n1.Notification1();


        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }


        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }

            panel2.Hide();
            uc3.Hide();
            uc2.Hide();
            uc.Hide();
            ucBooking.Hide();
            uc5.Hide();
            uc6.Hide();
            uc7.Hide();            
            uc4.Show();
            uc4.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc4);



        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

            LoginUI lg = new LoginUI();
            lg.Visible = true;
            this.Visible =false;
            




        } 
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }

            panel2.Hide();
            uc3.Hide();
            uc2.Hide();
            ucBooking.Hide();
            uc4.Hide();
            uc5.Hide();
            uc6.Hide();
            uc7.Hide();          
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

            SlidePanel.BackColor = Color.Yellow;

           



        }

        private void SlidePanel_MouseHover(object sender, EventArgs e)
        {
            
            
              





        }

        private void SlidePanel_MouseLeave(object sender, EventArgs e)
        {
            


        }

        private void SlidePanel_Enter(object sender, EventArgs e)
        {
            

           
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnMenu2_MouseEnter(object sender, EventArgs e)
        {
            btnMenu2.Visible = false;
            logo.Visible = true;
            SlidePanel.Visible = false;
            SlidePanel.Width = 220;
            PanelAnimator.ShowSync(SlidePanel);
            LogoAnimation.ShowSync(logo);

        }

        private void SlidePanel_Paint(object sender, PaintEventArgs e)

        {
        

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void MainPanel_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void SlidePanel_MouseEnter(object sender, EventArgs e)
        {


        }

        private void btnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void SlidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuFlatButton9_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton9_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void SlidePanel_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void SlidePanel_Leave(object sender, EventArgs e)
        {
            

        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }

            panel2.Hide();
            n1.Notification1();
            uc.Hide();
            uc2.Hide();
            uc4.Hide();            
            uc5.Hide();
            uc6.Hide();
            uc7.Hide();
            ucBooking.Hide();
            uc3.Show();
            uc3.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc3);

            SlidePanel.BackColor = Color.Yellow;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }


            panel2.Hide();
            uc.Hide();
            uc2.Hide();
            uc3.Hide();
            uc4.Hide();
            uc5.Hide();
            uc6.Hide();
            ucBooking.Hide();
            uc7.Show();
            uc7.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc7);

            SlidePanel.BackColor = Color.Yellow;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }

            n1.Notification2();

            panel2.Hide();
            uc.Hide();
            uc2.Hide();
            uc3.Hide();
            uc4.Hide();
            uc6.Hide();
            uc7.Hide();
            ucBooking.Hide();
            uc5.Show();
            uc5.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc5);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }


            panel2.Hide();
            uc.Hide();
            uc2.Hide();
            uc3.Hide();
            uc4.Hide();
            ucBooking.Hide();
            uc5.Hide();
            uc7.Hide();
            uc6.Show();
            uc6.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc6);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }

            panel2.Hide();
            uc.Hide();
            uc6.Hide();
            uc3.Hide();
            uc4.Hide();
            ucBooking.Hide();
            uc5.Hide();
            uc7.Hide();
            uc2.Show();
            uc2.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc2);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width == 220)
            {
                logo.Visible = false;
                SlidePanel.Visible = false;
                SlidePanel.Width = 56;
                btnMenu2.Visible = true;
                PanelAnimator.ShowSync(SlidePanel);
            }
            


            panel2.Hide();
            uc.Hide();
            uc2.Hide();
            uc3.Hide();
            uc4.Hide();
            uc5.Hide();
            uc6.Hide();           
            uc7.Hide();
            ucBooking.Show();
            ucBooking.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucBooking);

            SlidePanel.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            
            re.Visible = true;
        }
    }
}
 