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

        public bool check(DateTime dbdate)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");

            if (((DateTime)dbdate).ToString("yyyy-MM-dd") == date.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkMonth(DateTime date,string month)
        {
            if (((DateTime)date).ToString("MMMM") == month)
            {
                return true;
            }
            else { return false; }
        }
        public void EndDay()
        {

              using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                var ResetAccountMoneyToday = db.Accounts.Where(p => p.Type == 1).ToList();
                for(int i =0;i<ResetAccountMoneyToday.Count;i++)
                {
                    ResetAccountMoneyToday[i].Money = 0;
                    db.SubmitChanges();
                }
            }
        }
        public int getSumarySalary()
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                var salary = db.Salaries.Where(p => p.ID_Person > 0).ToList();
                int sumarySalary = 0;
                for (int i = 0; i < salary.Count; i++)
                {
                    sumarySalary += (int)salary[i].Salary1;
                }
                return sumarySalary;
            }
        }
        public void EndDay2()
        {
            using(QuanLyNetDataContext db =new QuanLyNetDataContext())
            {
                DateTime today = DateTime.Today.AddDays(1);
                DateTime dt = DateTime.Now.AddMinutes(5);
                bool check = dt <= today;
         
                if (check == false)
                {
                    var ResetAccountMoneyToday = db.Accounts.Where(p => p.Type == 1).ToList();
                    for (int i = 0; i < ResetAccountMoneyToday.Count; i++)
                    {
                        ResetAccountMoneyToday[i].Money = 0;
                        db.SubmitChanges();
                    }
                    var Bill_Thang = db.Bill_Thangs.Where(p => p.Date >= DateTime.Today.AddDays(1)).ToList();
                  
                    if (Bill_Thang.Count == 0)
                    {
                        Bill_Thang newBillThang = new Bill_Thang()
                        {
                            TienMay = 0,
                            DichVu = 0,
                            LuongNhanVien = getSumarySalary(),
                            Date = Convert.ToDateTime(DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd"))
                        };
                        db.Bill_Thangs.InsertOnSubmit(newBillThang);
                        db.SubmitChanges();
                    }
                   
                }
               

              
            }
            
        }
        public void checkNewDay()
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                bool check = false;
                while (check == false)
                {
                    var Bill_Thang = db.Bill_Thangs.OrderByDescending(p => p.Id_Bill2).First();
                   
                    if (Bill_Thang.Date < DateTime.Now.Date)
                    {

                        var ResetAccountMoneyToday = db.Accounts.Where(p => p.Type == 1).ToList();
                        for (int i = 0; i < ResetAccountMoneyToday.Count; i++)
                        {
                            ResetAccountMoneyToday[i].Money = 0;
                            db.SubmitChanges();
                        }
                        Bill_Thang newBill = new Bill_Thang()
                        {
                            TienMay = 0,
                            DichVu = 0,
                            LuongNhanVien = getSumarySalary(),
                            Date = Convert.ToDateTime((Convert.ToDateTime(Bill_Thang.Date)).AddDays(1))

                        };
                        db.Bill_Thangs.InsertOnSubmit(newBill);
                        db.SubmitChanges();

                    }
                    else
                    {
                        check = true;
                        break;
                    }
                }
              

                //for (int i = pos + 1; i <= Bill_Thang.Count; i++)
                //{
                //    if (Bill_Thang[i].Date < DateTime.Now)
                //    {
                //        Bill_Thang newBill = new Bill_Thang()
                //        {
                //            TienMay = 0,
                //            DichVu = 0,
                //            LuongNhanVien = getSumarySalary(),
                //            Date = Convert.ToDateTime(DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd"))
                //        };
                //        db.Bill_Thangs.InsertOnSubmit(newBill);
                //        db.SubmitChanges();
                //    }
                //    else
                //    {
                //        break;
                //    }

                //}
                //while (Bill_Thang[Bill_Thang.Count - 1].Date < DateTime.Now)
                //{
                //    Bill_Thang newBill = new Bill_Thang()
                //    {
                //        TienMay = 0,
                //        DichVu = 0,
                //        LuongNhanVien = getSumarySalary(),
                //        Date = Convert.ToDateTime(DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd"))
                //    };
                //    db.Bill_Thangs.InsertOnSubmit(newBill);
                //    db.SubmitChanges();
                //}
            }
        }
     




    }
}
