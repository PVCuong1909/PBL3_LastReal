using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_LastReal.DTO;


namespace PBL3_LastReal.BLL
{
    public class ManagePerson
    {
        private static ManagePerson instance;
        private ManagePerson() { }
        public static ManagePerson Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManagePerson();
                }
                return instance;
            }
            private set { }
        }
        public Person GetPerson(int id)
        {
            Person per = new Person();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                per = db.People.Where(p => p.ID_Person == id).First();
            }
            return per;
        }
        public int getIDPersonByUsername(string username)
        {
            int id = 0;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                id = (int)db.Accounts.Where(p => p.Username == username).First().ID_Person;
            }
            return id;
        }
        public int getIDPersonByCCCD(string cccd)
        {
            int id = 0;
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            id = db.People.Where(p => p.CCCD == cccd).First().ID_Person;
            return id;
        }
        public void addPerson(Person per)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.People.Add(per);
                db.SaveChanges();
            }
        }
        public void updatePerson(int id, string name, DateTime DOB, string CCCD, string phoneNum)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Person per = db.People.Where(p => p.ID_Person == id).First();
                per.Name = name;
                per.DOB = DOB;
                per.CCCD = CCCD;
                per.PhoneNum = phoneNum;
                db.SaveChanges();
            }
        }
        public void delPerson(int id)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Person per = db.People.Where(p => p.ID_Person == id).First();
                db.People.Remove(per);
                db.SaveChanges();
            }
        }
        public List<Account> getPersonsByType()
        {
            List<Account> list = new List<Account>();
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            list = db.Accounts.Where(p => p.Type > 1).ToList();
            return list;
        }
        public List<string> GetAllCCCD()
        {
            List<string> list = new List<string>();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                foreach (Person com in db.People)
                {
                    list.Add(com.CCCD.ToString());

                }
            }
            return list;
        }
        public void delPersonByCCCD(string CCCD)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Person per = db.People.Where(p => p.CCCD == CCCD).First();
                Salary sal = db.Salaries.Where(p => p.ID_Person == per.ID_Person).First();
                Account acc = db.Accounts.Where(p => p.ID_Person == per.ID_Person).First();
                db.Accounts.Remove(acc);
                db.People.Remove(per);
                db.Salaries.Remove(sal);
                db.SaveChanges();
            }
        }
        public bool checkCCCDPer(string cccd)
        {
            bool check = false;
            foreach (string i in GetAllCCCD())
            {
                if (i == cccd)
                    check = true;
            }
            return check;
        }
        public Person GetPersonByCCCD(string cccd)
        {
            Person per = new Person();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                per = db.People.Where(p => p.CCCD == cccd).First();
            }
            return per;
        }
        public void resetWork(string cccd)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Accounts.Where(p => p.Person.CCCD == cccd).First().Works = 0;
                db.SaveChanges();
            }
        }
    }
}