using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_LastReal.DTO;


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
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            DateTime right = date.AddDays(1);
            return db.Bills.Where(p => p.Date <= right && p.Date >= date).ToList();
        }

        public List<Bill> getBillsInMonth(DateTime date)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            DateTime right = date.AddMonths(1);
            return db.Bills.Where(p => p.Date <= right && p.Date >= date).ToList();
        }
    }
}
