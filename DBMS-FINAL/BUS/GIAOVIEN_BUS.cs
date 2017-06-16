using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class GIAOVIEN_BUS
    {
        public static DataTable layDanhSachDoAnPhuTrach_Mon(string maGV, string mamon)
        {
            return GIAOVIEN_DAO.layDanhSachDoAnPhuTrach_Mon(maGV, mamon);
        }
        //public static DataTable layDanhSachDoAnPhuTrach_Mon(string maGV, string maMon)
        //{
        //    return GIAOVIEN_DAO.layDanhSachDoAnPhuTrach_Mon(maGV, maMon);
        //}

        public static string DangNhap(string magv, string password)
        {
            return GIAOVIEN_DAO.DangNhap(magv, password);
        }

        public static GIAOVIENDTO LayGV(string username, string password)
        {
            return GIAOVIEN_DAO.LayGV(username, password);
        }

        public static DataTable layDSMONPT(string magv)
        {
            return layDSMONPT(magv);
        }
    }
}
