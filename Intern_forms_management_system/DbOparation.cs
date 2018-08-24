using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void registerIntern(string studentid)
        {
            db.Connection();

            String query1 = "INSERT INTO `intern_student`(`studentId`,`full_name`,`university`,`dob`,`email`,`telephone`,`department`,`address`)";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.con);

            cmd1.Parameters.AddWithValue("@f1",studentid);
            cmd1.ExecuteNonQuery();
        }
    }
}
