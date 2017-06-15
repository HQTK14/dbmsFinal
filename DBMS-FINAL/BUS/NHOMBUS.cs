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
   public  class NHOMBUS
    {
        public static DataTable layDSNhom(int madoan)
        {
            return NHOMDAO.layDSNhom(madoan);
        }
        public static int TaoNhomMoi(string tennhom, int madoan, string truongnhom)
        {
            return NHOMDAO.TaoNhomMoi(tennhom, madoan, truongnhom);
        }
    }
}
