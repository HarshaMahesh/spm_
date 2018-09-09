using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.UIForms
{
    class Login
    {
        //decalre properties 
        private string Username { get; set; }
        private string Userpassword { get; set; }

        private DbConnect connection;

        //intialise  
        public Login()
        {
            connection = new DbConnect();
            
        }

        //setters
        public void setUsername(string uname)
        {
            this.Username = uname;
        }

        public void setPassword(string pwd)
        {
            this.Userpassword = pwd;
        }

        //getters
        public string getPassword()
        {
            return this.Userpassword;
        }

        public string getUsername()
        {
            return this.Username;
        }
        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer 
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct 
            else
            {
                connection.Connection();
                connection.con.Open();
                String query1 = "select * from users where uname=@param1";
                MySqlCommand cmd = new MySqlCommand(query1, connection.con);
                cmd.Parameters.AddWithValue("@param1", getUsername());
                cmd.Connection = connection.con;
               

                MySqlDataReader reader = cmd.ExecuteReader();

                //while (reader.Read())
                 if (!reader.Read())
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    connection.Connection();
                    connection.con.Open();
                    String query2 = "select * from users wheree uname=@param1 and pwd=@param2";
                    MySqlCommand cmd2 = new MySqlCommand(query1, connection.con);
                    cmd2.Parameters.AddWithValue("@param1", getUsername());
                    cmd2.Parameters.AddWithValue("@param2", getPassword());
                    cmd2.Connection = connection.con;
                    MessageBox.Show(getUsername());
                    MessageBox.Show(getUsername());


                    MySqlDataReader reader2 = cmd2.ExecuteReader();


                    //check password is correct 
                    
                    if (!reader2.Read())
                    {
                        MessageBox.Show("password is incorrect!");
                        ClearTexts(user, pass);
                        return false;
                    }
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid 
                    else if (IntegerValidator(pass) == true)
                    {
                        MessageBox.Show("Enter only integer here");
                        return false;
                    }
                  
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
