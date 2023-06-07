using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_LastReal.DTO;


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

        public void addBill(int money, int type, DateTime time)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Bills.Add(new Bill
                {
                    Date = time,
                    Money = money,
                    Type = type
                });
                db.SaveChanges();
            }
        }
        public void removeBill(DateTime time)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                int id = db.Bills.Where(p => p.Date.Value.ToString() == time.ToString()).First().ID_Bill;
                db.Bills.Remove(db.Bills.Where(p => p.ID_Bill == id).First());
                db.SaveChanges();
            }
        }
    }
}
