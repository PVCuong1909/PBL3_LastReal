using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_LastReal.BLL
{
    public class ManageAccount
    {
        private static ManageAccount instance;
        private ManageAccount() { }
        public static ManageAccount Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ManageAccount();
                }
                return instance;
            }
            private set {} 
        }
        public List<Account> GetAccounts() 
        {
            List<Account> accounts = new List<Account>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                accounts = db.Accounts.ToList();
            }
            return accounts;
        }
        private string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }
            }
            return hash.ToString();
        }
        public bool checkLogIn(string username, string passwordf)
        {
            bool check = false;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                string password = MD5Hash(passwordf);
                if (db.Accounts.Where(p => p.Username == username && p.Password == password).Count() > 0)
                    check = true;
            }
            return check;
        }
        public int getType(string usernamef) 
        {
            int type = -1;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                type = (int)db.Accounts.Where(p => p.Username == usernamef).First().Type;
            }
            return type;
        }
        public int getMoneyRemain(string usernamef) 
        {
            int money = -1;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                money = (int)db.Accounts.Where(p => p.Username == usernamef).First().Money;
            }
            return money;
        }
        public string getID(string usernamef) 
        {
            string id = "";
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                id = db.Accounts.Where(p => p.Username == usernamef).First().ID_Account;
            }
            return id;
        }
        public bool checkPassword(string ID_Account, string Password)
        {
            bool check = false;
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                string password = MD5Hash(Password);
                if(db.Accounts.Where(p => p.ID_Account == ID_Account && p.Password == password).Count() == 1)
                    check = true;
            }
            return check;
        }
        public void changePassword(string ID_Account, string newPassword)
        {
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                string password = MD5Hash(newPassword);
                db.Accounts.Where(p => p.ID_Account == ID_Account).First().Password = password;
                db.SubmitChanges();
            }    
        }
        public int getNextID_Acc(string type)
        {
            int nextID = 0;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                List<Account> accounts = new List<Account>();
                accounts = db.Accounts.Where(p => p.ID_Account.Contains(type)).ToList();
                string lastID = accounts[accounts.Count - 1].ID_Account;
                nextID = Convert.ToInt32(lastID.Substring(6, lastID.Length - 6));
                nextID++;
            }
            return nextID;
        }
        public Account GetAccountByUsername(string username)
        {
            Account acc = new Account();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                acc = db.Accounts.Where(p => p.Username == username).First();
            }
            return acc;
        }
        public void addAccount(string id,string username, string passwordf, int type, int money, int idper)
        {
            Account acc = new Account
            {
                ID_Account = id,
                Username = username,
                Password = MD5Hash(passwordf),
                Type = type,
                Money = money,
                ID_Person = idper
            };
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Accounts.InsertOnSubmit(acc);
                db.SubmitChanges();
            }
        }
        public void updateAccount(string username, string passwordf, int money)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Account acc = db.Accounts.Where(p => p.Username == username).First();
                acc.Password = MD5Hash(passwordf);
                acc.Money += money;
                db.SubmitChanges();
            }
        }
        public void delAccount(string username)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Account acc = db.Accounts.Where(p => p.Username == username).First();
                db.Accounts.DeleteOnSubmit(acc);
                db.SubmitChanges();
            }
        }
    }
}
