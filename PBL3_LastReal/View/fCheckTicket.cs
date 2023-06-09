﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;

namespace PBL3_LastReal.View
{
    public partial class fCheckTicket : Form
    {
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fCheckTicket()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string ticket = tb_ticket.Text;
            try
            {
                Ticket tic = ManageTicket.Instance.delTicket(ticket);
                UpdateDGV();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
        }
    }
}
