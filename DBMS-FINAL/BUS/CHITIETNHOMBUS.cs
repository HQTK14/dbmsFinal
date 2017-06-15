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
    public class CHITIETNHOMBUS
    {
        public static DataTable layCTNhom(int manhom)
        {
            return CHITIETNHOMDAO.layCTNhom(manhom);
        }

        public static int dangkiNhom(CHITIETNHOMDTO ctDTO)
        {
            return CHITIETNHOMDAO.dangkiNhom(ctDTO);
        }

        public static int maxMemberNhom(int manhom, int madoan)
        {
            return CHITIETNHOMDAO.maxMemberNhom(manhom, madoan);
        }
    }
}
