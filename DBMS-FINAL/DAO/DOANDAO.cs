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
    public class DOANDAO
    {
        public static DataTable LocDSDA(string mamon,string mssv,  int option=0)
        {
            string sql = "";
            switch(option)
            {
                default:break;
                case 0:
                    sql = string.Format(@"
                                          SELECT da.MaDoAn, da.TenDoAn, da.LoaiDoAn,nh.TenNhom 
                                          FROM dbo.DOAN AS da,
	                                           dbo.NHOM AS nh,
	                                           dbo.MONHOC mh,
	                                           dbo.CHITIET_NHOM ctm
                                         WHERE ctm.maSV = '{0}' 
	                                           AND
	                                           ctm.MaNhom = nh.MaNhom
	                                           AND
	                                           ctm.MaDA = da.MaDoAn
	                                           AND
	                                           da.MaMon = mh.MaMon
	                                           AND
	                                           mh.MaMon = '{1}'


                                        ", mssv,mamon);
                    break;
                case 1:
                    sql = string.Format(@"
                                          SELECT da.MaDoAn,da.TenDoAn, da.LoaiDoAn,nh.TenNhom                                        
                                          FROM   dbo.DOAN AS da,
	                                             dbo.NHOM AS nh,
	                                             dbo.MONHOC mh,
	                                             dbo.CHITIET_NHOM ctm
                                          WHERE  ctm.maSV = '{0}' 
	                                             AND
	                                             ctm.MaNhom = nh.MaNhom
	                                             AND
	                                             ctm.MaDA = da.MaDoAn AND da.LoaiDoAn = N'Bài tập cộng điểm'
	                                             AND
	                                             da.MaMon = mh.MaMon
	                                             AND
	                                             mh.MaMon = '{1}'
                                       ", mssv,mamon);
                    break;
                case 2:
                    sql = string.Format(@"
                                          SELECT da.MaDoAn,da.TenDoAn, da.LoaiDoAn,nh.TenNhom                                        
                                          FROM   dbo.DOAN AS da,
	                                             dbo.NHOM AS nh,
	                                             dbo.MONHOC mh,
	                                             dbo.CHITIET_NHOM ctm
                                          WHERE  ctm.maSV = '{0}' 
	                                             AND
	                                             ctm.MaNhom = nh.MaNhom
	                                             AND
	                                             ctm.MaDA = da.MaDoAn AND da.LoaiDoAn = N'Giữa Kỳ'
	                                             AND
	                                             da.MaMon = mh.MaMon
	                                             AND
	                                             mh.MaMon = '{1}'
                                       ", mssv, mamon);
                    break;
                case 3:
                    sql = string.Format(@"
                                          SELECT da.MaDoAn,da.TenDoAn, da.LoaiDoAn,nh.TenNhom                                        
                                          FROM   dbo.DOAN AS da,
	                                             dbo.NHOM AS nh,
	                                             dbo.MONHOC mh,
	                                             dbo.CHITIET_NHOM ctm
                                          WHERE  ctm.maSV = '{0}' 
	                                             AND
	                                             ctm.MaNhom = nh.MaNhom
	                                             AND
	                                             ctm.MaDA = da.MaDoAn AND da.LoaiDoAn = N'Cuối Kỳ'
	                                             AND
	                                             da.MaMon = mh.MaMon
	                                             AND
	                                             mh.MaMon = '{1}'
                                       ", mssv, mamon);
                    break;
            }
            Connect_Helper cnn = new Connect_Helper();
            return cnn.GetDataTable(sql);

        }
    }
}
