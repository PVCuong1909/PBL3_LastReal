using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PBL3_LastReal.DTO;


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
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Salary sar = db.Salaries.Where(p => p.ID_Person == id).First();
            return sar;
        }

        public void addSalaryAndPer(string type, string name, DateTime dob, string cccd, string phonenum, int salary, string user, string pass, string id)
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Person per = new Person
                {
                    Name = name,
                    DOB = dob,
                    CCCD = cccd,
                    PhoneNum = phonenum
                };
                db.People.Add(per);
                db.SaveChanges();
                Salary sal = new Salary
                {
                    ID_Person = per.ID_Person,
                    Salary1 = salary,
                };
                db.Salaries.Add(sal);
                db.SaveChanges();
                Account acc = new Account
                {
                    Type = Type,
                    Username = user,
                    Password = ManageAccount.Instance.MD5Hash(pass),
                    ID_Person = per.ID_Person,
                    ID_Account = id,
                };
                db.Accounts.Add(acc);
                db.SaveChanges();
            }
        }
        public void editSalaryAndPer(int id, string type, string name, DateTime dob, string phonenum, int salary)
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                var query = db.Salaries.Where(p => p.ID_Person == id).FirstOrDefault();
                db.Salaries.Where(p => p.ID_Person == id).First().Salary1 = salary;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.Name = name;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.DOB = dob;
                db.Accounts.Where(p => p.ID_Person == id).First().Type= Type;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.PhoneNum= phonenum;
                db.SaveChanges();
            }
        }
        public void editSalaryAndAcc(int id, string type, string name, DateTime dob, string phonenum, int salary, string pass)
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                var query = db.Salaries.Where(p => p.ID_Person == id).FirstOrDefault();
                db.Salaries.Where(p => p.ID_Person == id).First().Salary1 = salary;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.Name = name;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.DOB = dob;
                db.Accounts.Where(p => p.ID_Person == id).First().Type = Type;
                db.Salaries.Where(p => p.ID_Person == id).First().Person.PhoneNum = phonenum;
                db.Accounts.Where(p => p.ID_Person == id).First().Password = ManageAccount.Instance.MD5Hash(pass);
                db.SaveChanges();
            }
        }
    }
}