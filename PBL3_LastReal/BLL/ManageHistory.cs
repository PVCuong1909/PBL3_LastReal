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
        public void addHistory(int id_com, string id_acc, DateTime timeBegin, DateTime timeEnd)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                History his = new History
                {
                    ID_Computer = id_com,
                    ID_Account = id_acc,
                    TimeBegin = timeBegin,
                    TimeEnd = timeEnd
                };
                db.Histories.InsertOnSubmit(his);
                db.SubmitChanges();
            }
        }
    }
}