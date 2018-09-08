using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_forms_management_system.Diary
{
    class DiaryEntry
    {
        private string ID;
        private string date { get; set; }
        private string time { get; set; }
        private DateTime date_Time { get; set; }

        private string Entry { get; set; }

        public DiaryEntry()
        {
            this.date = DateTime.Now.ToShortDateString();
            this.time = DateTime.Now.ToShortTimeString();
    
        }

        public string getTodayDate()
        {
            return this.date;
        }

        public string getNowTime()
        {
            return this.time;
        }




    }
}
