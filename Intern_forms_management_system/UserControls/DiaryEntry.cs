using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Intern_forms_management_system.Diary
{
    class DiaryEntry
    {
        //private string ID;
        private string date { get; set; }
        private string time { get; set; }
        private DateTime date_Time;

        private string Entry;

        private string sid;

        private DbConnect connection = new DbConnect();


        public DiaryEntry()
        {
            this.date = DateTime.Now.ToShortDateString();
            this.time = DateTime.Now.ToShortTimeString();

            //connection = new DbConnect();

        }
        //getters
        public string getTodayDate()
        {
            return this.date;
        }

        public string getNowTime()
        {
            return this.time;
        }

        public string getEntry()
        {
            return this.Entry;
        }

        public DateTime getEntryDate()
        {
            return this.date_Time;
        }
        //setters
        public void setDate(DateTime date)
        {
            this.date_Time = date;
        } 

        public void setEntry(string entry)
        {
            this.Entry = entry;
        }


        public void setSid(string sid)
        {
            this.sid = sid;
        }

        public string getSid()
        {
            return this.sid;
        }

        public bool saveEntry()
        {
            if(entryValidate())
            {
                connection.Connection();
                String query1 = "INSERT INTO `daily_diary`(`ddate`, `studentId`, `task`) VALUES (@f1,@f2,@f3)";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection.con);
                cmd1.Parameters.AddWithValue("@f1", getEntryDate());
                cmd1.Parameters.AddWithValue("@f2", getSid());
                cmd1.Parameters.AddWithValue("@f3", getEntry());
                
                connection.con.Open();
                cmd1.ExecuteNonQuery();

                return true;
            }

            return false;
        }

        public bool entryValidate()
        {
            if (string.IsNullOrEmpty(getEntry()))
            {
                MessageBox.Show("Diary Entry is Empty");


                return false;
            }

            else if (string.IsNullOrEmpty(getSid()))
            {
                MessageBox.Show("Diary Student ID is Empty");
                return false;
            }
            else if(getEntryDate()==null)
            {
                MessageBox.Show("Diary Entry Date is Empty");
                return false;
            }

            else
            {
                return true;
            }
        }

        public void loadEntry()
        {
           // connection.Connection();
           // MySqlCommand cmd2;
           // MySqlDataReader mdr;

           //// String quary = "SELECT * FROM `intern_student` where studentId='" + Sidtxtbox.Text + "'";
           // cmd2 = new MySqlCommand(quary, connection.con);
           // connection.con.Open();
           // mdr = cmd2.ExecuteReader();
        }




    }
}
