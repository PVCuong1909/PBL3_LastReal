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
                Type = 3;
            }
            else if (type == "Thu ngân")
            {
                Type = 4;
            }
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Person per = new Person
                {
                    Name = name,
                    DOB = dob,
                    CCCD = cccd,
                    PhoneNum = phonenum
                };
                db.Persons.InsertOnSubmit(per);
                db.SubmitChanges();
                //db.Accounts.Where(p => p.ID_Person == ManagePerson.Instance.GetPersonByCCCD(per.CCCD).ID_Person).First().Type = Type;
                Salary sal = new Salary
                {
                    ID_Person = per.ID_Person,
                    Salary1 = salary,
                };
                db.Salaries.InsertOnSubmit(sal);
                db.SubmitChanges();
            }
        }
        public void editSalaryAndPer(int id, string type, string name, DateTime dob, string cccd, string phonenum, int salary)
        {
            int Type = 2;
            if (type == "Bảo vệ")
            {
                Type = 3;
            }
            else if (type == "Thu ngân")
            {
                Type = 4;
            }
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                var query = db.Salaries.Where(p => p.ID_Person == id).FirstOrDefault();
                db.Salaries.Where(p => p.ID_Person == id).First().Salary1 = salary;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.Name = name;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.DOB = dob;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.CCCD= cccd;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.PhoneNum= phonenum;
                db.SubmitChanges();
            }
        }
    }
}