using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PBL3_LastReal.DTO;

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
                if (instance == null)
                {
                    instance = new ManageAccount();
                }
                return instance;
            }
            private set { }
        }
        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                type = (int)db.Accounts.Where(p => p.Username == usernamef).First().Type;
            }
            return type;
        }
        public int getMoneyRemain(string usernamef)
        {
            int money = -1;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                money = (int)db.Accounts.Where(p => p.Username == usernamef).First().Money;
            }
            return money;
        }
        public void editMoneyRemain(string id_acc, int amount)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Account acc = db.Accounts.Where(p => p.ID_Account == id_acc).First();
                acc.Money -= amount;
                db.SaveChanges();
            }
        }
        public string getID(string usernamef)
        {
            string id = "";
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                id = db.Accounts.Where(p => p.Username == usernamef).First().ID_Account;
            }
            return id;
        }
        public bool checkPassword(string ID_Account, string Password)
        {
            bool check = false;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                string password = MD5Hash(Password);
                if (db.Accounts.Where(p => p.ID_Account == ID_Account && p.Password == password).Count() == 1)
                    check = true;
            }
            return check;
        }
        public void changePassword(string ID_Account, string newPassword)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                string password = MD5Hash(newPassword);
                db.Accounts.Where(p => p.ID_Account == ID_Account).First().Password = password;
                db.SaveChanges();
            }
        }
        public int getNextID_Acc(string type)
        {
            int nextID = 0;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                if(type == "client")
                {
                    List<Account> accounts = new List<Account>();
                    accounts = db.Accounts.Where(p => p.ID_Account.Contains(type)).ToList();
                    string lastID = accounts[accounts.Count - 1].ID_Account;
                    nextID = Convert.ToInt32(lastID.Substring(6, lastID.Length - 6));
                    nextID++;
                }  
                else if(type == "staff")
                {
                    List<Account> accounts = new List<Account>();
                    accounts = db.Accounts.Where(p => p.ID_Account.Contains(type)).ToList();
                    string lastID = accounts[accounts.Count - 1].ID_Account;
                    nextID = Convert.ToInt32(lastID.Substring(5, lastID.Length - 5));
                    nextID++;
                }
                else if (type == "guard")
                {
                    List<Account> accounts = new List<Account>();
                    accounts = db.Accounts.Where(p => p.ID_Account.Contains(type)).ToList();
                    string lastID = accounts[accounts.Count - 1].ID_Account;
                    nextID = Convert.ToInt32(lastID.Substring(5, lastID.Length - 5));
                    nextID++;
                }
                else if (type == "cashier")
                {
                    List<Account> accounts = new List<Account>();
                    accounts = db.Accounts.Where(p => p.ID_Account.Contains(type)).ToList();
                    string lastID = accounts[accounts.Count - 1].ID_Account;
                    nextID = Convert.ToInt32(lastID.Substring(7, lastID.Length - 7));
                    nextID++;
                }

            }
            return nextID;
        }
        private Account GetAccountByID_Acc(string id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            return db.Accounts.Where(p => p.ID_Account == id).First();
        }
        public Account GetAccountByID_Com(int id)
        {
            Account acc = new Account();
            History his = new History();
            List<History> list = new List<History>();
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            list = db.Histories.Where(p => p.Computer.ID_Computer == id).ToList();
            his = list[list.Count - 1];
            acc = GetAccountByID_Acc(his.ID_Account);
            return acc;
        }
        public Account GetAccountByUsername(string username)
        {
            Account acc = new Account();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                acc = db.Accounts.Where(p => p.Username == username).First();
            }
            return acc;
        }
        public void addAccount(string id, string username, string passwordf, int type, int money, int idper)
        {
            Account acc = new Account
            {
                ID_Account = id,
                Username = username,
                Password = MD5Hash(passwordf),
                Type = type,
                Money = money,
                ID_Person = idper,
            };
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Accounts.Add(acc);
                db.SaveChanges();
            }
        }
        public void updateAccount(string username, string passwordf, int money)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Account acc = db.Accounts.Where(p => p.Username == username).First();
                acc.Password = MD5Hash(passwordf);
                acc.Money += money;
                db.SaveChanges();
            }
        }
        public void delAccount(string username)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Account acc = db.Accounts.Where(p => p.Username == username).First();
                db.Accounts.Remove(acc);
                db.SaveChanges();
            }
        }
        public void rechargeByUsername(string username, int money)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Accounts.Where(p => p.Username == username).First().Money += money;
                db.SaveChanges();
                ManageBill.Instance.addBill(money, 1, DateTime.Now);
            }
        }
        public void editRechargeMoney(string username, int money)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Accounts.Where(p => p.Username == username).First().Money = money;
                db.SaveChanges();
            }
        }
        public Account getAccountByID_per(int id_per)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            return db.Accounts.Where(p => p.ID_Person == id_per).First();
        }
        public void addWork(string id_acc, int amount)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Accounts.Where(p => p.ID_Account == id_acc).First().Works += amount;
                db.SaveChanges();
            }
        }
    }
}