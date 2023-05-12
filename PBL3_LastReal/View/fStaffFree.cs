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

namespace PBL3_LastReal.View
{
    public partial class fStaffFree : Form
    {
        WorkShift value;
        List<Person> selected_staffs;
        List<Person> free_staffs;
        public fStaffFree(WorkShift ws)
        {
            InitializeComponent();
            value = ws;
            selected_staffs = ManageWorkShift.Instance.GetStaffs(value);
            free_staffs = ManageWorkShift.Instance.getAllStaffs();
            GUI();
        }
        private void GUI()
        {
            
            foreach (Person selected in selected_staffs)
            {
                foreach (Person free in free_staffs)
                {
                    if(selected.ID_Person == free.ID_Person) 
                    {
                        free_staffs.Remove(free);
                        break;  
                    }
                }
            }

            dgv_Free.DataSource = free_staffs.Select(p => new 
            {
                p.Name,
                p.DOB,
                p.PhoneNum,
                p.CCCD
            }).ToList();

            dgv_Staff.DataSource = selected_staffs.Select(p => new
            {
                p.Name,
                p.DOB,
                p.PhoneNum,
                p.CCCD
            }).ToList();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(dgv_Free.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Free.SelectedRows)
                {
                    string CCCD = row.Cells["CCCD"].Value.ToString();
                    int id_per = ManagePerson.Instance.getIDPersonByCCCD(CCCD);
                    Person p = ManagePerson.Instance.GetPerson(id_per);

                    selected_staffs.Add(p);
                    foreach (Person per in free_staffs)
                    {
                        if(per.ID_Person == id_per)
                        {
                            free_staffs.Remove(per);
                            break;
                        }
                    }
                }
                GUI();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dgv_Staff.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Staff.SelectedRows)
                {
                    string CCCD = row.Cells["CCCD"].Value.ToString();
                    int id_per = ManagePerson.Instance.getIDPersonByCCCD(CCCD);
                    Person p = ManagePerson.Instance.GetPerson(id_per);

                    free_staffs.Add(p);
                    foreach (Person per in selected_staffs)
                    {
                        if (per.ID_Person == id_per)
                        {
                            selected_staffs.Remove(per);
                            break;
                        }
                    }
                }
                GUI();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ManageWorkShift.Instance.SyncStaffs(value, selected_staffs);
            MessageBox.Show("Cập nhật danh sách nhân viên thành công");
            this.Close();
        }
    }
}
