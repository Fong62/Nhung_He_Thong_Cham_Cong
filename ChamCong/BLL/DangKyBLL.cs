using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;

namespace BLL
{
    public class DangKyBLL
    {
        DataAccess dataAccess = new DataAccess();
        public DataTable LayBangNV()
        {
            string query = "SELECT * FROM NHAN_VIEN";
            return dataAccess.ExecuteQuery(query);
        }
        public void Update(string idthe,string ten)
        {
            string query = "UPDATE NHAN_VIEN SET Ten = @TEN WHERE ID_The = @IDTHE";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IDTHE",idthe),
                new SqlParameter("@TEN",ten)
            };
            dataAccess.ExecuteNonQuery(query, param);
        }
    }
}
