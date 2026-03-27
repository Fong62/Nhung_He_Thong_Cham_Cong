using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ChamCong
{
    public partial class DangKy : Form
    {

        public DangKy()
        {
            InitializeComponent();
            timer1.Interval = 2500;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        DangKyBLL dangKyBLL = new DangKyBLL();

        private void LoadNV()
        {
            grid_NV.DataSource = dangKyBLL.LayBangNV();
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void grid_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                textID.Text = grid_NV.Rows[e.RowIndex].Cells["ID_The"].Value.ToString();
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            dangKyBLL.Update(textID.Text, textTenNV.Text);
            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadNV();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNV();
        }
    }
}
