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
        private string MD5Hash(string input)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
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
    }
}
