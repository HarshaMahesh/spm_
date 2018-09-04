using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        
        public void addStudentForm1(string id,double cgpa,int homephone,string semester,string year) {

            try
            {
                db.Connection();
                String upquery = "UPDATE intern_student SET homePhone=@f2,semester=@f3,cgpa=@f4,year=@f5 WHERE studentId='"+id+"'";
                MySqlCommand cmd = new MySqlCommand(upquery, db.con);
                DataTable table = new DataTable();
                cmd.Parameters.AddWithValue("@f2", homephone);
                cmd.Parameters.AddWithValue("@f3", semester);
                cmd.Parameters.AddWithValue("@f4", cgpa);
                cmd.Parameters.AddWithValue("@f5", year);

                db.con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e){

                Console.Write(e);
            }
        }
        public void searchSudent(string id,string sname,string saddress,string sphone,string email) {

          



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
            cmd2.ExecuteNonQuery();
            
        } 

    }

    
}
