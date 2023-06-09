using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_LastReal.DTO;
using PBL3_LastReal.BLL;
namespace PBL3_LastReal.View
{
    public partial class fSecurity : Form
    {
        public fSecurity()
        {
            InitializeComponent();
            Gui();
        }
        private void Gui()
        {
             using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                dgv_vehicle.DataSource = db.Tickets.Select(p => new { p.ID_Ticket, p.Vehicle.Person.Name, p.Vehicle.Person.DOB, p.Vehicle.Person.CCCD, p.Vehicle.Person.PhoneNum,p.Vehicle.LicensePlates,p.Vehicle.ArrivalTime}).ToList();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_cccd.Text = "";
            tb_licensePlates.Text = "";
            tb_sdt.Text = "";
            tb_ticket.Text = "";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string lp = tb_licensePlates.Text;
            string cccd = tb_cccd.Text;
            string sdt = tb_sdt.Text;
            string ticket = tb_ticket.Text;
            dgv_vehicle.DataSource = ManageTicket.Instance.getBySearch(name, lp, cccd, sdt, ticket).Select(p => new { p.ID_Ticket, p.Vehicle.Person.Name, p.Vehicle.Person.DOB, p.Vehicle.Person.CCCD, p.Vehicle.Person.PhoneNum, p.Vehicle.LicensePlates, p.Vehicle.ArrivalTime }).ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            fCheckTicket f = new fCheckTicket();
            f.UpdateDGV += new fCheckTicket.UpdateDGVHandler(Gui);
            f.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddVehicle f = new fAddVehicle();
            f.UpdateDGV += new fAddVehicle.UpdateDGVHandler(Gui);
            f.ShowDialog();
        }
    }
}
