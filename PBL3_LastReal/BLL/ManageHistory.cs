using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

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
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                History his = new History
                {
                    ID_Computer = id_com,
                    ID_Account = id_acc,
                    TimeBegin = timeBegin,
                };
                db.Histories.InsertOnSubmit(his);
                db.SubmitChanges();
            }
        }
        public void addHistoryClickLogOut(int id_com, string id_acc, DateTime timeBegin)
        {
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Histories.Where(p => p.ID_Computer == id_com && p.ID_Account == id_acc && p.TimeBegin == timeBegin).First().TimeEnd = DateTime.Now;
                db.SubmitChanges();
            }
        }
        public List<History> seeHistoryByIdCom(string id_com)
        {
            List<History> list = new List<History>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                list = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(id_com))
                                    .ToList();
            }
            return list;
        }
        public Account getInformationAccHistory(string id)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Account acc = new Account
                {
                    Username = db.Histories.Where(p => p.ID_Account == id).First().Account.Username,
                    Money = db.Histories.Where(p => p.ID_Account == id).First().Account.Money
                };
            return acc;
        }
        public Person getInformationPerHistory(string id)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
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
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Account acc = new Account
            {
                ID_Account = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(id) && p.TimeEnd == null).First().ID_Account,
                Username = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(id) && p.TimeEnd == null).First().Account.Username,
                Money = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(id) && p.TimeEnd == null).First().Account.Money
            };
            return acc;  
        }
        public Person getHistoryByIDAndTimeBeginPer(string id)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Person per = new Person
            {
                Name = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(id) && p.TimeEnd == null).First().Account.Person.Name,
            };
            return per;
        }
        public void delHistoryByID_Acc(string id) 
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                List<History> histories = db.Histories.Where(p => p.ID_Account == id).ToList();
                db.Histories.DeleteAllOnSubmit(histories);
                db.SubmitChanges();
            }
        }
    }
}