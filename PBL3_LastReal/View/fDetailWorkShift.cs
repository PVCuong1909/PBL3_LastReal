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
    public partial class fDetailWorkShift : Form
    {
        public delegate void UpdateDataHandler();
        public event UpdateDataHandler UpdateData;
        int id;
        DateTime date;
        public fDetailWorkShift(DateTime date, WorkShift ws)
        {
            InitializeComponent();
            this.date = date;
            GUI(ws);
        }

        private void GUI(WorkShift ws)
        {
            cbb_Type.Items.AddRange(new object[] { "Nhân viên", "Thu ngân", "Bảo vệ" });
            if(ws != null)
            {
                id = ws.ID_WorkShift;
                cbb_Type.Text = cbb_Type.Items[(int)ws.Type].ToString();
                cbb_Type.Enabled = false;
                dtp_Begin.Text = ToolTime.Instance.getTime(ws.TimeBegin.Value);
                dtp_End.Text = ToolTime.Instance.getTime(ws.TimeEnd.Value);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int type = cbb_Type.SelectedIndex;
            DateTime timeBeginValue = dtp_Begin.Value;
            DateTime timeEndValue = dtp_End.Value;
            string str_date = ToolTime.Instance.getDate(date);
            string str_timeBegin = ToolTime.Instance.getTime(timeBeginValue);
            string str_timeEnd = ToolTime.Instance.getTime(timeEndValue);
            DateTime trueTimeBegin = ToolTime.Instance.trueTime(str_timeBegin, str_date);
            DateTime trueTimeEnd = ToolTime.Instance.trueTime(str_timeEnd, str_date);
            
            if(type == -1)
            {
                MessageBox.Show("Hãy chọn loại ca");
            }
            else if(ManageWorkShift.Instance.checkValidTime(trueTimeBegin, trueTimeEnd) == false)
            {
                MessageBox.Show("Khoảng thời gian không hợp lệ");
            }
            else
            {
                if(cbb_Type.Enabled == true)
                {
                    ManageWorkShift.Instance.AddWorkShift(new WorkShift
                    {
                        Type = type,
                        TimeBegin = trueTimeBegin,
                        TimeEnd = trueTimeEnd,
                        Date = date
                    });
                    MessageBox.Show("Tạo ca thành công");
                }
                else
                {
                    ManageWorkShift.Instance.UpdateWorkShift(id, trueTimeBegin, trueTimeEnd);
                    MessageBox.Show("Cập nhật thông tin ca thành công");
                }
                UpdateData();
                this.Close();
            }    
        }
    }
}
