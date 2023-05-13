﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;

namespace PBL3_LastReal.BLL
{
    public class ManageWorkShift
    {
        private static ManageWorkShift instance;
        private ManageWorkShift() { }
        public static ManageWorkShift Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageWorkShift();
                }
                return instance;
            }
            private set { }
        }
        public List<WorkShift> GetWorkShifts(int type, DateTime date)
        {
            List<WorkShift> listws = new List<WorkShift>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                listws = db.WorkShifts.Where(p => p.Type == type && p.Date == date).ToList();
            }
            return listws;
        }
        public List<WorkShift> GetWorkShifts(DateTime date)
        {
            List<WorkShift> listws = new List<WorkShift>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                listws = db.WorkShifts.Where(p => p.Date == date).ToList();
            }
            return listws;
        }
        public WorkShift GetWorkShift(DateTime date, DateTime timeBegin, DateTime timeEnd)
        {
            WorkShift ws = new WorkShift();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                ws = db.WorkShifts.Where(p => p.Date == date && p.TimeBegin == timeBegin && p.TimeEnd == timeEnd).First();
            }
            return ws;
        }
        public List<Account> getAllStaffs(int type)
        {
            List<Account> listper = new List<Account>();
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            listper = db.Accounts.Where(p => p.Type == type).ToList();
            return listper;
        }
        public List<Account> GetStaffs(WorkShift ws)
        {
            List<Account> listper = new List<Account>();
            List<string> listid_per = new List<string>();
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            foreach (DetailWorkShift record in db.DetailWorkShifts)
            {
                if (record.ID_WorkShift == ws.ID_WorkShift)
                {
                    listid_per.Add((string)record.ID_Account);
                }
            }
            foreach (string id in listid_per)
            {
                listper.Add(db.Accounts.Where(p => p.ID_Account == id).First());
            }
            return listper;
        }
        public bool checkValidTime(DateTime begin, DateTime end)
        {
            bool check = true;
            if (begin.CompareTo(end) >= 0)
            {
                check = false;
            }
            return check;
        }
        public void AddWorkShift(WorkShift ws)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.WorkShifts.InsertOnSubmit(ws);
                db.SubmitChanges();
            }
        }
        public void DeleteWorkShift(WorkShift ws)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                WorkShift delete = new WorkShift();
                foreach (WorkShift item in db.WorkShifts)
                {
                    if (ws.ID_WorkShift == item.ID_WorkShift)
                    {
                        delete = item;
                        break;
                    }
                }
                foreach (DetailWorkShift item in db.DetailWorkShifts)
                {
                    if (item.ID_WorkShift == delete.ID_WorkShift)
                    {
                        this.RemoveDetailWorkShift(item.ID_Detail);
                    }
                }
                db.WorkShifts.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
        }
        public void UpdateWorkShift(int id, DateTime timeBegin, DateTime timeEnd)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                WorkShift update = db.WorkShifts.Where(p => p.ID_WorkShift == id).First();
                update.TimeBegin = timeBegin;
                update.TimeEnd = timeEnd;
                db.SubmitChanges();
            }
        }
        private void AddDetailWorkShift(List<DetailWorkShift> listdetail)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.DetailWorkShifts.InsertAllOnSubmit(listdetail);
                db.SubmitChanges();
            }
        }
        private void RemoveDetailWorkShift(int id_detail)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                foreach (DetailWorkShift item in db.DetailWorkShifts)
                {
                    if (item.ID_Detail == id_detail)
                    {
                        db.DetailWorkShifts.DeleteOnSubmit(item);
                        db.SubmitChanges();
                    }
                }
            }
        }
        public void SyncStaffs(WorkShift ws, List<Account> listper)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                List<DetailWorkShift> listdelete = db.DetailWorkShifts.Where(p => p.ID_WorkShift == ws.ID_WorkShift).ToList();
                foreach (DetailWorkShift item in listdelete)
                {
                    RemoveDetailWorkShift(item.ID_Detail);
                }

                List<DetailWorkShift> listadd = new List<DetailWorkShift>();
                foreach (Account per in listper)
                {
                    listadd.Add(new DetailWorkShift
                    {
                        ID_WorkShift = ws.ID_WorkShift,
                        ID_Account = per.ID_Account
                    });
                }
                AddDetailWorkShift(listadd);
            }
        }
    }
}
