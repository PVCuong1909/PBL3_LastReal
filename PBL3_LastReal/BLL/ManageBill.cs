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

        public void addBill(int summary, int type)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Bill bill = new Bill() 
                {
                    Money = summary,
                    Type = type,
                    Date = DateTime.Now,

                };
                db.Bills.InsertOnSubmit(bill);
                db.SubmitChanges();
                int pos = 0;
                var query2 = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();
                for(int i = 0; i < query2.Count; i++)
                {
                    if (ManageProfit.Instance.check((DateTime)query2[i].Date) == true)
                    {
                        query2[i].DichVu += bill.Money;
                        db.SubmitChanges();
                        break;

                    }

                }
                //if (ManageProfit.Instance.check((DateTime)query2[pos].Date) == true)
                //{
                //    query2[pos].DichVu += bill.Money;
                //    db.SubmitChanges();
                //}
                //else
                //{
                //    pos++;
                //}

            }
        }
    }
}
