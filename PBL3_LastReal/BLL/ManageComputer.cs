using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                time = hour.ToString() + " : " + minute.ToString();
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
        public List<Computer> getAllComputer()
        {
            List<Computer> list = new List<Computer>(); 
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                list = db.Computers.Select(p => p).ToList();
            }    
            return list;
        }
        public List<string> getCCBState()
        {
            List<string> list = new List<string>
            {
                "Chưa sử dụng",
                "Đang sử dụng",
                "Đang hỏng"
            };
            return list;
        }
        public void addComputer(string ID_com, string price, string type, string state)
        {
            int count = 0;
            if(state == "Đang sử dụng")
            {
                count = 1;
            }
            if (state == "Đang hỏng")
            {
                count = 2;
            }
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Computer com = new Computer
                {
                    ID_Computer = Convert.ToInt32(ID_com),
                    Price = Convert.ToInt32(price),
                    Type = Convert.ToInt32(type),
                    State = count
                };
                db.Computers.InsertOnSubmit(com);
                db.SubmitChanges();
            }    
        }
        public Computer getComputerByID(string ID_com) 
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Computer com = new Computer
            {
                ID_Computer = db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().ID_Computer,
                Price = db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().Price,
                Type = db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().Type,
                State = db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().State
            };
            return com;
        }
        public bool checkIDMay(string ID_com) 
        {
            bool check = false;
            foreach(string i in getAllID().ToArray()) 
            {
                if (i == ID_com)
                    check = true;
            }
            return check;
        }
        public void updateComputer(string ID_com, string price, string type, string state)
        {
            int count = 0;
            if (state == "Đang sử dụng")
            {
                count = 1;
            }
            if (state == "Đang hỏng")
            {
                count = 2;
            }
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().Price = Convert.ToInt32(price);
                db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().Type = Convert.ToInt32(type);
                db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First().State = count;
                db.SubmitChanges();
            }    
        }
        public void deleteComputer(string ID_com) 
        {
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Computers.DeleteOnSubmit(db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(ID_com)).First());
                db.SubmitChanges();
            }    
        }
        public List<Computer> getComputersStateUsed(string txt)
        {
            List<Computer> list = new List<Computer>();
            List<Computer> list1 = new List<Computer>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                list = db.Computers.Where(p => p.State == 1).Select(p => p).ToList();
            }
            foreach (Computer com in list)
            {
                if(com.ID_Computer.ToString().Contains(txt))
                {
                    list1.Add(com);
                }    
            }
            return list1; 
        }
        public List<Computer> getComputersStateFree(string txt)
        {
            List<Computer> list = new List<Computer>();
            List<Computer> list1 = new List<Computer>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                list = db.Computers.Where(p => p.State == 0).Select(p => p).ToList();
            }
            foreach (Computer com in list)
            {
                if (com.ID_Computer.ToString().Contains(txt))
                {
                    list1.Add(com);
                }
            }
            return list1;
        }
    }
}
