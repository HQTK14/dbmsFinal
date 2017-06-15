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
    public class SINHVIEN_DAO
    {
        public static DataTable laytatcaSV()
        {
            Connect_Helper cnn = new Connect_Helper();
            return cnn.GetDataTable("SELECT MSSV,TENSV, SDT FROM SINHVIEN");
        }
        public static DataTable laySV(string mssv)
        {
            string sql = string.Format(@"SELECT MSSV,TENSV, SDT FROM SINHVIEN WHERE MSSV LIKE '%{0}%'", mssv);
            Connect_Helper cnn = new Connect_Helper();
            return cnn.GetDataTable(sql);
        }

        public static SINHVIENDTO laySinhVien(string username, string password)
        {
            SINHVIENDTO svDTO = null;
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string query = string.Format(@"Select *
								                FROM SINHVIEN
									             Where
									 		        MSSV = '{0}'
									 		        AND
									 		        PasswordHash = HASHBYTES('SHA2_512', '{1}'+CAST(Salt AS NVARCHAR(36)))"
                                            ,username, password
                                            );
                SqlCommand cmd = new SqlCommand(query, cnn.connect);
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    svDTO = new SINHVIENDTO();
                    svDTO.MSSV = Convert.ToString(dr["MSSV"]);
                    svDTO.TenSV = Convert.ToString(dr["TenSV"]);
                    svDTO.STD = Convert.ToString(dr["SDT"]);
                }
            }
            catch
            {

            }
            finally
            {

            }
            return svDTO;

        }

        //int maNhom, string MSSV, int MaDA
       
        public static int huyNhom(int maNhom, string mssv)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlParameter[] prs = { new SqlParameter("@MaNhom", SqlDbType.Int), new SqlParameter("@MaSV", SqlDbType.VarChar) };
                prs[0].Value = maNhom;
                prs[1].Value = mssv;
                SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
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
        public static int dangkiDA(int maNhom, int maDA, int maDe)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlParameter[] prs = {
                    new SqlParameter("@MaNhom", SqlDbType.Int),
                    new SqlParameter("@MaDA", SqlDbType.VarChar),
                    new SqlParameter("@MaDe", SqlDbType.Int)
                };
                prs[0].Value = maNhom;
                prs[1].Value = maDA;
                prs[2].Value = maDe;
                SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
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
        public static int huyDKDA(int maNhom, int maDA, int maDe)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string ProcName = "";
                SqlParameter[] prs = {
                    new SqlParameter("@MaNhom", SqlDbType.Int),
                    new SqlParameter("@MaDA", SqlDbType.VarChar),
                    new SqlParameter("@MaDe", SqlDbType.Int)
                };
                prs[0].Value = maNhom;
                prs[1].Value = maDA;
                prs[2].Value = maDe;
                SqlCommand sqlcmd = new SqlCommand(ProcName, cnn.connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
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
