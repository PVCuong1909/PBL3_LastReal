using PBL3_LastReal.BLL;
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


namespace PBL3_LastReal.View
{
    public partial class uc_DetailWorkShift : UserControl
    {
        WorkShift instance;
        public uc_DetailWorkShift(WorkShift ws)
        {
            InitializeComponent();
            instance = ws;
            tb_TimeBegin.Text = instance.TimeBegin.Value.ToString("hh:mm tt");
            tb_TimeEnd.Text = instance.TimeEnd.Value.ToString("hh:mm tt");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (this.Parent.Controls.ContainsKey("detail_1"))
            {
                this.Parent.Controls["detail_1"].BackColor = SystemColors.ControlLight;
            }
            if (this.Parent.Controls.ContainsKey("detail_2"))
            {
                this.Parent.Controls["detail_2"].BackColor = SystemColors.ControlLight;
            }
            if (this.Parent.Controls.ContainsKey("detail_3"))
            {
                this.Parent.Controls["detail_3"].BackColor = SystemColors.ControlLight;
            }

            this.BackColor = SystemColors.GrayText;


            if(this.ParentForm.Controls.ContainsKey("dgv_Person"))
            {
                this.ParentForm.Controls.RemoveByKey("dgv_Person");
            }

            DataGridView dgv_Person = new DataGridView();
            dgv_Person.Name = "dgv_Person";
            dgv_Person.Location = new Point(410, 120);
            dgv_Person.Size = new Size(390, 200);
            dgv_Person.DataSource = ManageWorkShift.Instance.GetStaffs(instance).Select(p => new {p.Person.Name, p.Person.PhoneNum, p.Person.CCCD}).ToList();
            this.ParentForm.Controls.Add(dgv_Person);
        }
    }
}
