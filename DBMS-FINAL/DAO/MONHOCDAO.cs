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
        public static IList<MONHOCDTO> LAYDSMONHOC(string maSV)
        {
            List<MONHOCDTO> dsMon = new List<MONHOCDTO>();
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
                                        ",maSV
                                        );
            Connect_Helper cnn = new Connect_Helper();
            {
                cnn.OpenSection();
                SqlCommand cmd = new SqlCommand(sql, cnn.connect);
                DataSet dtSet = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtSet, "MONHOC");
                foreach (DataRow r in dtSet.Tables["MONHOC"].Rows)
                {
                    dsMon.Add(new MONHOCDTO()
                    {
                        MaMon = Convert.ToString(r["MaMon"]),
                        TenMon = Convert.ToString(r["TenMon"]),
                        SoTinChi = Convert.ToInt32(r["SoTinChi"]),
                        NgayBD = Convert.ToString(r["donGia"]),
                        NgayKT = Convert.ToString(r["slTrong"])

                    });
                }
                cnn.CloseSection();
            }
            return dsMon;
        }
    }
}
