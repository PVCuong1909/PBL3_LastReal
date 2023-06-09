using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_LastReal.DTO;

namespace PBL3_LastReal.BLL
{
    public class ManageTicket
    {
        private static ManageTicket instance;
        private ManageTicket() { }
        public static ManageTicket Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageTicket();
                }
                return instance;
            }
            private set { }
        }
        public List<Ticket> getBySearch(string name, string lp, string cccd, string sdt, string ticket)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            List<Ticket> list = new List<Ticket>();
            list = db.Tickets.Where(p => p.Vehicle.Person.Name.Contains(name) && p.Vehicle.LicensePlates.Contains(lp) && p.Vehicle.Person.CCCD.Contains(cccd) && p.Vehicle.Person.PhoneNum.Contains(sdt) && p.ID_Ticket.ToString().Contains(ticket)).ToList();
            return list;
        }
        public Ticket delTicket(string ticket)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Ticket tic = db.Tickets.Where(p => p.ID_Ticket.ToString() == ticket).First();
            db.Tickets.Remove(tic);
            db.SaveChanges();
            return tic;
        }
        public void addTicket(string name, string dob, string cccd, string sdt, string lp) 
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Person per = new Person()
            {
                Name = name,
                DOB = Convert.ToDateTime(dob),
                CCCD = cccd,
                PhoneNum = sdt
            };
            db.People.Add(per);
            db.SaveChanges();
            Vehicle vehicle = new Vehicle()
            {
                LicensePlates = lp,
                ID_Person = per.ID_Person,
                ArrivalTime = DateTime.Now
            };
            db.Vehicles.Add(vehicle);
            db.SaveChanges();
            Ticket tic = new Ticket()
            {
                ID_Vehicle = vehicle.ID_Vehicle,
            };
            db.Tickets.Add(tic);
            db.SaveChanges();
        }
    }
}
