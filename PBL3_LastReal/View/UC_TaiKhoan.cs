﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_LastReal.View
{
    public partial class UC_TaiKhoan : UserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditAccount f = new fAddEditAccount();
            f.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            fAddEditAccount f = new fAddEditAccount();
            f.ShowDialog();
        }

        private void btn_Password_Click(object sender, EventArgs e)
        {
            fAdminPassword f = new fAdminPassword();
            f.ShowDialog();
        }

    }
}
