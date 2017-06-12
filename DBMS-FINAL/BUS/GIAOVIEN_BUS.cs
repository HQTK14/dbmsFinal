using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace BUS
{
    public class GIAOVIEN_BUS
    {
        public static List<string> layDanhSachMon_PhuTrach(string maGV)
        {
            return GIAOVIEN_DAO.layDanhSachMon_PhuTrach(maGV);
        }
        public static DataTable layDanhSachDoAnPhuTrach_Mon(string maGV, string maMon)
        {
            return GIAOVIEN_DAO.layDanhSachDoAnPhuTrach_Mon(maGV, maMon);
        }
    }
}
