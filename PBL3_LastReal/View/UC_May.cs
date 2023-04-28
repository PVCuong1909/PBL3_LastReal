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

        private void btn_SeeHistory_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count == 1)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                fSeeHistory f = new fSeeHistory(id);
                f.ShowDialog();
            }
            else if(dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn máy cần xem lịch sử!");
            }
            else
            {
                MessageBox.Show("Không thêm xem nhiều máy cùng một lúc!");
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv.SelectedRows.Count == 1)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string state = dgv.SelectedRows[0].Cells[3].Value.ToString();
                if(state == "1")
                {
                    tb_id.Text = ManageComputer.Instance.getComputerByID(id).ID_Computer.ToString();
                    tb_price.Text = ManageComputer.Instance.getComputerByID(id).Price.ToString();
                    tb_type.Text = ManageComputer.Instance.getComputerByID(id).Type.ToString();
                    if (ManageComputer.Instance.getComputerByID(id).State.ToString() == "0")
                    {
                        tb_state.Text = "Chưa sử dụng";
                    }
                    else if (ManageComputer.Instance.getComputerByID(id).State.ToString() == "1")
                    {
                        tb_state.Text = "Đang sử dụng";
                    }
                    else if (ManageComputer.Instance.getComputerByID(id).State.ToString() == "2")
                    {
                        tb_state.Text = "Đang hỏng";
                    }

                    tb_IDTK.Text = ManageHistory.Instance.getHistotyByIDAndTimeBeginAcc(id).ID_Account;
                    tb_money.Text = ManageHistory.Instance.getHistotyByIDAndTimeBeginAcc(id).Money.ToString();
                    tb_username.Text = ManageHistory.Instance.getHistotyByIDAndTimeBeginAcc(id).Username;
                    tb_name.Text = ManageHistory.Instance.getHistoryByIDAndTimeBeginPer(id).Name;

                }
                else
                {
                    tb_id.Text = ManageComputer.Instance.getComputerByID(id).ID_Computer.ToString();
                    tb_price.Text = ManageComputer.Instance.getComputerByID(id).Price.ToString();
                    tb_type.Text = ManageComputer.Instance.getComputerByID(id).Type.ToString();
                    if(ManageComputer.Instance.getComputerByID(id).State.ToString() == "0")
                    {
                        tb_state.Text = "Chưa sử dụng";
                    }
                    else if (ManageComputer.Instance.getComputerByID(id).State.ToString() == "1")
                    {
                        tb_state.Text = "Đang sử dụng";
                    }
                    else if (ManageComputer.Instance.getComputerByID(id).State.ToString() == "2")
                    {
                        tb_state.Text = "Đang hỏng";
                    }
                }
            }
        }
    }
}
