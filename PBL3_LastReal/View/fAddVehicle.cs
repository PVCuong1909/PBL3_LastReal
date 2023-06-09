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
    public partial class fAddVehicle : Form
    {
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fAddVehicle()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string dob = dtp_dob.Value.ToString();
            string cccd = tb_cccd.Text;
            string sdt = tb_sdt.Text;
                ManageTicket.Instance.addTicket(name, dob, cccd, sdt, tb_lp.Text);
                UpdateDGV();
                this.Dispose();
        }
    }
}
