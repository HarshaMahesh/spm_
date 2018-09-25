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
        public static string Username { get; set; }
        public static string Userpassword { get; set; }

        private DbConnect connection;

        //intialise  
        public Login()
        {
            connection = new DbConnect();
            
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

            //check passsword empty 
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Enter the password!");
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
                String query1 = "select * from users where uname='"+user+"'";
                MySqlCommand cmd = new MySqlCommand(query1, connection.con);
                cmd.Connection = connection.con;
               

                MySqlDataReader reader = cmd.ExecuteReader();

                //while (reader.Read())
                 if (!reader.HasRows)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                
                else
                {
                    connection.Connection();
                    connection.con.Open();
                    String query2 = "select * from users where uname=@param1 and pwd=@param2";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection.con);
                    cmd2.Parameters.AddWithValue("@param1", user);
                    cmd2.Parameters.AddWithValue("@param2", pass);
                    cmd2.Connection = connection.con;
                    


                    MySqlDataReader reader2 = cmd2.ExecuteReader();


                    
                    
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
