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
        //public static IList<MONHOCDTO> LAYDSMONHOC(string maSV)
        //{
        //    return MONHOCDAO.LAYDSMONHOC(maSV);
        //}
        public static DataTable _LAYDSMONHOC(string maSV)
        {
            return MONHOCDAO._LAYDSMONHOC(maSV);
        }
        public static bool Create_Update_Subject(MONHOCDTO mhDTO, string opt)
        {
            return Create_Update_Subject(mhDTO, opt);
        }

        public static bool Remove_Subject(string mamon)
        {
            return Remove_Subject(mamon);
        }

        public static bool Disable_Subject(string start, string end, string mamon)
        {
            return Disable_Subject(start, end, mamon);
        }

        public static bool Enable_Subject(string mamon)
        {
            return Enable_Subject(mamon);
        }
        public static DataTable GET_ALL_SUBJECT()
        {
            return MONHOCDAO.GET_ALL_SUBJECT();
        }
    }
}
