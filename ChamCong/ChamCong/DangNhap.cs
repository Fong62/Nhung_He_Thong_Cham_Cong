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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DangNhapBLL dangNhapBLL = new DangNhapBLL();
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buttonDN_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textTenDN.Text) || string.IsNullOrWhiteSpace(textMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rows = dangNhapBLL.CheckDN(textTenDN.Text, textMK.Text);

                if (rows > 0)
                {
                  
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    this.Hide();

                    // Mở FormMain
                    using (FormMain form = new FormMain())
                    {
                        form.ShowDialog();
                    }

                    
                    this.Close();
                }
                else
                {
                 
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
             
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
