using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_forms_management_system.UserControls
{
    class StudentView
    {
        private string studentID;
        private DbConnect connection;


        public StudentView()
        {
            connection = new DbConnect();
        }

        public string getstudentID()
        {
            return studentID;
        }

        public void setStudentID(string id)
        {
            this.studentID = studentID;
        }


        public DataTable loadStudentDetails(string sid)
        {
            try
            {
                connection.Connection();
                connection.con.Open();
                DataTable dt = new DataTable();
                String query = "SELECT * FROM ` intern_student` where studentId='"+sid+"'";

                MySqlDataAdapter mda = new MySqlDataAdapter(query, connection.con);

                mda.Fill(dt);

                if (dt.Rows.Count >= 0)
                {
                    return dt;
                }

                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
