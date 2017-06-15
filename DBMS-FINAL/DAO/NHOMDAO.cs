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
                string ProcName = "CREATE_GROUP";
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
        public static int maxnhom(int madoan)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "CHECK_EXCEED_NUMBER_Of_GROUP";
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
                sqlcmd.Parameters.Add("@MaDoAn", SqlDbType.Int).Value = madoan;
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
        public static string Laytruongnhom(int madoan, int manhom)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "RETRIEVE_LEADER_GROUP";
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
                sqlcmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = madoan;
                sqlcmd.Parameters.Add("@MaNhom", SqlDbType.Int).Value = madoan;
                sqlcmd.Parameters.Add("@stringKQ", SqlDbType.Int).Direction = ParameterDirection.Output;
                int n = sqlcmd.ExecuteNonQuery();
                if (n > 0)
                {
                    //int KQ = Convert.ToInt32(prs[1].Value.ToString());
                    string KQ = Convert.ToString(sqlcmd.Parameters["@stringKQ"].Value);
                    cnn.CloseSection();
                    if (KQ != "")
                        return KQ;
                    else
                        return "";
                }
                else return "";

            }

            catch
            {
                return "";
            }
        }
    }
}
