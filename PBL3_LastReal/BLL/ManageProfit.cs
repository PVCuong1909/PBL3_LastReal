using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_LastReal.BLL
{
    public class ManageProfit
    {
        private static ManageProfit instance;
        private ManageProfit() { }
        public static ManageProfit Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageProfit();
                }
                return instance;
            }
            private set { }
        }

        public List<Bill> getBills(DateTime date)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            return db.Bills.Where(p => p.Date <= date.AddDays(1) && p.Date >= date).ToList();
        }

        public List<Bill> getBillsInMonth(DateTime date)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            return db.Bills.Where(p => p.Date <= date.AddMonths(1) && p.Date >= date).ToList();
        }
    }
}
