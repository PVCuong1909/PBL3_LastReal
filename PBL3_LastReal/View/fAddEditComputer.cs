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

    public partial class fAddEditComputer : Form
    {
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fAddEditComputer(Computer s)
        {
            InitializeComponent();
            GUI(s);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void GUI(Computer s)
        {
            cbb_state.Items.AddRange(ManageComputer.Instance.getCCBState().ToArray());
            if(s !=null)
            {
                tb_ID.Text = s.ID_Computer.ToString();
                tb_ID.Enabled = false;
                tb_price.Text = s.Price.ToString();
                tb_type.Text = s.Type.ToString();
                if (s.State == 0)
                {
                    cbb_state.Text = "Chưa sử dụng";
                }
                else if (s.State == 1)
                {
                    cbb_state.Text = "Đang sử dụng";
                }
                else if (s.State == 2)
                {
                    cbb_state.Text = "Đang hỏng";
                }
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string ID_Computer = tb_ID.Text;
            string Price = tb_price.Text;
            string Type = tb_type.Text;
            string State = cbb_state.Text;
            if(ID_Computer == "" || Price == "" || Type == "" || State == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if(ManageComputer.Instance.checkIDMay(ID_Computer) == true && tb_ID.Enabled == false)
                {
                    ManageComputer.Instance.updateComputer(ID_Computer, Price, Type, State);
                    MessageBox.Show("Cập nhật thông tin máy thành công!");
                }
                else if(ManageComputer.Instance.checkIDMay(ID_Computer) == false)
                {
                    ManageComputer.Instance.addComputer(ID_Computer, Price, Type, State);
                    MessageBox.Show("Thêm máy thành công!");
                }
                else
                {
                    MessageBox.Show("Mã máy trùng trong danh sách!");
                } 
                UpdateDGV();
                this.Dispose();
            }
        }
    }
}
