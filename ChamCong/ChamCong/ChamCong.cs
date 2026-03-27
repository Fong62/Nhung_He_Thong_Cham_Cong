using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamCong
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private ChamCongBLL chamCongBLL = new ChamCongBLL();

        private void LoadChamCong()
        {
            grid_CC.DataSource = chamCongBLL.LayChamCong();
        }
        private void ChamCong_Load(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChamCong();
        }
    }
}
