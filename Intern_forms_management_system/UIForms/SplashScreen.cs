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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (proBar.Value != 100)
            {
                proBar.Value++;

                if (proBar.Value == 2)
                {
                    lblLoging.Text = "Loading...";
                }
                else if (proBar.Value == 20)
                {
                    lblLoging.Text = "Create I / O Manager...";
                }
                else if (proBar.Value == 40)
                {
                    lblLoging.Text = "Initializing Database...";
                }
                else if (proBar.Value == 55)
                {
                    lblLoging.Text = "Initializing Device Explorer...";
                }
                else if (proBar.Value == 70)
                {
                    lblLoging.Text = "Initializing UI... ";
                }
                else if (proBar.Value == 85)
                {
                    lblLoging.Text = "Starting UI...";
                }
            }
            else
            {
                timer1.Stop();
                bunifuFormFadeTransition1.HideAsyc(this, false);
                this.Visible = false;
                LoginIFMS login = new LoginIFMS();
                login.Visible = true;

            }
        }

        private void proBar_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
