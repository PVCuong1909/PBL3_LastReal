using PBL3_LastReal.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL3_LastReal.View
{
    public partial class UC_May : UserControl
    {
        public UC_May()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            dgv.DataSource = ManageComputer.Instance.getAllComputer();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditComputer f = new fAddEditComputer(null);
            f.UpdateDGV += new fAddEditComputer.UpdateDGVHandler(GUI);
            f.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count == 1) 
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Computer s = ManageComputer.Instance.getComputerByID(id);
                fAddEditComputer f = new fAddEditComputer(s);
                f.UpdateDGV += new fAddEditComputer.UpdateDGVHandler(GUI);
                f.ShowDialog();
            }
            else if (dgv.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Chọn máy cần cập nhật!");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật được nhiều máy!");
            } 
                
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0) 
            {
                foreach(DataGridViewRow row in dgv.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString();
                    ManageComputer.Instance.deleteComputer(id);
                }
                MessageBox.Show("Xóa máy thành công!");
                GUI();
            }
            else
            {
                MessageBox.Show("Chọn máy cần xóa!");
            } 
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string txt = tb_search.Text;
            if(cb_using.Checked)
            {
                dgv.DataSource = ManageComputer.Instance.getComputersStateUsed(txt);
            }
            else if (cb_free.Checked)
            {
                dgv.DataSource = ManageComputer.Instance.getComputersStateFree(txt);
            }
            else
            {
                GUI();
            }    
        }
    }
}
