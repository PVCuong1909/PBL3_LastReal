using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_LastReal.BLL
{
    public class ManageBill
    {
        private static ManageBill instance;
        private ManageBill() { }
        public static ManageBill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageBill();
                }
                return instance;
            }
            private set { }
        }

        public void addBill(int money, int type)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Bills.InsertOnSubmit(new Bill
                {
                    Date = DateTime.Now,
                    Money = money,
                    Type = type
                });
                db.SubmitChanges();
            }
        }
    }
}
