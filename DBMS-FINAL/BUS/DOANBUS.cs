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
    public class DOANBUS
    {
        public static DataTable LocDSDA(string mamon, string mssv, int option = 0)
        {
            return DOANDAO.LocDSDA(mamon, mssv, option);
        }
    }
}
