using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using PBL3_LastReal.DTO;

namespace PBL3_LastReal.BLL
{
    public class ManageHistory
    {
        private static ManageHistory instance;
        private ManageHistory() { }
        public static ManageHistory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageHistory();
                }
                return instance;
            }
            private set { }
        }
        public void addHistoryClickOK(int id_com, string id_acc, DateTime timeBegin)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                History his = new History
                {
                    ID_Computer = id_com,
                    ID_Account = id_acc,
                    TimeBegin = timeBegin,
                };
                db.Histories.Add(his);
                db.SaveChanges();
            }
        }
        public void addHistoryClickLogOut(int id_com, string id_acc, DateTime timeBegin)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            History getTimeEND = new History();
            foreach (History item in db.Histories)
            {
                if(item.ID_Account.ToString() == id_acc.ToString() && item.ID_Computer.ToString() == id_com.ToString() && item.TimeBegin.ToString() == timeBegin.ToString())
                {
                    getTimeEND = item;
                    break;
                }    
            }
            getTimeEND.TimeEnd = DateTime.Now;      
            db.SaveChanges();
            
        }
        public List<History> seeHistoryByIdCom(string id_com)
        {
            List<History> list = new List<History>();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                int id = Convert.ToInt32(id_com);
                list = db.Histories.Where(p => p.ID_Computer == id)
                                    .ToList();
            }
            return list;
        }
        public Account getInformationAccHistory(string id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Account acc = new Account
                {
                    Username = db.Histories.Where(p => p.ID_Account == id).First().Account.Username,
                    Money = db.Histories.Where(p => p.ID_Account == id).First().Account.Money
                };
            return acc;
        }
        public Person getInformationPerHistory(string id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Person per = new Person
            {
                Name = db.Histories.Where(p => p.ID_Account == id).First().Account.Person.Name,
                DOB = db.Histories.Where(p => p.ID_Account == id).First().Account.Person.DOB,
                CCCD = db.Histories.Where(p => p.ID_Account == id).First().Account.Person.CCCD,
                PhoneNum = db.Histories.Where(p => p.ID_Account == id).First().Account.Person.PhoneNum
            };
            return per;
        }
        public Account getHistotyByIDAndTimeBeginAcc(string id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            int id_com = Convert.ToInt32(id);
            Account acc = new Account
            {
                ID_Account = db.Histories.Where(p => p.ID_Computer == id_com && p.TimeEnd == null).First().ID_Account,
                Username = db.Histories.Where(p => p.ID_Computer == id_com && p.TimeEnd == null).First().Account.Username,
                Money = db.Histories.Where(p => p.ID_Computer == id_com && p.TimeEnd == null).First().Account.Money
            };
            return acc;  
        }
        public Person getHistoryByIDAndTimeBeginPer(string id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            int id_his = Convert.ToInt32(id);
            Person per = new Person
            {
                Name = db.Histories.Where(p => p.ID_Computer == id_his && p.TimeEnd == null).First().Account.Person.Name,
            };
            return per;
        }
        public void delHistoryByID_Acc(string id) 
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                List<History> histories = db.Histories.Where(p => p.ID_Account == id).ToList();
                db.Histories.RemoveRange(histories);
                db.SaveChanges();
            }
        }
    }
}