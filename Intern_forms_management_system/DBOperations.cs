using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Intern_forms_management_system
{
    class DbOperations
    {
        DbConnect db = new DbConnect();

        public DataSet viewDailyDiary(String studentId,DateTime from,DateTime to)
        {
            try
            {
                
                db.Connection();
                db.con.Open();
                DataSet ds = new DataSet();
                String query = "SELECT * FROM `daily_diary` WHERE (`studentId` = '"+ studentId + "') AND `ddate` BETWEEN '"+from+"' AND '"+to+"'";

                MySqlDataAdapter mda = new MySqlDataAdapter(query, db.con);

                mda.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable loadStudentId()
        {
            try
            {
                db.Connection();
                db.con.Open();
                DataTable ds = new DataTable();
                String query = "SELECT * FROM `daily_diary`";

                MySqlDataAdapter mda = new MySqlDataAdapter(query, db.con);

                mda.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
