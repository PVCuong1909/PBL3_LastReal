using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using PBL3_LastReal.DTO;

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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
            using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                state = (int)db.Computers.Where(p => p.ID_Computer == id).First().State;
            }
            return state;
        }
        public void changeStateToUsed(int id)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Computers.Where(p => p.ID_Computer == id).First().State = 1;
                db.SaveChanges();
            }
        }
        public void changeStateToFree(int id)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Computers.Where(p => p.ID_Computer == id).First().State = 0;
                db.SaveChanges();
            }
        }
        public string getRemainTime(int id_com, string id_acc)
        {
            string time = "";
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                int price = (int)db.Computers.Where(p => p.ID_Computer == id_com).First().Price;
                int money = (int)db.Accounts.Where(p => p.ID_Account == id_acc).First().Money;
                float remainTime =(float) money / price;
                int hour = (int)remainTime;
                int minute = Convert.ToInt32((remainTime - hour) * 60);
                time = hour.ToString() + " : " + minute.ToString();
            }
            return time;
        }
        public int getPrice(int id_com)
        {
            int price = -1;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                price = (int)db.Computers.Where(p => p.ID_Computer == id_com).First().Price;
            }
            return price;
        }
        public List<Computer> getAllComputer()
        {
            List<Computer> list = new List<Computer>(); 
            using(QL_QuanNetEntities db = new QL_QuanNetEntities())
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
            using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Computer com = new Computer
                {
                    ID_Computer = Convert.ToInt32(ID_com),
                    Price = Convert.ToInt32(price),
                    Type = Convert.ToInt32(type),
                    State = count
                };
                db.Computers.Add(com);
                db.SaveChanges();
            }    
        }
        public Computer getComputerByID(string ID_com) 
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            int id = Convert.ToInt32(ID_com);
            Computer com = new Computer
            {
                ID_Computer = db.Computers.Where(p => p.ID_Computer == id).First().ID_Computer,
                Price = db.Computers.Where(p => p.ID_Computer == id).First().Price,
                Type = db.Computers.Where(p => p.ID_Computer == id).First().Type,
                State = db.Computers.Where(p => p.ID_Computer == id).First().State
            };
            return com;
        }
        public bool checkIDMay(string ID_com) 
        {
            bool check = false;
            foreach(string i in getAllID()) 
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
            using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                int id = Convert.ToInt32(ID_com);
                db.Computers.Where(p => p.ID_Computer == id).First().Price = Convert.ToInt32(price);
                db.Computers.Where(p => p.ID_Computer == id).First().Type = Convert.ToInt32(type);
                db.Computers.Where(p => p.ID_Computer == id).First().State = count;
                db.SaveChanges();
            }    
        }
        public void deleteComputer(string ID_com) 
        {
            using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                int id = Convert.ToInt32(ID_com);
                db.Computers.Remove(db.Computers.Where(p => p.ID_Computer == id).First());
                db.SaveChanges();
            }    
        }
        public List<Computer> getComputersStateUsed(string txt)
        {
            List<Computer> list = new List<Computer>();
            List<Computer> list1 = new List<Computer>();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
