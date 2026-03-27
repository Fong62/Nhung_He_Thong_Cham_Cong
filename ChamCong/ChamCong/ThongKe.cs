using OfficeOpenXml;
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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private ChamCongBLL chamCongBLL = new ChamCongBLL();

        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo worksheet mới cho hợp đồng
                ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Công");

                // Xuất tiêu đề cho worksheet 1
                worksheet1.Cells[1, 1].Value = "Thống Kê Công Nhân Viên";
                worksheet1.Cells[1, 1].Style.Font.Bold = true;
                worksheet1.Cells[1, 1].Style.Font.Size = 20;
                worksheet1.Cells[1, 1, 1, 6].Merge = true;
                worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet1.Cells[1, 1].Value = "Ngày" + DateTime.Parse(cbo_Ngay.Text.ToString()).ToString("dd/MM/yyyy");
                worksheet1.Cells[1, 1].Style.Font.Bold = true;
                worksheet1.Cells[1, 1].Style.Font.Size = 20;
                worksheet1.Cells[1, 1, 1, 6].Merge = true;
                worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Tiêu đề cột cho worksheet 1
                worksheet1.Cells[4, 1].Value = "ID Thẻ";
                worksheet1.Cells[4, 2].Value = "Tên";
                worksheet1.Cells[4, 3].Value = "Ngày";
                worksheet1.Cells[4, 4].Value = "Thời Gian Vào";
                worksheet1.Cells[4, 5].Value = "Thời Gian Ra";
                worksheet1.Cells[4, 6].Value = "Số Công";

                // Xuất dữ liệu từ grid_HD1
                int rowIndex = 5;
                foreach (DataGridViewRow row in grid_TK.Rows)
                {
                    if (row.Cells["ID_The"].Value != null)
                    {
                        worksheet1.Cells[rowIndex, 1].Value = row.Cells["ID_The"].Value.ToString();
                        worksheet1.Cells[rowIndex, 2].Value = row.Cells["Ten"].Value.ToString();
                        worksheet1.Cells[rowIndex, 3].Value = row.Cells["NGAY"].Value.ToString();
                        worksheet1.Cells[rowIndex, 4].Value = row.Cells["Thoi_Gian_Vao"].Value.ToString();
                        worksheet1.Cells[rowIndex, 5].Value = row.Cells["Thoi_Gian_Ra"].Value.ToString();
                        worksheet1.Cells[rowIndex, 5].Style.Numberformat.Format = "dd/MM/yyyy";
                        worksheet1.Cells[rowIndex, 6].Value = Convert.ToDecimal(row.Cells["So_Cong"].Value.ToString());

                    }
                    rowIndex++;
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();

                // Lưu file Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);

                MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.FileName = "Thống Kê Công " + cbo_Ngay.Text + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }

        private void LoadChamCong()
        {
            grid_TK.DataSource = chamCongBLL.LayChamCong();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string search = txt_TimKiem.Text;
            string ngay = cbo_Ngay.Text;

            if (string.IsNullOrEmpty(search) && string.IsNullOrEmpty(ngay))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = chamCongBLL.TimKiemNhanVien(search, ngay);
                grid_TK.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadChamCong();
            List<string> dsngay = chamCongBLL.LayDanhSachNgay();
            cbo_Ngay.Items.Clear();
            foreach (string ngay in dsngay)
            {
                if (DateTime.TryParse(ngay, out DateTime parsedDate))
                {
                    cbo_Ngay.Items.Add(parsedDate.ToString("yyyy-MM-dd"));
                }
            }
        }
    }
}
