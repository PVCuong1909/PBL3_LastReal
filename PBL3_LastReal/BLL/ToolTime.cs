using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_LastReal.BLL
{
    public class ToolTime
    {
        private static ToolTime instance;
        private ToolTime() { }
        public static ToolTime Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ToolTime();
                }
                return instance;
            }
            private set { }
        }
        public string getTime(DateTime t)
        {
            string time = t.ToString("hh:mm:ss tt");
            return time;
        }
        public string getDate(DateTime t)
        {
            string date = t.ToString("dd/MM/yyyy");
            return date;
        }
        public DateTime trueTime(string time, string date)
        {
            string datetime = date + " " + time;
            return Convert.ToDateTime(datetime);
        }
        public DateTime trueTime(int day, int month, int year)
        {
            string date = year+"/"+month+"/"+day;
            return Convert.ToDateTime(date);
        }
    }
}
