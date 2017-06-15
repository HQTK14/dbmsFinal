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
    public class NHOMDAO
    {
        public static DataTable layDSNhom(int madoan)
        {
            string sql = string.Format(@"
                                         SELECT*
                                         FROM dbo.NHOM nh
                                         WHERE nh.MaDA = {0}
                                       ", madoan
                                       );
            return new Connect_Helper().GetDataTable(sql);

        }
        
        public static int TaoNhomMoi(string tennhom, int madoan, string truongnhom)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlParameter[] prs = {
                new SqlParameter("@MaDA",SqlDbType.Int),
                new SqlParameter("@TenNhom", SqlDbType.NVarChar),
                new SqlParameter("@TruongNhom",SqlDbType.Char)};
                prs[0].Value = madoan;
                prs[1].Value = tennhom;
                prs[2].Value = truongnhom;
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
        public static int LaTruongNhom(int MaDA, string MSSV)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] prs =
                {
                    new SqlParameter("@MSSV", SqlDbType.Char),
                    new SqlParameter("@MaDA", SqlDbType.Int),
                    new SqlParameter("@KQ", SqlDbType.Int)
                };
                prs[0].Value = MaDA;
                prs[1].Value = MSSV;
                prs[2].Direction = ParameterDirection.Output;
                int n = sqlcmd.ExecuteNonQuery();
                if (n > 0)
                {
                    int KQ = Convert.ToInt32(prs[2].Value.ToString());
                    cnn.CloseSection();
                    if (KQ == 2)
                        return 1;
                    return 0;
                }

            }
            
            catch
            {
                return -1;
            }
        }
    }
}
