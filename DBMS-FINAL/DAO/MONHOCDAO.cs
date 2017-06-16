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
    public class MONHOCDAO
    {
        public static DataTable GET_ALL_SUBJECT()
        {
            Connect_Helper cnn = new Connect_Helper();
            try
            {
                cnn.OpenSection();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT_ALL_SUBJECT", cnn.connect);
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
        public static bool Create_Update_Subject(MONHOCDTO mhDTO, string opt)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string procedureName = opt;
                SqlCommand cmd = new SqlCommand(procedureName, cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaMon", SqlDbType.Char).Value = mhDTO.MaMon;
                cmd.Parameters.Add("@TenMon", SqlDbType.NVarChar).Value = mhDTO.TenMon;
                cmd.Parameters.Add("@SoTinChi", SqlDbType.Int).Value = mhDTO.SoTinChi;
                cmd.Parameters.Add("@NgayDB", SqlDbType.Date).Value = mhDTO.NgayBD;
                cmd.Parameters.Add("@NgayKT", SqlDbType.Date).Value = mhDTO.NgayKT;
                int KQ = cmd.ExecuteNonQuery();
                if (KQ > 0)
                {
                    return true;

                }
                return false;
            }
            catch
            {
                // throw ex;
                return false;
            }
        }
        public static bool Disable_Subject(string start, string end, string mamon)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string procedureName = "DISABLE_SUBJECT";
                SqlCommand cmd = new SqlCommand(procedureName, cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@disablefrom", SqlDbType.Date).Value = start;
                cmd.Parameters.Add("@disableto", SqlDbType.Date).Value = end;
                cmd.Parameters.Add("@MaMon", SqlDbType.Char).Value = mamon;
                int KQ = cmd.ExecuteNonQuery();
                if (KQ > 0)
                {
                    return true;

                }
                return false;
            }
            catch
            {
                // throw ex;
                return false;
            }
        }
        public static bool Enable_Subject(string mamon)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string procedureName = "ENABLE_SUBJECT";
                SqlCommand cmd = new SqlCommand(procedureName, cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaMon", SqlDbType.Char).Value = mamon;
                int KQ = cmd.ExecuteNonQuery();
                if (KQ > 0)
                {
                    return true;

                }
                return false;
            }
            catch
            {
                // throw ex;
                return false;
            }
        }
        public static bool Remove_Subject(string mamon)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string procedureName = "REMOVE_SUBJECT";
                SqlCommand cmd = new SqlCommand(procedureName, cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaMon", SqlDbType.Char).Value = mamon;
  
                int KQ = cmd.ExecuteNonQuery();
                if (KQ > 0)
                {
                    return true;

                }
                return false;
            }
            catch
            {
                // throw ex;
                return false;
            }
        }
        public static DataTable _LAYDSMONHOC(string maSV)
        {
            Connect_Helper cnn = new Connect_Helper();
            string sql = string.Format(@"
                                        SELECT mh.MaMon,
                                               mh.TenMon,
                                               mh.SoTinChi,
                                               mh.NgayDB,
                                               mh.NgayKT
                                        FROM 
	                                           dbo.MONHOC mh,
	                                           dbo.SINHVIEN_MONHOC sv_mh
                                        WHERE 
                                               sv_mh.MSSV = '{0}'
                                             AND
                                               sv_mh.MaMon = mh.MaMon
                                        ", maSV
                                        );
            return cnn.GetDataTable(sql);
        }
        //public static IList<MONHOCDTO> LAYDSMONHOC(string maSV)
        //{
        //    List<MONHOCDTO> dsMon = new List<MONHOCDTO>();
        //    string sql = string.Format(@"
        //                                SELECT mh.MaMon,
        //                                       mh.TenMon,
        //                                       mh.SoTinChi,
        //                                       mh.NgayDB,
        //                                       mh.NgayKT
        //                                FROM 
	       //                                    dbo.MONHOC mh,
	       //                                    dbo.SINHVIEN_MONHOC sv_mh
        //                                WHERE 
        //                                       sv_mh.MSSV = '{0}'
        //                                     AND
        //                                       sv_mh.MaMon = mh.MaMon
        //                                ",maSV
        //                                );
        //    Connect_Helper cnn = new Connect_Helper();
        //    {
        //        cnn.OpenSection();
        //        SqlCommand cmd = new SqlCommand(sql, cnn.connect);
        //        DataSet dtSet = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dtSet, "MONHOC");
        //        foreach (DataRow r in dtSet.Tables["MONHOC"].Rows)
        //        {
        //            dsMon.Add(new MONHOCDTO()
        //            {
        //                MaMon = Convert.ToString(r["MaMon"]),
        //                TenMon = Convert.ToString(r["TenMon"]),
        //                SoTinChi = Convert.ToInt32(r["SoTinChi"]),
        //                NgayBD = Convert.ToString(r["donGia"]),
        //                NgayKT = Convert.ToString(r["slTrong"])

        //            });
        //        }
        //        cnn.CloseSection();
        //    }
        //    return dsMon;
        //}
    }
}
