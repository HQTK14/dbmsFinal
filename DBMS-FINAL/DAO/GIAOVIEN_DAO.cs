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
    public class GIAOVIEN_DAO
    {
        public static  GIAOVIENDTO LayGV(string username, string password)
        {
            GIAOVIENDTO gvDTO = null;
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string query = string.Format(@"Select *
								                FROM GIAOVIEN
									             Where
									 		        MaGV = '{0}'
									 		        AND
									 		        PasswordHash = HASHBYTES('SHA2_512', '{1}'+CAST(Salt AS NVARCHAR(36)))"
                                            , username, password
                                            );
                SqlCommand cmd = new SqlCommand(query, cnn.connect);
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    gvDTO = new GIAOVIENDTO();
                    gvDTO.MaGV = Convert.ToString(dr["MaGV"]);
                    gvDTO.TenGV = Convert.ToString(dr["TenGV"]);
                    gvDTO.STD = Convert.ToString(dr["SDT"]);
                }
                return gvDTO;
            }
            catch
            {
                // throw ex;
                return null;
            }
            //finally
            //{

            //}
           

        }
        //public static List<string> layDanhSachMon_PhuTrach(string maGV)
        //{
        //    List<string> KQ = new List<string>();
        //    return KQ;
        //}
        //public static DataTable layDanhSachDoAnPhuTrach_Mon(string maGV, string maMon)
        //{
        //    string sql = string.Format(@"")
        //}
        public static DataTable layDSMONPT(string magv)
        {
            Connect_Helper cnn = new Connect_Helper();
            try
            {
                cnn.OpenSection();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("GET_ALL_SUBJECT", cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cnn.CloseSection();
                return dt;
                
            }
            catch
            {
                return null;
            }
        }

        public static string DangNhap(string magv, string password)
        {

            //    Connect_Helper cnn = new Connect_Helper();
            //    cnn.OpenSection();
            //    string ProcName = "TEACHER_LOGIN";
            //    SqlCommand sqlcmd = new SqlCommand(ProcName);
            //    sqlcmd.CommandType = CommandType.StoredProcedure;
            //    sqlcmd.Connection = cnn.connect;
            //    //SqlParameter[] prs =
            //    //{
            //    //    new SqlParameter("@id", SqlDbType.Char),
            //    //    new SqlParameter("@pwd", SqlDbType.NVarChar),
            //    //    new SqlParameter("@stringKQ", SqlDbType.NVarChar)
            //    //};
            //    //prs[0].Value = magv;
            //    //prs[1].Value = password;
            //    //prs[2].Direction = ParameterDirection.Output;
            //    //sqlcmd.Parameters.AddRange(prs);
            //    sqlcmd.Parameters.Add("@id", SqlDbType.Char).Value=magv;
            //    sqlcmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value=password;
            //    sqlcmd.Parameters.Add("@stringKQ", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
            //   int n = sqlcmd.ExecuteNonQuery();
            //    string KQ;
            //    if (n > 0)
            //    {
            //        KQ = (string)sqlcmd.Parameters["stringKQ"].Value;
            //        cnn.CloseSection();
            //    }
            //    else KQ = "";
            //    return KQ;

            //}

            //catch
            //{
            //    return "";
            //}
            try
            {
                Connect_Helper connectDB = new Connect_Helper();
                connectDB.OpenSection();
                string procedureName = "TEACHER_LOGIN";
                SqlCommand cmd = new SqlCommand(procedureName);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connectDB.connect;

                cmd.Parameters.Add("@id", SqlDbType.Char).Value = magv;
                cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.Add("@stringKQ", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
                int KQ = cmd.ExecuteNonQuery();
                string str = "";
                if (KQ > 0)
                {
                    str = (string)cmd.Parameters["stringKQ"].Value;
                }
                connectDB.CloseSection();
                return str;
            }
            catch
            {
                return "";
            }
        }
        public static DataTable layDanhSachDoAnPhuTrach_Mon(string maGV, string mamon)
        {
            string sql = string.Format(@"SELECT da.MaDoAn,
                                                da.TenDoAn,
                                                da.LoaiDoAn,
                                                da.SLN_ToiDa,
                                                da.SLSV_ToiDa,
                                                da.NgayKTDK,
                                                da.NgayNop
                                         FROM dbo.DOAN da, dbo.GV_PHUTRACH_DA pt
                                         WHERE pt.MaGV = '{0}' 
                                               AND pt.MaDoAn = da.MaDoAn
                                               AND da.MaMon = '{1}'", maGV, mamon);
            return new Connect_Helper().GetDataTable(sql);
        }
    }
}
