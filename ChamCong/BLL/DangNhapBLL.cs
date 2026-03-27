using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;
namespace BLL
{
    public class DangNhapBLL
    {
        DataAccess dataAccess = new DataAccess();
        public int CheckDN(string tendn,string mk) 
        {
            string query = "SELECT COUNT(*) FROM TAI_KHOAN WHERE TenDN = @tendn and MK = @mk";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tendn",tendn),
                new SqlParameter("@mk",mk)
            };
            return (int)dataAccess.ExecuteScalar(query, parameters);
        }
    }
}
