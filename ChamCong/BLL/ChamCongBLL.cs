using DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChamCongBLL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable LayChamCong()
        {
            string query = @"Select STT , CHC.ID_The, NV.Ten, NGAY, Thoi_Gian_Vao, Thoi_Gian_Ra, So_Cong
                            from CHAM_CONG CHC 
                            left join NHAN_VIEN NV on NV.ID_The = CHC.ID_The";

            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayThongKe(DateTime ngay)
        {
            ngay = ngay.Date;

            string query = @"Select STT , CHC.ID_The, NV.Ten, NGAY, Thoi_Gian_Vao, Thoi_Gian_Ra, So_Cong
                            from CHAM_CONG CHC 
                            left join NHAN_VIEN NV on NV.ID_The = CHC.ID_The
                            Where NGAY = @NGAY";
            SqlParameter[] parameters = { new SqlParameter("@NGAY", ngay) };

            return dataAccess.ExecuteQuery(query, parameters);
        }

        public List<string> LayDanhSachNgay()
        {
            string query = "SELECT DISTINCT NGAY FROM CHAM_CONG";

            DataTable dsngay = dataAccess.ExecuteQuery(query);


            List<string> dsNgay = new List<string>();
            foreach (DataRow row in dsngay.Rows)
            {
                dsNgay.Add(row["NGAY"].ToString());
            }

            return dsNgay;
        }

        public DataTable TimKiemNhanVien(string search, string ngay)
        {
            string query = @"Select STT , CHC.ID_The, NV.Ten, NGAY, Thoi_Gian_Vao, Thoi_Gian_Ra, So_Cong
                            from CHAM_CONG CHC 
                            left join NHAN_VIEN NV on NV.ID_The = CHC.ID_The
                            Where 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(search) && string.IsNullOrEmpty(ngay))
            {
                query += " AND (CHC.ID_The = @search OR Ten LIKE N'%' + @search + '%')";
                parameters.Add(new SqlParameter("@search", search));
            }

            else if (string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(ngay))
            {
                query += " AND NGAY = @NGAY";
                parameters.Add(new SqlParameter("@NGAY", ngay));
            }

            else if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(ngay))
            {
                query += " AND (CHC.ID_The = @search OR ten LIKE N'%' + @search + '%') AND NGAY = @NGAY";
                parameters.Add(new SqlParameter("@search", search));
                parameters.Add(new SqlParameter("@NGAY", ngay));
            }

            return dataAccess.ExecuteQuery(query, parameters.ToArray());
        }
    }
}
