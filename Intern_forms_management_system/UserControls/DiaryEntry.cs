using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool saveEntry()
        {
            if (string.IsNullOrEmpty(getEntry()))
            {
                return false;
            }
            else
            {
                connection.Connection();
                String query1 = "INSERT INTO `daily_diary`(`ddate`, `studentId`, `task`) VALUES (@f1,@f2,@f3)";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection.con);
                cmd1.Parameters.AddWithValue("@f1", getEntryDate());
                cmd1.Parameters.AddWithValue("@f2", "IT1234567");
                cmd1.Parameters.AddWithValue("@f2", getEntry());
                
                connection.con.Open();
                cmd1.ExecuteNonQuery();

                return true;
            }
        }




    }
}
