using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace PBL3_LastReal.BLL
{
    public class ManageComputer
    {
        private static ManageComputer instance;
        private ManageComputer() { }
        public static ManageComputer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageComputer();
                }
                return instance;
            }
            private set { }
        }
        public List<string> getAllID()
        {
            List<string> list = new List<string>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                foreach (Computer com in db.Computers)
                {
                    list.Add(com.ID_Computer.ToString()); 
                }
            }
            return list;
        }
        public int getState(int id)
        {
            int state = -1;
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                state = (int)db.Computers.Where(p => p.ID_Computer == id).First().State;
            }
            return state;
        }
        public void changeStateToUsed(int id)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Computers.Where(p => p.ID_Computer == id).First().State = 1;
                db.SubmitChanges();
            }
        }
        public void changeStateToFree(int id)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Computers.Where(p => p.ID_Computer == id).First().State = 0;
                db.SubmitChanges();
            }
        }
        public string getRemainTime(int id_com, string id_acc)
        {
            string time = "";
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                int price = (int)db.Computers.Where(p => p.ID_Computer == id_com).First().Price;
                int money = (int)db.Accounts.Where(p => p.ID_Account == id_acc).First().Money;
                float remainTime = money / price;
                int hour = (int)remainTime;
                int minute = (int)(remainTime - hour)*60;
                time = hour.ToString() + ":" + minute.ToString();
            }
            return time;
        }
        public int getPrice(int id_com)
        {
            int price = -1;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                price = (int)db.Computers.Where(p => p.ID_Computer == id_com).First().Price;
            }
            return price;
        }
    }
}
