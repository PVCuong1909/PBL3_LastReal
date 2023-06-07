using PBL3_LastReal.DTO;
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
    public partial class uc_Comp : UserControl
    {
        string ID;
        int state;
        public uc_Comp(int state, string ID)
        {
            InitializeComponent();
            this.ID = ID;
            this.state = state;
            GUI();
        }
        private void GUI()
        {
            label1.Text = "Máy " + this.ID;
            if(this.state == 0) 
            {
                this.guna2PictureBox1.Image = global::PBL3_LastReal.Properties.Resources.Green;
            }
            else if(this.state == 1) 
            {
                this.guna2PictureBox1.Image = global::PBL3_LastReal.Properties.Resources.Red;
            }
            else 
            {
                this.guna2PictureBox1.Image = global::PBL3_LastReal.Properties.Resources.Gray;
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            fService f = new fService(Convert.ToInt32(ID));
            f.ShowDialog();
        }
    }
}
