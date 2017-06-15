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

        public static int maxnhom(int madoan)
        {
            return NHOMDAO.maxnhom(madoan);
        }

        public static string Laytruongnhom(int madoan, int manhom)
        {
            return NHOMDAO.Laytruongnhom(madoan, manhom);
        }
    }
}
