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
   public class MONHOCBUS
    {
        public static IList<MONHOCDTO> LAYDSMONHOC(string maSV)
        {
            return MONHOCDAO.LAYDSMONHOC(maSV);
        }
        public static DataTable _LAYDSMONHOC(string maSV)
        {
            return MONHOCDAO._LAYDSMONHOC(maSV);
        }
    }
}
