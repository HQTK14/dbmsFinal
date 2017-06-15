using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CHITIETNHOMDAO
    {
        public static DataTable layCTNhom(int manhom)
        {
            string sql = string.Format(@"
                                        SELECT sv.MSSV, sv.TENSV, sv.SDT
                                        FROM dbo.CHITIET_NHOM ct,
	                                         dbo.SINHVIEN sv
                                        WHERE ct.MaNhom = {0}
	                                          AND
	                                          ct.MaSV = sv.MSSV
                                      ",manhom
                                      );
            Connect_Helper cnn = new Connect_Helper();
            return cnn.GetDataTable(sql);
        }

        public static int dangkiNhom(CHITIETNHOMDTO ctDTO)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlParameter[] prs = {
                new SqlParameter("@MaNhom",SqlDbType.Int),
                new SqlParameter("@MaDoAn", SqlDbType.Int),
                new SqlParameter("@MaSV",SqlDbType.VarChar)};
                prs[0].Value = ctDTO.MaNhom;
                prs[1].Value = ctDTO.MaDA;
                prs[2].Value = ctDTO.MSSV;
                SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddRange(prs);
                int KQ = sqlcmd.ExecuteNonQuery();
                cnn.CloseSection();
                if (KQ > 0)
                    return 1;
                else return 0;
            }
            catch
            {
                return -1;
            }

        }
    }
}
