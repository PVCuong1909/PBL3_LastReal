﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                per = db.Persons.Where(p => p.ID_Person == id).First();
            }
            return per;
        }
        public int getIDPersonByUsername(string username)
        {
            int id = 0;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                id = (int)db.Accounts.Where(p => p.Username == username).First().ID_Person;
            }
            return id;
        }
        public int getIDPersonByCCCD(string cccd)
        {
            int id = 0;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                id = db.Persons.Where(p => p.CCCD == cccd).First().ID_Person;
            }
            return id;
        }
        public void addPerson(Person per)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Persons.InsertOnSubmit(per);
                db.SubmitChanges();
            }
        }
        public void updatePerson(int id, string name, DateTime DOB, string CCCD, string phoneNum)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Person per = db.Persons.Where(p => p.ID_Person == id).First();
                per.Name = name;
                per.DOB = DOB;
                per.CCCD = CCCD;
                per.PhoneNum = phoneNum;
                db.SubmitChanges();
            }
        }
        public void delPerson(int id)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Person per = db.Persons.Where(p => p.ID_Person == id).First();
                db.Persons.DeleteOnSubmit(per);
                db.SubmitChanges();
            }
        }
        public List<Person> getPersonsByType() 
        {
            List<Person> list = new List<Person>();
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                list = db.Persons.Where(p => p.Type > 1).ToList();
            }    
            return list;
        }
        public List<string> GetAllCCCD()
        {
            List<string> list = new List<string>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                foreach (Person com in db.Persons)
                {
                    list.Add(com.CCCD.ToString());
                }
            }
            return list;
        }
        public void delPersonByCCCD(string CCCD)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Person per = db.Persons.Where(p => p.CCCD == CCCD).First();
                Salary sal = db.Salaries.Where(p => p.ID_Person == per.ID_Person).First();
                db.Persons.DeleteOnSubmit(per);
                db.Salaries.DeleteOnSubmit(sal);
                db.SubmitChanges();
            }
        }
        public bool checkCCCDPer(string cccd)
        {
            bool check = false;
            foreach(string i in GetAllCCCD())
            {
                if(i == cccd)
                    check = true;
            }    
            return check;
        }
        public Person GetPersonByCCCD(string cccd)
        {
            Person per = new Person();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                per = db.Persons.Where(p => p.CCCD == cccd).First();
            }
            return per;
        }
        public void resetWork(string cccd)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Persons.Where(p => p.CCCD == cccd).First().Works = 0;
                db.SubmitChanges();
            }
        }
    }
}