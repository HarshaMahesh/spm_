using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.Login
{
    public partial class LoginUI : Form
    {
        Login login = new Login("admin", "1234");
        public LoginUI()
        {
            InitializeComponent();
            
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            string user = metroTextBoxUsername.Text;
            string pass = metroTextBoxPassword.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }
    }
}
