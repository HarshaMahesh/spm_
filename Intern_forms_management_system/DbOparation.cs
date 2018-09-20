using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system
{
    class DbOparation
    {
        DbConnect db = new DbConnect();
        //form I-1 db oparation 
        
        public void addStudentForm1(int id) {

            db.Connection();
            String query1 = "Insert into () values(@f1,@f2)";
            MySqlCommand cmd = new MySqlCommand(query1, db.con);
            cmd.Parameters.AddWithValue("@f1",id);
            
            db.con.Open();
            cmd.ExecuteNonQuery();
              
        }
        public void addEmployee(string name,string address,string sname, string title, string sphone, string semail, string esname) {

            db.Connection();
            String query1 = "Insert into `employee`(`name`,`address`) values(@f1,@f2)";
            MySqlCommand cmd1= new MySqlCommand(query1, db.con);
            cmd1.Parameters.AddWithValue("@f1", name);
            cmd1.Parameters.AddWithValue("@f2", address);
            db.con.Open();
            cmd1.ExecuteNonQuery();

            String query2 = "INSERT INTO `supervisor`(`supervisorName`, `supervisorTitle`, `supervisorPhone`, `supervisorEmail`, `ExternalSupName`) VALUES (@f1,@f2,@f3,@f4,@f5)";
            MySqlCommand cmd2 = new MySqlCommand(query2, db.con);
            cmd2.Parameters.AddWithValue("@f1", sname);
            cmd2.Parameters.AddWithValue("@f2", title);
            cmd2.Parameters.AddWithValue("@f3", sphone);
            cmd2.Parameters.AddWithValue("@f4", semail);
            cmd2.Parameters.AddWithValue("@f5", esname);
           // db.con.Open();
            cmd2.ExecuteNonQuery();



        }



        //Registering the employees - done by the HR Manager
        public void registerIntern(string studentid, string fullname, string university, string email, string telephone, string department, string address)
        {
            db.Connection();

            String query1 = "INSERT INTO `intern_student`(`studentId`,`full_name`,`university`,`email`,`telephone`,`department`,`address`)";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.con);

            cmd1.Parameters.AddWithValue("@f1",studentid);
            cmd1.Parameters.AddWithValue("@f2", fullname);
            cmd1.Parameters.AddWithValue("@f3", university);
            cmd1.Parameters.AddWithValue("@f4", email);
            cmd1.Parameters.AddWithValue("@f5", telephone);
            cmd1.Parameters.AddWithValue("@f6", department);
            cmd1.Parameters.AddWithValue("@f7", address);
            //cmd1.Parameters.AddWithValue("@f1", studentid);

            cmd1.ExecuteNonQuery();
        }

        //Validating the phone number of the Intern
        public bool IsPhoneNumber(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        //validating the email address of the Intern
        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //validating the words (text only)
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
