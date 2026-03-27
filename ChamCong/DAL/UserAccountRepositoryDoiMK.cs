using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserAccountRepositoryDoiMK
    {
        private readonly string connstring = "Data Source=PHONG;Initial Catalog=QLXUATNHAPKHAU;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";

        // Phương thức cập nhật mật khẩu
        public bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TAI_KHOAN SET MATKHAU = @newpassword WHERE TENDANGNHAP = @username", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@newpassword", newPassword);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                    return false; 
                }
            }
        }
    }
}
