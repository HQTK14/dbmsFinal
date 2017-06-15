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
        public static int maxMemberNhom(int manhom, int madoan)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "CHECK_EXCEED_NUMBER_MEMBER_Of_GROUP";
                //SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                SqlCommand sqlcmd = new SqlCommand(ProcName);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Connection = cnn.connect;
                //SqlParameter[] prs =
                //{
                //    new SqlParameter("@MaDoAn", SqlDbType.Int),
                //    new SqlParameter("@KQ", SqlDbType.Int)
                //};
                //prs[0].Value = madoan;
                //prs[1].Direction = ParameterDirection.Output;
                //sqlcmd.Parameters.AddRange(prs);
                sqlcmd.Parameters.Add("@MaDoAn", SqlDbType.Int).Value =madoan;
                sqlcmd.Parameters.Add("@MaNhom", SqlDbType.Int).Value = manhom;
                sqlcmd.Parameters.Add("@KQ", SqlDbType.Int).Direction = ParameterDirection.Output;
                int n = sqlcmd.ExecuteNonQuery();
                if (n > 0)
                {
                    //int KQ = Convert.ToInt32(prs[1].Value.ToString());
                    int KQ = Convert.ToInt32(sqlcmd.Parameters["@KQ"].Value);
                    cnn.CloseSection();
                    if (KQ == 2)
                        return 1;
                    else
                        return 0;
                }
                else return -1;

            }

            catch
            {
                return -2;
            }
        }
    }
}
