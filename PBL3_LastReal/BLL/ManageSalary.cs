using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_LastReal.BLL
{
    public class ManageSalary
    {
        private static ManageSalary instance;
        private ManageSalary() { }
        public static ManageSalary Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageSalary();
                }
                return instance;
            }
            private set { }
        }
        public Salary getSalaryByID(int id)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Salary sar = db.Salaries.Where(p => p.ID_Person == id).First();
            return sar;
        }
        public void addSalaryAndPer(string type, string name, DateTime dob, string cccd, string phonenum, int salary)
        {
            int Type = 2;
            if (type == "Bảo vệ")
            {
                Type = 4;
            }
            else if (type == "Thu ngân")
            {
                Type = 3;
            }
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Person per = new Person
                {
                    Type = Type,
                    Name = name,
                    DOB = dob,
                    CCCD = cccd,
                    PhoneNum = phonenum
                };
                db.Persons.InsertOnSubmit(per);
                db.SubmitChanges();
                Salary sal = new Salary
                {
                    ID_Person = per.ID_Person,
                    Salary1 = salary,
                };
                var Bill = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();
                for (int i = 0; i < Bill.Count; i++)
                {
                    if (ManageProfit.Instance.check((DateTime)Bill[i].Date) == true)
                    {
                        Bill[i].LuongNhanVien += (int)sal.Salary1;
                            db.SubmitChanges();
                    }
                }
                db.Salaries.InsertOnSubmit(sal);
                db.SubmitChanges();

               
            }
        }
        public void editSalaryAndPer(int id, string type, string name, DateTime dob, string cccd, string phonenum, int salary)
        {
            int Type = 2;
            if(type == "Bảo vệ")
            {
                Type = 4;
            }
            else if(type == "Thu ngân")
            {
                Type = 3;
            }    
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                var Bill = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();
                var query = db.Salaries.Where(p => p.ID_Person == id).FirstOrDefault();
                for(int i =0; i < Bill.Count;i++)
                {
                    if (ManageProfit.Instance.check((DateTime)Bill[i].Date) == true)
                    {
                        Bill[i].LuongNhanVien -= (int) query.Salary1;
                        query.Salary1 = salary;
                        db.SubmitChanges();
                        Bill[i].LuongNhanVien +=(int) query.Salary1;
                        db.SubmitChanges();
                    }
                }

                db.Salaries.Where(p => p.ID_Person == id).First().Salary1 = salary;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.Name = name;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.DOB = dob;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.Type= Type;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.PhoneNum= phonenum;
                db.SubmitChanges();
            }
        }
        public List<Salary> getAllPerAndSal()
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();   
            List<Salary> list = new List<Salary>();
            list = db.Salaries.Select(p => p).ToList();
            return list;
        }
    }
}